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
    public partial class UpdateGame : System.Web.UI.Page
    {
        Game game;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["outdatedGame"] == null)
            {
                Response.Write("<script>alert('Game must be identified first');</script>");
                Response.Redirect("AdminDasboard.aspx");
            }
            else
            {
                game = (Game)Session["outdatedGame"];

                if (!IsPostBack)
                {
                    updnameTextBox.Text = game.Name;
                    upddescriptionTextBox.Text = game.Description;
                    updcategoryTextBox.Text = game.Category;
                    updimageTextBox.Text = game.ImageUrl;
                    updpriceTextBox.Text = game.Price.ToString();
                }
                
            }           
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Global.dbcon);            
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                //SqlCommand cmd = new SqlCommand("UPDATE game SET name = 'Roblox' WHERE id = 3003;", con);
                //SqlCommand command = new SqlCommand("Update game set name =" + nameTextBox.Text + "where id = 3003;",con);

                SqlCommand cmd = new SqlCommand("UPDATE game SET name = @name, description = @description, category = @category, imageurl = @image, unitprice = @price WHERE id = @id; ", con);
                /*cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@image", image);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@id", game.Id);*/
                
                cmd.Parameters.AddWithValue("@name", updnameTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@description", upddescriptionTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@category", updcategoryTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@image", updimageTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@price", int.Parse(updpriceTextBox.Text.Trim()));
                cmd.Parameters.AddWithValue("@id", game.Id);
                Response.Write("<script>alert('"+ cmd.ExecuteNonQuery() + " rows updated');</script>");
                Global.RefreshGameList();
                con.Close();
                Response.Redirect("AdminDashboard.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                con.Close();
            }         
        }
    }
}