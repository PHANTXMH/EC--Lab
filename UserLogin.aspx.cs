using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gamora
{    
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userId"] != null)
            {
                Response.Write("<script>alert('You are now logged out!');</script>");
                Session["userId"] = null;
                Global.myCartList = new List<CartItem>();
                Response.Redirect("UserLogin.aspx");
            }

            if(Session["adminId"] != null)
            {
                Response.Redirect("AdminDashboard.aspx");
            }

            Image1.ImageUrl = "Images/unknownpic.png";

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string usernameLogin = UsernameTextBox.Text;
            string passwordLogin = PasswordTextBox.Text;
            SqlConnection con = new SqlConnection(Global.dbcon);
            try
            {               
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM customers WHERE username = @username AND password = @password;", con);
                cmd.Parameters.AddWithValue("@username", usernameLogin);
                cmd.Parameters.AddWithValue("@password", passwordLogin);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {                   
                    int customerId = int.Parse(dataReader.GetValue(0).ToString());
                    Session["userId"] = customerId;                    
                    string username = dataReader.GetValue(2).ToString();
                    dataReader.Close();
                    Response.Write("<script>alert('Welcome Back, " + username + "!');</script>");

                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM cart WHERE userid = @customerId;",con);
                    cmd2.Parameters.AddWithValue("@customerId", customerId);
                    dataReader = cmd2.ExecuteReader();
                    Global.myCartList = new List<CartItem>();              

                    while (dataReader.Read())
                    {
                        Global.myCartList.Add(new CartItem(int.Parse(dataReader.GetValue(0).ToString()), dataReader.GetValue(1).ToString(),
                            int.Parse(dataReader.GetValue(2).ToString()), int.Parse(dataReader.GetValue(3).ToString())));
                    }
                    Response.Redirect("Products.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid Credentials');</script>");
                }
                con.Close();
            }
            catch( Exception ex)
            {                
                Response.Write("<script>alert('"+ex.Message+"');</script>");
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }
    }
}