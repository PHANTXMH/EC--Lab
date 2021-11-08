using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gamora
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userId"] == null)
            {
                LoginLabel.Text = "Log In";
            }
            else
            {
                LoginLabel.Text = "Log Out";
            }            
            
            if(Global.myCartList.Count == 0)
            {
                CartLabel.Text = "Cart";
            }
            else
            {
                CartLabel.Text = "Cart ( " + Global.myCartList.Count.ToString() + " )";

            }

            if (Session["adminId"] != null)
            {
                LoginLabel.Text = "Dashboard";
                CartLabel.Text = "Log Out";
            }
        }
    }
}