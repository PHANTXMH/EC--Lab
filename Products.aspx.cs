using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gamora
{
    public partial class Products : System.Web.UI.Page
    {
        Game fifa22 = new Game(1, "FIFA22", "FIFA 22 is an association football simulation video game published by Electronic Arts as part of the FIFA series.",
            "FOOTBALL", "~/Images/fifa22.jfif", 2400);
        Game fifa21 = new Game(2, "FIFA21", "FIFA 21 is an association football simulation video game published by Electronic Arts as part of the FIFA series.",
            "FOOTBALL", "~/Images/fifa21.jfif",2000);
        Game fifa20 = new Game(3, "FIFA20", "FIFA 20 is an association football simulation video game published by Electronic Arts as part of the FIFA series.",
            "FOOTBALL", "~/Images/fifa20.jfif",1800);
        Game nba2k22 = new Game(4, "NBA 2K22", "The 22nd iteration of the basketball game produced by EASPORTS", "BASKETBALL", "~/Images/nba2k22.jfif",2400);
        Game nba2k21 = new Game(5, "NBA 2K21", "The 21st iteration of the basketball game produced by EASPORTS", "BASKETBALL", "~/Images/nba2k21.jfif",2000);
        Game nba2k20 = new Game(6, "NBA 2K20", "The 20th iteration of the basketball game produced by EASPORTS", "BASKETBALL", "~/Images/nba2k20.jfif",1800);
        Game codcoldwar = new Game(7, "Call of Duty: Black Ops Cold War",
            "Call of Duty: Black Ops Cold War is a 2020 first-person shooter video game developed by Treyarch and Raven Software and published by Activision.",
            "SHOOTER", "~/Images/codcoldwar.jfif",2400);
        Game codmodernwarfare = new Game(8, "Call of Duty: Modern Warfare",
            "Call of Duty: Modern Warfare is a 2019 first-person shooter video game developed by Infinity Ward and published by Activision.",
            "SHOOTER", "~/Images/codmodernwarfare.jfif",2000);
        Game codblackops = new Game(9, "Call of Duty: Black Ops",
            "Call of Duty: Black Ops is a 2010 first-person shooter video game developed by Treyarch and published by Activision.",
            "SHOOTER", "~/Images/codblackops.jfif",1800);
        protected void Page_Load(object sender, EventArgs e)
        {
            fifa22Image.ImageUrl = fifa22.ImageUrl;
            fifa22Name.Text = fifa22.Name;
            fifa22Price.Text = "JMD$"+fifa22.Price.ToString();
            fifa22Description.Text = fifa22.Description;

            fifa21Image.ImageUrl = fifa21.ImageUrl;
            fifa21Name.Text = fifa21.Name;
            fifa21Price.Text = "JMD$" + fifa21.Price.ToString();
            fifa21Description.Text = fifa21.Description;

            fifa20Image.ImageUrl = fifa20.ImageUrl;
            fifa20Name.Text = fifa20.Name;
            fifa20Price.Text = "JMD$" + fifa20.Price.ToString();
            fifa20Description.Text = fifa20.Description;

            nba2k22Image.ImageUrl = nba2k22.ImageUrl;
            nba2k22Name.Text = nba2k22.Name;
            nba2k22Price.Text = "JMD$" + nba2k22.Price.ToString();
            nba2k22Description.Text = nba2k22.Description;

            nba2k21Image.ImageUrl = nba2k21.ImageUrl;
            nba2k21Name.Text = nba2k21.Name;
            nba2k21Price.Text = "JMD$" + nba2k21.Price.ToString();
            nba2k21Description.Text = nba2k21.Description;

            nba2k20Image.ImageUrl = nba2k20.ImageUrl;
            nba2k20Name.Text = nba2k20.Name;
            nba2k20Price.Text = "JMD$" + nba2k20.Price.ToString();
            nba2k20Description.Text = nba2k20.Description;

            codcoldwarImage.ImageUrl = codcoldwar.ImageUrl;
            codcoldwarName.Text = codcoldwar.Name;
            codcoldwarPrice.Text = "JMD$" + codcoldwar.Price.ToString();
            codcoldwarDescription.Text = codcoldwar.Description;

            codmodernwarfareImage.ImageUrl = codmodernwarfare.ImageUrl;
            codmodernwarfareName.Text = codmodernwarfare.Name;
            codmodernwarfarePrice.Text = "JMD$" + codmodernwarfare.Price.ToString();
            codmodernwarfareDescription.Text = codmodernwarfare.Description;

            codblackopsImage.ImageUrl = codblackops.ImageUrl;
            codblackopsName.Text = codblackops.Name;
            codblackopsPrice.Text = "JMD$" + codblackops.Price.ToString();
            codblackopsDescription.Text = codblackops.Description;
        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("About.aspx");
        }
    }
}