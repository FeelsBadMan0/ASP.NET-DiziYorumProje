using DiziYorumProje.Entity;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace DiziYorumProje
{

    public partial class Hakkimda : System.Web.UI.Page
    {
        BlogDiziEntity db = new BlogDiziEntity();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBLHAKKIMIZDA.ToList();
            Repeater1.DataBind();

        }
    }
}