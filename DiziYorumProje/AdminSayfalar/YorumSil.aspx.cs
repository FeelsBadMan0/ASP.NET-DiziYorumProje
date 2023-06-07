using DiziYorumProje.Entity;
using System;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class YorumSil : System.Web.UI.Page
    {
        BlogDiziEntity db = new BlogDiziEntity();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["YORUMID"]);
            var yorum = db.TBLYORUM.Find(id);
            db.TBLYORUM.Remove(yorum);
            db.SaveChanges();
            Response.Redirect("Yorumlar.aspx");
        }
    }
}