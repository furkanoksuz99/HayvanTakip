using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HayvanTakip.Entities
{
    [Table("Asilar")]
    public class Asi
    {
        public int Id { get; set; }

        public int HayvanId { get; set; }

        public string AsiAdi { get; set; }

        public DateTime AsiTarihi { get; set; }

        public DateTime? SonrakiAsiTarihi { get; set; }

        public string Aciklama { get; set; }

        public DateTime KayitTarihi { get; set; }

        public virtual Hayvan Hayvan { get; set; }
    }
}