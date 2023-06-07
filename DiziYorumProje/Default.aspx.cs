using DiziYorumProje.Entity;
using System;
using System.Linq;

namespace DiziYorumProje
{
    public partial class Default : System.Web.UI.Page
    {
        BlogDiziEntity db = new BlogDiziEntity();
        protected void Page_Load(object sender, EventArgs e)
        {
            var bloglar = db.TBLBLOG.ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();

            var kategoriler = db.TBLKATEGORI.ToList();
            Repeater2.DataSource = kategoriler;
            Repeater2.DataBind();

            var bloglar2 = db.TBLBLOG.Take(5).OrderByDescending(x => x.BLOGID).ToList();
            Repeater3.DataSource = bloglar2;
            Repeater3.DataBind();

            var bloglar3 = db.TBLYORUM.Take(3).OrderByDescending(x => x.YORUMID).ToList();
            Repeater4.DataSource = bloglar3;
            Repeater4.DataBind();

        }
    }
}