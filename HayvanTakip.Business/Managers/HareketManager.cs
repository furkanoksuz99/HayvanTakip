using HayvanTakip.DataAccess.Repositories;
using HayvanTakip.Entities;
using System;
using System.Collections.Generic;

namespace HayvanTakip.Business.Managers
{
    public class HareketManager
    {
        private readonly HareketRepository _repository;

        public HareketManager()
        {
            _repository = new HareketRepository();
        }

        public List<Hareket> GetAll()
        {
            return _repository.GetAll();
        }

        public Hareket GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Add(Hareket hareket)
        {
            KontrolEt(hareket);

            _repository.Add(hareket);
        }

        public void Update(Hareket hareket)
        {
            KontrolEt(hareket);

            var mevcut = _repository.GetById(hareket.Id);

            if (mevcut == null)
            {
                throw new Exception(
                    "Güncellenecek hareket kaydı bulunamadı."
                );
            }

            _repository.Update(hareket);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        private void KontrolEt(Hareket hareket)
        {
            if (hareket == null)
            {
                throw new Exception(
                    "Hareket bilgisi gönderilmedi."
                );
            }

            if (hareket.HayvanId <= 0)
            {
                throw new Exception(
                    "Lütfen hayvan seçiniz."
                );
            }

            if (hareket.HareketTarihi == DateTime.MinValue)
            {
                throw new Exception(
                    "Hareket tarihi seçilmelidir."
                );
            }

            if (hareket.HareketTarihi.Date > DateTime.Today)
            {
                throw new Exception(
                    "Hareket tarihi bugünden ileri olamaz."
                );
            }

            if (hareket.KaynakIsletmeId.HasValue &&
                hareket.HedefIsletmeId.HasValue &&
                hareket.KaynakIsletmeId.Value ==
                hareket.HedefIsletmeId.Value)
            {
                throw new Exception(
                    "Kaynak ve hedef işletme aynı olamaz."
                );
            }

            hareket.Aciklama =
                hareket.Aciklama?.Trim();
        }
    }
}