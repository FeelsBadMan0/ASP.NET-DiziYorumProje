using DiziYorumProje.Entity;
using System;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class BlogSil : System.Web.UI.Page
    {
        BlogDiziEntity db = new BlogDiziEntity();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["BLOGID"]);
            var blog = db.TBLBLOG.Find(id);
            db.TBLBLOG.Remove(blog);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");

        }
    }
}