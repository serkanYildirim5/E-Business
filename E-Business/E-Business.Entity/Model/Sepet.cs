using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Business.Entity.Model
{
   public  class Sepet
    {
        public List< Urun> urunler = null;
        public Sepet() {
            urunler = new List< Urun>();
        }
        public void Ekle(Urun u)
        {
            if (urunler.Contains(u))
            {//zaten sepette varsa adetini bir adet arttırıyorum
                urunler[u.Id].UrunAdeti += 1;
            }
            else
            {//sepette yoksa benzersiz idsi ile listemize ekliyoruz.
                urunler.Add(u);
            }
        }

    }
}
