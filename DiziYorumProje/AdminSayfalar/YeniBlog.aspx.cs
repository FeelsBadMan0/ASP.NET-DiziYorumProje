using DiziYorumProje.Entity;
using System;
using System.Linq;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class YeniBlog : System.Web.UI.Page
    {
        BlogDiziEntity db = new BlogDiziEntity();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {


                var turler = (from x in db.TBLTUR
                              select new
                              {
                                  x.TURAD,
                                  x.TURID
                              }).ToList();

                DropDownList1.DataSource = turler;
                DropDownList1.DataBind();

                var kategoriler = (from y in db.TBLKATEGORI
                                   select new
                                   {
                                       y.KATEGORIAD,
                                       y.KATEGORIID
                                   }).ToList();

                DropDownList2.DataSource = kategoriler;
                DropDownList2.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLBLOG t = new TBLBLOG();
            t.BLOGBASLIK = TextBox1.Text;
            t.BLOGTARIH = DateTime.Parse(TextBox2.Text);
            t.BLOGGORSEL = TextBox3.Text;
            t.BLOGTUR = byte.Parse(DropDownList1.Text);
            t.BLOGKATEGORI = byte.Parse(DropDownList2.Text);
            t.BLOGICERIK = TextBox4.Text;
            db.TBLBLOG.Add(t);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");

        }
    }
}