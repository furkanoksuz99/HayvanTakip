using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HayvanTakip.Entities
{
    public enum HareketTipi
    {
        Giris = 1,
        Cikis = 2,
        Sevk = 3,
        Transfer = 4
    }

    [Table("Hareketler")]
    public class Hareket
    {
        public int Id { get; set; }

        public int HayvanId { get; set; }

        public HareketTipi HareketTipi { get; set; }

        public int? KaynakIsletmeId { get; set; }

        public int? HedefIsletmeId { get; set; }

        public DateTime HareketTarihi { get; set; }

        public string Aciklama { get; set; }

        public DateTime KayitTarihi { get; set; }

        public virtual Hayvan Hayvan { get; set; }

        [ForeignKey("KaynakIsletmeId")]
        public virtual Isletme KaynakIsletme { get; set; }

        [ForeignKey("HedefIsletmeId")]
        public virtual Isletme HedefIsletme { get; set; }
    }
}