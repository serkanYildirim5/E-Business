using E_Business.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Business.Entity.Mapping
{
    public class YorumMapping : EntityTypeConfiguration<Yorum>
    {
        public YorumMapping()
        {
            ToTable("Yorumlar");
            Property(u => u.FullName).HasColumnType("varchar").HasMaxLength(40);
            Property(u => u.Email).HasColumnType("varchar").HasMaxLength(100);
            Property(u => u.Number).HasColumnType("varchar").HasMaxLength(11);
            Property(u => u.Comment).HasColumnType("varchar").HasMaxLength(300);
            HasRequired(u => u.YorumUrun).WithMany(k => k.Yorumları).HasForeignKey(u => u.BagliOlduguUrunId);
        }
    }
}
