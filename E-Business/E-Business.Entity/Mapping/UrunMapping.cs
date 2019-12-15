using E_Business.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Business.Entity.Mapping
{
    public class UrunMapping : EntityTypeConfiguration<Urun>
    {
        public UrunMapping()
        {
            ToTable("Urunler");
            Property(u => u.UrunAdi).HasColumnType("varchar").HasMaxLength(40);
            Property(u => u.UrunFiyati).HasColumnType("float");
            Property(u => u.UrunAciklama).HasColumnType("varchar").HasMaxLength(200);
            Property(u => u.UrunAdeti).HasColumnType("int");
            Property(u => u.UrunFotografı).HasColumnType("varchar").HasMaxLength(350);
            //Urun ile kategoriyi bağladık
            HasRequired(u => u.UrunKategori).WithMany(k => k.Urunleri).HasForeignKey(u=>u.BagliOlduguKategoriId);



        }
    }
}
