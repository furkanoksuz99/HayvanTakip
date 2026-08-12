using HayvanTakip.DataAccess.Context;
using HayvanTakip.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Security.Principal;


namespace HayvanTakip.DataAccess.Repositories
{
    public class HayvanRepository
    {
        public List<Hayvan> GetAll()
        {
            using (var context = new HayvanTakipContext())
            {
                return context.Hayvanlar
                    .Include(x => x.Isletme)
                    .OrderBy(x => x.KupeNo)
                    .ToList();
            }
        }

        public void Add(Hayvan hayvan)
        {
            using (var context = new HayvanTakipContext())
            {
                context.Hayvanlar.Add(hayvan);
                context.SaveChanges();
            }
        }

        public void Update(Hayvan yeniHayvan)
        {
            using (var context = new HayvanTakipContext())
            {

                var hayvan = context.Hayvanlar.Find(yeniHayvan.Id);
                hayvan.Id = yeniHayvan.Id;
                hayvan.KupeNo = yeniHayvan.KupeNo;
                hayvan.Cinsiyet = yeniHayvan.Cinsiyet;
                hayvan.IsletmeId = yeniHayvan.IsletmeId;
                hayvan.DogumTarihi = yeniHayvan.DogumTarihi;
                hayvan.Tur = yeniHayvan.Tur;
                hayvan.Durum =  yeniHayvan.Durum;
                hayvan.Irk = yeniHayvan.Irk;
                context.SaveChanges() ;
            }
        }

        public Hayvan GetById(int id)
        {
            using (var context = new HayvanTakipContext())
            {
                var hayvan = context.Hayvanlar.Find(id);
                return hayvan;
            }

        }

        public void PasifAl(int id)
        {
            using (var context = new HayvanTakipContext())
            {
                var hayvan = context.Hayvanlar.Find(id);
                hayvan.Durum = HayvanDurumu.Pasif;
                context.SaveChanges();

            }
        }

        public List<Hayvan> GetPasif()
        {
            using (var context = new HayvanTakipContext())
            {
                return context.Hayvanlar
                     .Include(x => x.Isletme)
                    .Where(x => x.Durum == HayvanDurumu.Pasif)
                    .ToList();
            }
        }

        public List<Hayvan> GetAktif()
        {
            using (var context = new HayvanTakipContext())
            {
                return context.Hayvanlar
                     .Include(x => x.Isletme)
                    .Where(x => x.Durum == HayvanDurumu.Aktif)
                    .ToList();
            }
        }

        public List<Hayvan> Search(
      string kupeNo,
      string tur,
      string irk,
      int? isletmeId,
      HayvanCinsiyeti? cinsiyet,
      HayvanDurumu? durum)
        {
            using (var context = new HayvanTakipContext())
            {
                var sorgu = context.Hayvanlar
                    .Include(x => x.Isletme)
                    .AsQueryable();

                if (!string.IsNullOrWhiteSpace(kupeNo))
                {
                    sorgu = sorgu.Where(x => x.KupeNo.Contains(kupeNo));
                }

                if (!string.IsNullOrWhiteSpace(tur))
                {
                    sorgu = sorgu.Where(x => x.Tur.Contains(tur));
                }

                if (!string.IsNullOrWhiteSpace(irk))
                {
                    sorgu = sorgu.Where(x => x.Irk.Contains(irk));
                }

                if (isletmeId.HasValue)
                {
                    sorgu = sorgu.Where(x => x.IsletmeId == isletmeId.Value);
                }

                if (cinsiyet.HasValue)
                {
                    sorgu = sorgu.Where(x => x.Cinsiyet == cinsiyet.Value);
                }

                if (durum.HasValue)
                {
                    sorgu = sorgu.Where(x => x.Durum == durum.Value);
                }

                return sorgu
                    .OrderBy(x => x.KupeNo)
                    .ToList();
            }
        }

        public bool KupeNoVarMi(string kupeNo, int? id = null)
        {
            using (var context = new HayvanTakipContext())
            {
                return context.Hayvanlar
                    .Any(x => x.KupeNo == kupeNo && x.Id != id);
            }
        }

        public bool IsletmeAktifMi(int? isletmeId)
        {
            using (var context = new HayvanTakipContext())
            {
                var isletme = context.Isletmeler.Find(isletmeId);
                return isletme.AktifMi;           
            }
        }
    }
}