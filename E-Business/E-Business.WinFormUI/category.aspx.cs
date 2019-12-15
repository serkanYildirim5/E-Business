using E_Business.BLL.Controller;
using E_Business.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Business.WinFormUI
{
    public partial class category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string urunKategori = Request.QueryString["kategori"];
            UrunleriListele(urunKategori);

            KategorileriGetir();
        }
        KategoriController controller = new KategoriController();
        AltKategoriController altKategoriController = new AltKategoriController();
        UrunController urunController = new UrunController();
        Kategori kategori = new Kategori();


        private void UrunleriListele(string urunKategori)
        {
            List<Urun> urunler = new List<Urun>();
            if (urunKategori==null)
            {
                urunler = urunController.Getir().Take(6).ToList();
            }
            else
            {
                int urunKategoriId = Convert.ToInt32(urunKategori);
                urunler = urunController.Getir(x => x.BagliOlduguKategoriId == urunKategoriId).Take(6).ToList();
            }          
            DataList2.DataSource = urunler.ToList();
            DataList2.DataBind();
        }

        
        private void KategorileriGetir()
        {
            List<Kategori> data = controller.Getir();
            DataList1.DataSource = data.ToList();  
            DataList1.DataBind();
        }

        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            int id = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Id"));
            List<AltKategori> altKategoriler = altKategoriController.Getir(x => x.BagliOlduguKategoriId ==id);
            DataList dbAltKategori = (DataList)e.Item.FindControl("altKategori");
            dbAltKategori.DataSource = altKategoriler.ToList();
            dbAltKategori.DataBind();
        }      
    }
}