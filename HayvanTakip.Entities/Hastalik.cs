using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HayvanTakip.Entities
{
    [Table("Hastaliklar")]
    public class Hastalik
    {
        public Hastalik()
        {
            Tedaviler = new HashSet<Tedavi>();
        }

        public int Id { get; set; }

        public int HayvanId { get; set; }

        public string HastalikAdi { get; set; }

        public DateTime TeshisTarihi { get; set; }

        public string Belirtiler { get; set; }

        public string Aciklama { get; set; }

        public bool DevamEdiyorMu { get; set; }

        public DateTime KayitTarihi { get; set; }

        public virtual Hayvan Hayvan { get; set; }

        public virtual ICollection<Tedavi> Tedaviler { get; set; }
    }
}