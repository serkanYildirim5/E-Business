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
    public partial class single_product : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            UrunController Uruncontroller = new UrunController();

            int urun = Convert.ToInt32(Request.QueryString["urun"]);
            DataList1.DataSource = Uruncontroller.Getir(x => x.Id == urun).ToList();
            DataList2.DataSource = yorumController.Getir(x => x.BagliOlduguUrunId == urun).ToList();
            DataList2.DataBind();
            DataList1.DataBind();
            
        }

        private void YorumEklemeTemizle()
        {
            name.Text = "";
            email.Text = "";
            number.Text = "";
            message.Value = "";
        }

        YorumController yorumController = new YorumController();
        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }

        protected void YorumEkle_Click(object sender, EventArgs e)
        {
            int urun = Convert.ToInt32(Request.QueryString["urun"]);
            Yorum yeniYorum = new Yorum();
            yeniYorum.FullName = name.Text;
            yeniYorum.Email = email.Text;
            yeniYorum.Number = number.Text;
            yeniYorum.Comment = message.Value;
            yeniYorum.BagliOlduguUrunId = urun;
            yorumController.Ekle(yeniYorum);
            YorumEklemeTemizle();
            DataList2.DataBind();
        }
    }
}