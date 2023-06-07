using DiziYorumProje.Entity;
using System;
using System.Linq;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class Bloglar : System.Web.UI.Page
    {
        BlogDiziEntity db = new BlogDiziEntity();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Session["KULLANICI"].ToString());
            if (Session["KULLANICI"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                Response.Write("Hoşgeldiniz :" + Session["KULLANICI"].ToString());
            }
            var bloglar = (from x in db.TBLBLOG
                           select new
                           {
                               x.BLOGID,
                               x.BLOGBASLIK,
                               x.BLOGTARIH,
                               x.TBLTUR.TURAD,
                               x.TBLKATEGORI.KATEGORIAD
                           }).ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();
        }
    }
}