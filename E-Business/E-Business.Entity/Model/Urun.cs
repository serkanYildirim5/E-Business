using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Business.Entity.Model
{
    public class Urun : IEntity
    {
        public Urun()
        {
            Yorumları = new HashSet<Yorum>();
        }

        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }
        public string UrunFotografı { get; set; }
        public int UrunAdeti { get; set; }
        public string UrunAciklama { get; set; }
        public int BagliOlduguKategoriId { get; set; }
        public virtual AltKategori UrunKategori { get; set; }
        public virtual ICollection<Yorum> Yorumları { get; set; }
    }
}
