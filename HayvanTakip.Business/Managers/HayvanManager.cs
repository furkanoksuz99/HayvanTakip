using HayvanTakip.DataAccess.Repositories;
using HayvanTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanTakip.Business.Managers
{
    public class HayvanManager
    {
        private readonly HayvanRepository _repository;

        public HayvanManager()
        {
            _repository = new HayvanRepository();
        }

        public List<Hayvan> GetAll()
        {
            return _repository.GetAll();
        }

        public void Add(Hayvan hayvan)
        {
            if (_repository.KupeNoVarMi(hayvan.KupeNo,hayvan.Id))
            {
               throw new Exception("Bu küpe numarası zaten kayıtlı.");

            }
            if (hayvan.DogumTarihi > DateTime.Today)
            {
                throw new Exception("Doğum tarihi bugünden ileri olamaz.");
            }

            if (_repository.IsletmeAktifMi(hayvan.IsletmeId))
            {
                _repository.Add(hayvan);
            }
            else
            {
                throw new Exception("İşletme Aktif Değildir");
            }
            
        }

        public void Update(Hayvan hayvan)
        {
            _repository.Update(hayvan);
        }

        public Hayvan GetById(int id)
        {
           var hayvan = _repository.GetById(id);
           return hayvan;

        }

        public void PasifAl(int id)
        {
            _repository.PasifAl(id);
        }

        public List<Hayvan> GetPasif()
        {
            var hayvanlar =_repository.GetPasif();
            return hayvanlar;
        }

        public List<Hayvan> GetAktif()
        {
           var hayvanlar = _repository.GetAktif();
            return hayvanlar;
        }

        public List<Hayvan> Search(
    string kupeNo,
      string tur,
      string irk,
      int? isletmeId,
      HayvanCinsiyeti? cinsiyet,
      HayvanDurumu? durum)
        {
            kupeNo = kupeNo?.Trim();
            tur = tur?.Trim();
            irk = irk?.Trim();

            return _repository.Search(
                kupeNo,
                tur,
                irk,
                isletmeId,
                cinsiyet,
                durum
            );
        }
    }
}
