using E_Business.Entity.Mapping;
using E_Business.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Business.DAL
{
    public class E_BusinessContext:DbContext
    {
        public E_BusinessContext():base(ConnectionStringContainer.ConnectionString)
        {

        }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<AltKategori> AltKategoriler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KategoriMapping());
            modelBuilder.Configurations.Add(new AltKategoriMapping());
            modelBuilder.Configurations.Add(new UrunMapping());
            modelBuilder.Configurations.Add(new YorumMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
