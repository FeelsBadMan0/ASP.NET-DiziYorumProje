using DiziYorumProje.Entity;
using System;

namespace DiziYorumProje
{
    public partial class Iletisim : System.Web.UI.Page
    {
        BlogDiziEntity db = new BlogDiziEntity();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLILETISIM t = new TBLILETISIM();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.TELEFON = TextBox3.Text;
            t.KONU = TextBox4.Text;
            t.MESAJ = TextBox5.Text;
            db.TBLILETISIM.Add(t);
            db.SaveChanges();

        }
    }
}