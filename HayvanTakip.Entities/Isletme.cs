using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HayvanTakip.Entities
{
    [Table("Isletmeler")]

    public class Isletme
    {
        public int Id { get; set; }

        public string IsletmeNo { get; set; }

        public string IsletmeAdi { get; set; }

        public string IlKodu { get; set; }

        public string IlceKodu { get; set; }

        public string Adres { get; set; }

        public string YetkiliTckn { get; set; }

        public bool AktifMi { get; set; }

        public DateTime KayitTarihi { get; set; }

        public virtual ICollection<Hayvan> Hayvanlar { get; set; }
    }
}

