using DiziYorumProje.Entity;
using System;
using System.Linq;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class Istatistikler : System.Web.UI.Page
    {
        BlogDiziEntity db = new BlogDiziEntity();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBLBLOG.Count().ToString();
            Label2.Text = db.TBLYORUM.Count().ToString();
            Label3.Text = db.TBLBLOG.Where(x => x.BLOGTUR == 2).Count().ToString();
            Label4.Text = db.TBLBLOG.Where(x => x.TBLTUR.TURAD == "Dizi").Count().ToString();
            Label5.Text = db.TBLBLOG.Where(x => x.TBLTUR.TURAD == "Animasyon").Count().ToString();
            Label6.Text = db.TBLBLOG.Where(z => z.BLOGID == (db.TBLYORUM.GroupBy(x => x.YORUMBLOG).OrderByDescending(x => x.Count()).Select(y => y.Key).FirstOrDefault())).Select(k => k.BLOGBASLIK).FirstOrDefault();
        }
    }
}