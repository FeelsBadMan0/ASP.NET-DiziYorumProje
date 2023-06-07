using DiziYorumProje.Entity;
using System;
using System.Linq;

namespace DiziYorumProje
{
    public partial class KategoriDetay : System.Web.UI.Page
    {
        BlogDiziEntity db = new BlogDiziEntity();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["KATEGORIID"]);
            var bloglar = db.TBLBLOG.Where(X => X.BLOGKATEGORI == id).ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();

            var kategoriler = db.TBLKATEGORI.ToList();
            Repeater2.DataSource = kategoriler;
            Repeater2.DataBind();

            var bloglar3 = db.TBLBLOG.ToList();
            Repeater3.DataSource = bloglar3;
            Repeater3.DataBind();
        }
    }
}