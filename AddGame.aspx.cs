using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gamora
{
    public partial class AddGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {             
            SqlConnection con = new SqlConnection(Global.dbcon);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO game (name, description, category, imageurl, unitprice) VALUES (@name, @description, @category, @imageUrl, @unitPrice); ", con);
                cmd.Parameters.AddWithValue("@name", nameTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@description", descriptionTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@category", categoryTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@imageUrl", "~/Images/defaultgameicon.png");
                cmd.Parameters.AddWithValue("@unitPrice", int.Parse(priceTextBox.Text.Trim()));
                int inserted = cmd.ExecuteNonQuery();
                Global.RefreshGameList();
                Response.Write("<script>alert('"+inserted+"');</script>");
                if (inserted > 0)
                {
                    Response.Write("<script>alert('" + inserted + " game deleted successfully!');</script>");
                    Response.Redirect("AdminDashboard.aspx");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                con.Close();
            }
        }
    }
}