using DiziYorumProje.Entity;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class Yorumlar : System.Web.UI.Page
    {
        BlogDiziEntity db = new BlogDiziEntity();
        protected void Page_Load(object sender, EventArgs e)
        {
            var yorumlar = (from x in db.TBLYORUM
                            select new
                            {
                                x.YORUMID,
                                x.KULLANICIAD,
                                x.TBLBLOG.BLOGBASLIK
                            }).ToList();
            Repeater1.DataSource = yorumlar;
            Repeater1.DataBind();
        }
    }
}