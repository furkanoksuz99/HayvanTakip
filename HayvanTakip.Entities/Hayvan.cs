using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace HayvanTakip.Entities
{
    public enum HayvanDurumu
    {
        Aktif = 1,
        SevkEdildi = 2,
        Kayip = 3,
        Olum = 4,
        Kesim = 5,
        Pasif = 6
    }

    public enum HayvanCinsiyeti
    {
        Erkek = 1,
        Disi = 2
    }

    [Table("Hayvanlar")]
    public class Hayvan
    {
        public int Id { get; set; }

        public string KupeNo { get; set; }

        public int IsletmeId { get; set; }

        public string Tur { get; set; }

        public string Irk { get; set; }

        public HayvanCinsiyeti Cinsiyet { get; set; }

        public DateTime DogumTarihi { get; set; }

        public HayvanDurumu Durum { get; set; }

        public DateTime KayitTarihi { get; set; }

        public virtual Isletme Isletme { get; set; }

        public virtual ICollection<Asi> Asilar { get; set; }

        public virtual ICollection<Hareket> Hareketler { get; set; }
    }
}