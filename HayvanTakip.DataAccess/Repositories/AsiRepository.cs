using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using HayvanTakip.DataAccess.Context;
using HayvanTakip.Entities;

namespace HayvanTakip.DataAccess.Repositories
{
    public class AsiRepository
    {
        public List<Asi> GetAll()
        {
            using (var context = new HayvanTakipContext())
            {
                return context.Asilar
                    .Include(x => x.Hayvan.Isletme)
                    .OrderByDescending(x => x.AsiTarihi)
                    .ToList();
            }
        }

        public List<Asi> Search(
            string kupeNo,
            string asiAdi,
            DateTime? baslangicTarihi,
            DateTime? bitisTarihi)
        {
            using (var context = new HayvanTakipContext())
            {
                var sorgu = context.Asilar
                    .Include(x => x.Hayvan.Isletme)
                    .AsQueryable();

                if (!string.IsNullOrWhiteSpace(kupeNo))
                {
                    sorgu = sorgu.Where(
                        x => x.Hayvan.KupeNo.Contains(kupeNo)
                    );
                }

                if (!string.IsNullOrWhiteSpace(asiAdi))
                {
                    sorgu = sorgu.Where(
                        x => x.AsiAdi.Contains(asiAdi)
                    );
                }

                if (baslangicTarihi.HasValue)
                {
                    var baslangic =
                        baslangicTarihi.Value.Date;

                    sorgu = sorgu.Where(
                        x => x.AsiTarihi >= baslangic
                    );
                }

                if (bitisTarihi.HasValue)
                {
                    var bitisSonrasi =
                        bitisTarihi.Value.Date.AddDays(1);

                    sorgu = sorgu.Where(
                        x => x.AsiTarihi < bitisSonrasi
                    );
                }

                return sorgu
                    .OrderByDescending(x => x.AsiTarihi)
                    .ToList();
            }
        }

        public void Add(Asi asi)
        {
            using (var context = new HayvanTakipContext())
            {
                context.Asilar.Add(asi);

                context.SaveChanges();
            }
        }

        public Asi GetById(int id)
        {
            using (var context = new HayvanTakipContext())
            {
                return context.Asilar
                    .FirstOrDefault(x => x.Id == id);
            }
        }

        public void Update(Asi asi)
        {
            using (var context = new HayvanTakipContext())
            {
                var eskiAsi = context.Asilar
                    .FirstOrDefault(x => x.Id == asi.Id);

                if (eskiAsi == null)
                {
                    return;
                }

                eskiAsi.HayvanId = asi.HayvanId;
                eskiAsi.AsiAdi = asi.AsiAdi;
                eskiAsi.AsiTarihi = asi.AsiTarihi;
                eskiAsi.SonrakiAsiTarihi =
                    asi.SonrakiAsiTarihi;
                eskiAsi.Aciklama = asi.Aciklama;


                context.SaveChanges();
            }
        }

        public bool Delete(int id)
        {
            using (var context = new HayvanTakipContext())
            {
                var asi = context.Asilar
                    .FirstOrDefault(x => x.Id == id);

                if (asi == null)
                {
                    return false;
                }

                context.Asilar.Remove(asi);

                context.SaveChanges();

                return true;
            }
        }

        public List<Asi> GetYaklasan(int gun = 15)
        {
            using (var context = new HayvanTakipContext())
            {
                var bugun = DateTime.Today;
                var bitisTarihi = bugun.AddDays(gun + 1);

                return context.Asilar
                    .Include(x => x.Hayvan.Isletme)
                    .Where(x =>
                        x.SonrakiAsiTarihi.HasValue &&
                        x.SonrakiAsiTarihi.Value >= bugun &&
                        x.SonrakiAsiTarihi.Value < bitisTarihi)
                    .OrderBy(x => x.SonrakiAsiTarihi)
                    .ToList();
            }
        }

        public List<Asi> GetGeciken()
        {
            using (var context = new HayvanTakipContext())
            {
                var bugun = DateTime.Today; 
                return context.Asilar
                    .Include(x => x.Hayvan.Isletme)
                    .Where(x => 
                    x.SonrakiAsiTarihi.HasValue &&
                        x.SonrakiAsiTarihi.Value <= bugun)
                    .OrderBy(x => x.SonrakiAsiTarihi).ToList();

            }
        }
    }
}