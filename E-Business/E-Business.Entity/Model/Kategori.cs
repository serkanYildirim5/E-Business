using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Business.Entity.Model
{
    public class Kategori:IEntity
    {
        public Kategori()
        {
            AltKategorileri = new HashSet<AltKategori>();
        }
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public virtual ICollection<AltKategori> AltKategorileri { get; set; }
    }
}
