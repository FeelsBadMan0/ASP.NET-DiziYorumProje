using DiziYorumProje.Entity;
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class BlogGuncelle : System.Web.UI.Page
    {

        BlogDiziEntity db = new BlogDiziEntity();
        protected void Page_Load(object sender, EventArgs e)
        {
            int z = int.Parse(Request.QueryString["BLOGID"]);
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
                var deger = db.TBLBLOG.Find(z);
                TextBox1.Text = deger.BLOGBASLIK;
                TextBox2.Text = deger.BLOGTARIH.ToString();
                TextBox3.Text = deger.BLOGGORSEL;
                DropDownList1.SelectedValue = deger.BLOGTUR.ToString();
                DropDownList2.SelectedValue = deger.BLOGKATEGORI.ToString();
                TextBox4.Text = deger.BLOGICERIK;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BLOGID"]);
            var blog = db.TBLBLOG.Find(y);
            blog.BLOGBASLIK = TextBox1.Text;
            blog.BLOGTARIH = DateTime.Parse(TextBox2.Text);
            blog.BLOGGORSEL = TextBox3.Text;
            blog.BLOGTUR = byte.Parse(DropDownList1.SelectedValue);
            blog.BLOGKATEGORI = byte.Parse(DropDownList2.SelectedValue);
            blog.BLOGICERIK = TextBox4.Text;
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");

        }
    }
}