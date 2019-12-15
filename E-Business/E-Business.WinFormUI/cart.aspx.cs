using E_Business.BLL.Controller;
using E_Business.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Business.WinFormUI
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int urunId = Convert.ToInt32(Request.QueryString["urun"]);
            UrunController controller = new UrunController();
            Urun urun = controller.Getir(x => x.Id == urunId).FirstOrDefault();

            if (Session["sepet"] != null)
            {
                SepettekileriGoster();
            }
            if (urun != null)
            {
                SepetteVarmi(urun);
            }

        }
        private void SepettekileriGoster()
        {
            Sepet sepetim = (Sepet)Session["sepet"];
            double total = 0;
            foreach (var item in sepetim.urunler)
            {
                total += item.UrunFiyati;

            }
            List<para> para = new List<para>() {
                new para(){TotalPara=total}
            };
            DataList2.DataSource = para;
            DataList2.DataBind();
            DataList1.DataSource = sepetim.urunler;
            DataList1.DataBind();
        }
        private void SepetteVarmi(Urun urun)
        {
            Sepet sepetim = new Sepet();
            if (Session["sepet"] != null)
            {
                sepetim = (Sepet)Session["sepet"];

            }
            sepetim.Ekle(urun);
            Session["sepet"] = sepetim;
            Response.Redirect("cart.aspx");
        }
        protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.Item.ItemIndex);
            Sepet sepetim = (Sepet)Session["sepet"];
            sepetim.urunler.RemoveAt(id);
            Session["sepet"] = sepetim;
            Response.Redirect("cart.aspx");

        }
    }
}