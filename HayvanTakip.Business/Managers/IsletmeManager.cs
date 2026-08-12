using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using HayvanTakip.DataAccess.Repositories;
using HayvanTakip.Entities;

namespace HayvanTakip.Business.Managers
{
    public class IsletmeManager
    {
        private readonly IsletmeRepository _repository;

        public IsletmeManager()
        {
            _repository = new IsletmeRepository();
        }

        public List<Isletme> GetAll()
        {
            return _repository.GetAll();
        }



        public void Delete(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Geçersiz işletme Id değeri.");
            }

            _repository.Delete(id);
        }

        public void Add(Isletme isletme)
        {
            if (isletme == null)
            {
                throw new Exception("İşletme bilgisi gönderilmedi.");
            }

            if (string.IsNullOrWhiteSpace(isletme.IsletmeNo))
            {
                throw new Exception("İşletme numarası zorunludur.");
            }

            if (string.IsNullOrWhiteSpace(isletme.IsletmeAdi))
            {
                throw new Exception("İşletme adı zorunludur.");
            }

            if (_repository.IsletmeNoVarMi(isletme.IsletmeNo))
            {
                throw new Exception("Bu Numarada Bir İşletme Mevcut");
            }

            isletme.AktifMi = true;
            isletme.KayitTarihi = DateTime.Now;

            _repository.Add(isletme);
          
            

        }

        public void Update(Isletme isletme)
        {
            if (isletme == null)
            {
                throw new Exception("Güncellenecek işletme bilgisi gönderilmedi.");
            }

            if (isletme.Id <= 0)
            {
                throw new Exception("Geçersiz işletme Id değeri.");
            }

            if (string.IsNullOrWhiteSpace(isletme.IsletmeNo))
            {
                throw new Exception("İşletme numarası zorunludur.");
            }

            if (string.IsNullOrWhiteSpace(isletme.IsletmeAdi))
            {
                throw new Exception("İşletme adı zorunludur.");
            }

            if (_repository.IsletmeNoVarMi(isletme.IsletmeNo,isletme.Id))
            {
                throw new Exception("Bu Numarada Bir İşletme Mevcut");
            }

            _repository.Update(isletme);
        }

        public Isletme GetById(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Geçersiz işletme Id değeri.");
            }

            var isletme = _repository.GetById(id);

            if (isletme == null)
            {
                throw new Exception("İşletme bulunamadı.");
            }

            return isletme;
        }

        public List<Isletme> Search(
    string isletmeNo,
    string isletmeAdi,
    string ilKodu,
    bool? aktifMi)
        {
            isletmeNo = isletmeNo?.Trim();
            isletmeAdi = isletmeAdi?.Trim();
            ilKodu = ilKodu?.Trim();

            return _repository.Search(
                isletmeNo,
                isletmeAdi,
                ilKodu,
                aktifMi
            );
        }

        public List<Isletme> GetAktif()
        {
            var isletmeler = _repository.GetAktif();
            return isletmeler;
        }
    }
}
