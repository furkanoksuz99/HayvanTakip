using HayvanTakip.DataAccess.Context;
using HayvanTakip.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HayvanTakip.DataAccess.Repositories
{
    public class HareketRepository
    {
        public List<Hareket> GetAll()
        {
            using (var context = new HayvanTakipContext())
            {
                return context.Hareketler
                    .Include(x => x.Hayvan.Isletme)
                    .Include(x => x.KaynakIsletme)
                    .Include(x => x.HedefIsletme)
                    .OrderByDescending(x => x.HareketTarihi)
                    .ToList();
            }
        }

        public Hareket GetById(int id)
        {
            using (var context = new HayvanTakipContext())
            {
                return context.Hareketler
                    .Include(x => x.Hayvan)
                    .Include(x => x.KaynakIsletme)
                    .Include(x => x.HedefIsletme)
                    .FirstOrDefault(x => x.Id == id);
            }
        }

        public void Add(Hareket hareket)
        {
            using (var context = new HayvanTakipContext())
            {
                context.Hareketler.Add(hareket);
                context.SaveChanges();
            }
        }

        public void Update(Hareket hareket)
        {
            using (var context = new HayvanTakipContext())
            {
                var eskiVeri = context.Hareketler.Find(hareket.Id);

                if (eskiVeri == null)
                {
                    return;
                }

                eskiVeri.HayvanId = hareket.HayvanId;
                eskiVeri.HareketTipi = hareket.HareketTipi;
                eskiVeri.KaynakIsletmeId = hareket.KaynakIsletmeId;
                eskiVeri.HedefIsletmeId = hareket.HedefIsletmeId;
                eskiVeri.HareketTarihi = hareket.HareketTarihi;
                eskiVeri.Aciklama = hareket.Aciklama;

                context.SaveChanges();
            }
        }

        public bool Delete(int id)
        {
            using (var context = new HayvanTakipContext())
            {
                var veri = context.Hareketler.Find(id);

                if (veri == null)
                {
                    return false;
                }

                context.Hareketler.Remove(veri);
                context.SaveChanges();

                return true;
            }
        }
    }
}