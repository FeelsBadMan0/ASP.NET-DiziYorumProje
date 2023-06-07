using DiziYorumProje.Entity;
using System;
using System.Web.UI;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class YorumGuncelle : System.Web.UI.Page
    {
        BlogDiziEntity db = new BlogDiziEntity();
        protected void Page_Load(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["YORUMID"]);
            if (Page.IsPostBack == false)
            {
                var deger = db.TBLYORUM.Find(y);
                TextBox1.Text = deger.TBLBLOG.BLOGBASLIK;
                TextBox2.Text = deger.KULLANICIAD;
                TextBox4.Text = deger.YORUMICERIK;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["YORUMID"]);
            var yorum = db.TBLYORUM.Find(y);
            yorum.KULLANICIAD = TextBox2.Text;
            yorum.YORUMICERIK = TextBox4.Text;
            db.SaveChanges();
            Response.Redirect("Yorumlar.aspx");

        }
    }
}