using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gamora
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.ImageUrl = "Images/codcoldwarposter.jfif";
            Image2.ImageUrl = "Images/fifa22poster.jfif";
            Image3.ImageUrl = "Images/nba2k22poster.jfif";
            Image4.ImageUrl = "Images/ps4banner.jfif";
            Session["cart"] = new ArrayList();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["searchreqeust"] = TextBox1.Text;
            Response.Redirect("Products.aspx");
        }
    }
}