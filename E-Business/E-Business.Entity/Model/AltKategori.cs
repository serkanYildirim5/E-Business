using Core.Entities;
using System.Collections;
using System.Collections.Generic;

namespace E_Business.Entity.Model
{
    public class AltKategori:IEntity
    {
        public AltKategori()
        {
            Urunleri = new HashSet<Urun>();
            UstKategori = new HashSet<Kategori>();
        }
        public int Id { get; set; }
        public string KategoriAd { get; set; }
        public int BagliOlduguKategoriId { get; set; }
        public virtual ICollection<Kategori> UstKategori { get; set; }
        public virtual ICollection<Urun> Urunleri { get; set; }
    }
}