using E_Business.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Business.Entity.Mapping
{
    public class KategoriMapping:EntityTypeConfiguration<Kategori>
    {
        public KategoriMapping()
        {
            ToTable("Kategoriler");
            Property(k => k.KategoriAdi).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            //Bir kategorinin birden fazla alt kategorisi olacağından ara tablo yaptım.
            HasMany(u => u.AltKategorileri).WithMany(a => a.UstKategori).Map(m=> {
                m.ToTable("Kategori_AltKategori_Islem");
                m.MapLeftKey("KategoriId");
                m.MapRightKey("AltKategoriId");
            });
        }
    }
}
