using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayvanTakip.DataAccess.Context;
using HayvanTakip.Entities;

namespace HayvanTakip.DataAccess.Repositories
{
    public class IsletmeRepository
    {
        public List<Isletme> GetAll()
        {
            using (var context = new HayvanTakipContext())
            {
                return context.Isletmeler
                      .OrderBy(x => x.IsletmeAdi)
                      .ToList();
            }
        }

        public void Add(Isletme isletme)
        {
            using (var context = new HayvanTakipContext())
            {
                context.Isletmeler.Add(isletme);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new HayvanTakipContext())
            {
                var isletme = context.Isletmeler.Find(id);

                if (isletme == null)
                {
                    throw new Exception("Silinecek işletme bulunamadı.");
                }

                isletme.AktifMi = false;
                context.SaveChanges();
            }
        }

        public void Update(Isletme yeniIsletme)
        {
            using (var context = new HayvanTakipContext())
            {
                if (yeniIsletme == null)
                {
                    throw new Exception("Güncellenecek veri gönderilmedi.");
                }

                var isletme = context.Isletmeler.Find(yeniIsletme.Id);

                if (isletme == null)
                {
                    throw new Exception("Güncellenecek işletme bulunamadı.");
                }

                isletme.IsletmeNo = yeniIsletme.IsletmeNo;
                isletme.IsletmeAdi = yeniIsletme.IsletmeAdi;
                isletme.IlKodu = yeniIsletme.IlKodu;
                isletme.IlceKodu = yeniIsletme.IlceKodu;
                isletme.YetkiliTckn = yeniIsletme.YetkiliTckn;
                isletme.Adres = yeniIsletme.Adres;
                isletme.AktifMi = yeniIsletme.AktifMi;

                context.SaveChanges();
            }
        }

        public Isletme GetById(int id)
        {
            using (var context = new HayvanTakipContext())
            {
                return context.Isletmeler.Find(id);
            }
        }

        public bool IsletmeNoVarMi(string isletmeNo, int? id = null)
        {
            using (var context = new HayvanTakipContext())
            {
                return context.Isletmeler
                    .Any(x => x.IsletmeNo == isletmeNo && x.Id != id);
            }
        }

        public List<Isletme> GetAktif()
        {
            using (var context = new HayvanTakipContext())
            {
                return context.Isletmeler
                    .Where(x => x.AktifMi)
                    .OrderBy(x => x.IsletmeAdi)
                    .ToList();
            }
        }

        public List<Isletme> Search(
               string isletmeNo,
               string isletmeAdi,
               string ilKodu,
               bool? aktifMi)
        {
            using (var context = new HayvanTakipContext())
            {
                var sorgu = context.Isletmeler.AsQueryable();

                if (!string.IsNullOrWhiteSpace(isletmeNo))
                {
                    sorgu = sorgu.Where(
                        x => x.IsletmeNo.Contains(isletmeNo)
                    );
                }

                if (!string.IsNullOrWhiteSpace(isletmeAdi))
                {
                    sorgu = sorgu.Where(
                        x => x.IsletmeAdi.Contains(isletmeAdi)
                    );
                }

                if (!string.IsNullOrWhiteSpace(ilKodu))
                {
                    sorgu = sorgu.Where(
                        x => x.IlKodu == ilKodu
                    );
                }

                if (aktifMi.HasValue)
                {
                    sorgu = sorgu.Where(
                        x => x.AktifMi == aktifMi.Value
                    );
                }

                return sorgu
                    .Where(x => x.AktifMi)
                    .OrderBy(x => x.IsletmeAdi)
                    .ToList();
            }
        }
    }
    
}
