using HayvanTakip.DataAccess.Context;
using HayvanTakip.Entities;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;

namespace HayvanTakip.DataAccess.Repositories
{
    public class TedaviRepository
    {

    public List<Tedavi> GetAll()
        {
            using (var context = new HayvanTakipContext())
            {
                return context.Tedaviler
                    .Include(x => x.Hastalik.Hayvan.Isletme)
                    .OrderByDescending(x => x.BaslangicTarihi)
                    .ToList();
            }
        }

    public void Add(Tedavi tedavi)
        {
            using (var context = new HayvanTakipContext())
            { 
            context.Tedaviler.Add(tedavi);
            context.SaveChanges();
            }
        }

        public bool Delete(int id)
        {
            using (var context = new HayvanTakipContext())
            {
                var veri = context.Tedaviler.Find(id);

                if (veri == null)
                {
                    return false;
                }

                context.Tedaviler.Remove(veri);
                context.SaveChanges();

                return true;
            }
        }


        public void Update(Tedavi tedavi)
        {
            using (var context = new HayvanTakipContext())
            {
                var eskiVeri = context.Tedaviler.Find(tedavi.Id);

                if (eskiVeri == null)
                {
                    return;
                }

                eskiVeri.HastalikId = tedavi.HastalikId;
                eskiVeri.TedaviAdi = tedavi.TedaviAdi;
                eskiVeri.IlacAdi = tedavi.IlacAdi;
                eskiVeri.BaslangicTarihi = tedavi.BaslangicTarihi;
                eskiVeri.BitisTarihi = tedavi.BitisTarihi;
                eskiVeri.DozBilgisi = tedavi.DozBilgisi;
                eskiVeri.Aciklama = tedavi.Aciklama;

                context.SaveChanges();
            }
        }

        public Tedavi GetById(int id)
        {
            using (var context = new HayvanTakipContext())
            {
                var veri = context.Tedaviler.Find(id);
                return veri;
            }
        }
    }
}
