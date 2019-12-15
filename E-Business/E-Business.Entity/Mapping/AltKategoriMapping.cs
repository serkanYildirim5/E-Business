using E_Business.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Business.Entity.Mapping
{
    public class AltKategoriMapping : EntityTypeConfiguration<AltKategori>
    {
        public AltKategoriMapping()
        {
            ToTable("AltKategoriler");
            Property(k => k.KategoriAd).HasColumnType("varchar").HasMaxLength(30).IsRequired();          
        }
    }
}
