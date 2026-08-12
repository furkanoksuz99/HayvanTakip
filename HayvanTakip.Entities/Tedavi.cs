using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HayvanTakip.Entities
{
    [Table("Tedaviler")]
    public class Tedavi
    {
        public int Id { get; set; }

        public int HastalikId { get; set; }

        public string TedaviAdi { get; set; }

        public string IlacAdi { get; set; }

        public DateTime BaslangicTarihi { get; set; }

        public DateTime? BitisTarihi { get; set; }

        public string DozBilgisi { get; set; }

        public string Aciklama { get; set; }

        public DateTime KayitTarihi { get; set; }

        public virtual Hastalik Hastalik { get; set; }
    }
}