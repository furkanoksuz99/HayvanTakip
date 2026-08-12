using HayvanTakip.DataAccess.Context;
using HayvanTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HayvanTakip.DataAccess.Repositories
{
    public class HastalikRepository
    {

        public List<Hastalik> GetAll()
        {
            using (var context = new HayvanTakipContext())
            {
                return context.Hastaliklar
                    .Include(x => x.Hayvan.Isletme)
                    .OrderByDescending(x => x.TeshisTarihi)
                    .ToList();
            }
        }

        public void Add(Hastalik hastalik)
        {
            using (var context = new HayvanTakipContext())
            {
                context.Hastaliklar.Add(hastalik);
                context.SaveChanges();
            }
        }

        public void Update(Hastalik hastalik)
        {
            using (var context = new HayvanTakipContext())
            {
                var eskiVeri = context.Hastaliklar.Find(hastalik.Id);

                if (eskiVeri == null)
                {
                    return;
                }

                eskiVeri.HayvanId = hastalik.HayvanId;
                eskiVeri.HastalikAdi = hastalik.HastalikAdi;
                eskiVeri.TeshisTarihi = hastalik.TeshisTarihi;
                eskiVeri.Belirtiler = hastalik.Belirtiler;
                eskiVeri.Aciklama = hastalik.Aciklama;
                eskiVeri.DevamEdiyorMu = hastalik.DevamEdiyorMu;

                context.SaveChanges();
            }
        }

        public Hastalik GetById(int id)
        {
            using (var context = new HayvanTakipContext())
            {
                return context.Hastaliklar.Find(id);
            }
        }

        public bool Delete(int id)
        {
            using (var context = new HayvanTakipContext())
            {
                var hastalik = context.Hastaliklar.Find(id);

                if (hastalik == null)
                {
                    return false;
                }

                context.Hastaliklar.Remove(hastalik);
                context.SaveChanges();

                return true;
            }
        }
    }
}
