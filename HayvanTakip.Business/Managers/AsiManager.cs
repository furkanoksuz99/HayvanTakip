using System;
using System.Collections.Generic;
using HayvanTakip.DataAccess.Repositories;
using HayvanTakip.Entities;

namespace HayvanTakip.Business.Managers
{
    public class AsiManager
    {
        private readonly AsiRepository _repository;

        public AsiManager()
        {
            _repository = new AsiRepository();
        }

        public List<Asi> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Asi> Search(
            string kupeNo,
            string asiAdi,
            DateTime? baslangicTarihi,
            DateTime? bitisTarihi)
        {
            kupeNo = kupeNo?.Trim();
            asiAdi = asiAdi?.Trim();

            return _repository.Search(
                kupeNo,
                asiAdi,
                baslangicTarihi,
                bitisTarihi
            );
        }

        public void Add(Asi asi)
        {
            AsiKurallariniKontrolEt(asi);

            _repository.Add(asi);
        }

        public void Update(Asi asi)
        {
            AsiKurallariniKontrolEt(asi);

            var mevcutAsi = _repository.GetById(asi.Id);

            if (mevcutAsi == null)
            {
                throw new Exception(
                    "Güncellenecek aşı kaydı bulunamadı."
                );
            }

            _repository.Update(asi);
        }

        public Asi GetById(int id)
        {
            return _repository.GetById(id);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        private void AsiKurallariniKontrolEt(Asi asi)
        {
            if (asi == null)
            {
                throw new Exception(
                    "Aşı bilgisi gönderilmedi."
                );
            }

            if (asi.HayvanId <= 0)
            {
                throw new Exception(
                    "Lütfen bir hayvan seçiniz."
                );
            }

            if (string.IsNullOrWhiteSpace(asi.AsiAdi))
            {
                throw new Exception(
                    "Aşı adı boş bırakılamaz."
                );
            }

            if (asi.AsiTarihi == DateTime.MinValue)
            {
                throw new Exception(
                    "Aşı tarihi seçilmelidir."
                );
            }

            if (asi.AsiTarihi.Date > DateTime.Today)
            {
                throw new Exception(
                    "Uygulanan aşı tarihi bugünden ileri olamaz."
                );
            }

            if (asi.SonrakiAsiTarihi.HasValue &&
                asi.SonrakiAsiTarihi.Value.Date
                < asi.AsiTarihi.Date)
            {
                throw new Exception(
                    "Sonraki aşı tarihi, uygulanan aşı tarihinden önce olamaz."
                );
            }

            asi.AsiAdi = asi.AsiAdi.Trim();
            asi.Aciklama = asi.Aciklama?.Trim();
        }

        public List<Asi> GetYaklasan()
        {
            var veriler = _repository.GetYaklasan();
            return veriler; 
        }

        public List<Asi> GetGeciken()
        {
            var veriler = _repository.GetGeciken();
            return veriler;
        }
    }
}