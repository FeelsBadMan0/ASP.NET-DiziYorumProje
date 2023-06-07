using DiziYorumProje.Entity;
using System;
using System.Linq;

namespace DiziYorumProje
{
    public partial class Login : System.Web.UI.Page
    {
        BlogDiziEntity db = new BlogDiziEntity();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN
                        where x.KULLANICI == TextBox1.Text
                        && x.SIFRE == TextBox2.Text
                        select x;
            if (sorgu.Any())
            {
                Session.Add("KULLANICI", TextBox1.Text);
                Response.Redirect("/AdminSayfalar/Bloglar.aspx");
            }
            else
            {
                Response.Write("Hata");
            }

        }
    }
}