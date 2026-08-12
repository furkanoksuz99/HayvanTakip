using HayvanTakip.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanTakip.DataAccess.Context
{
    public class HayvanTakipContext : DbContext
    {
        public HayvanTakipContext()
            : base("HayvanTakipConnection")
        {
        }

        public DbSet<Isletme> Isletmeler { get; set; }

        public DbSet<Hayvan> Hayvanlar { get; set; }

        public DbSet<Asi> Asilar { get; set; }

        public DbSet<Hastalik> Hastaliklar { get; set; }

        public DbSet<Tedavi> Tedaviler { get; set; }

        public DbSet<Hareket> Hareketler
        {
            get; set;
        }
    }
}
