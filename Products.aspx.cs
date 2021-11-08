using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gamora
{ 
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            int i;
            SqlConnection con = new SqlConnection(Global.dbcon);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM game;", con);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    i = 0;
                    Global.gameList = new List<Game>();
                    while (dataReader.Read())
                    {
                        Global.gameList.Add(new Game(int.Parse(dataReader.GetValue(0).ToString()), dataReader.GetValue(1).ToString(),
                            dataReader.GetValue(2).ToString(), dataReader.GetValue(3).ToString(), dataReader.GetValue(4).ToString(),
                            int.Parse(dataReader.GetValue(5).ToString())));
                        Image gameImage = new Image();
                        gameImage.ImageUrl = dataReader.GetValue(4).ToString();
                        PlaceHolder1.Controls.Add(gameImage);                   
                        
                        Label gameNameLabel = new Label();
                        gameNameLabel.Text = "  "+dataReader.GetValue(1).ToString();
                        gameNameLabel.ForeColor = System.Drawing.Color.Goldenrod;
                        PlaceHolder1.Controls.Add(gameNameLabel);
                        PlaceHolder1.Controls.Add(new LiteralControl("</br></br>"));

                        Label gameDescriptionLabel = new Label();
                        gameDescriptionLabel.Text = dataReader.GetValue(2).ToString();
                        PlaceHolder1.Controls.Add(gameDescriptionLabel);
                        PlaceHolder1.Controls.Add(new LiteralControl("</br>"));

                        Label gamePriceLabel = new Label();
                        gamePriceLabel.Text = "JMD$" + dataReader.GetValue(5).ToString();
                        PlaceHolder1.Controls.Add(gamePriceLabel);
                        PlaceHolder1.Controls.Add(new LiteralControl("</br>"));

                        Button addCartButton = new Button();
                        addCartButton.ID = i.ToString();
                        addCartButton.Text = "Add to Cart";
                        addCartButton.BackColor = System.Drawing.Color.Goldenrod;
                        addCartButton.Click += new EventHandler(addCartButton_Click);
                        PlaceHolder1.Controls.Add(addCartButton);
                        PlaceHolder1.Controls.Add(new LiteralControl("</br></br></br>"));
                        i++;
                    }
                }
                else
                {
                    Response.Write("<script>alert('The stock looks empty');</script>");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                con.Close();
            }            
        }

        public void addCartButton_Click(object sender, EventArgs e)
        {            
            Button button = sender as Button;
            int array = int.Parse(button.ID);           
            if (Session["userId"] != null)
            {
                int cartid = Global.myCartList.Count;
                if (Global.myCartList.Find(x => x.Id == Global.gameList[array].Id) == null)
                {                    
                    SqlConnection con = new SqlConnection(Global.dbcon);
                    try
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }                        
                        SqlCommand cmd = new SqlCommand("INSERT INTO cart (name, price, quantity, userid, cartid, productid) VALUES" +
                            " (@name, @price, @quantity,@userid,@cartid,@productid);", con);
                        cmd.Parameters.AddWithValue("@name", Global.gameList[array].Name);
                        cmd.Parameters.AddWithValue("@price", Global.gameList[array].Price);
                        cmd.Parameters.AddWithValue("@quantity", 1);
                        cmd.Parameters.AddWithValue("@userid", (int)Session["userId"]);
                        cmd.Parameters.AddWithValue("@cartid", cartid);
                        cmd.Parameters.AddWithValue("@productid", Global.gameList[array].Id);
                        cmd.ExecuteNonQuery();                        
                        Global.myCartList.Add(new CartItem(Global.gameList[array].Id, Global.gameList[array].Name, Global.gameList[array].Price, 1));
                        Response.Write("<script>alert('Item added to cart');</script>");
                        Response.Redirect("Cart.aspx");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('"+ex.Message+"');</script>");
                        con.Close();
                    }                    
                }
            }
            else
            {
                Response.Write("<script>alert('User has to be logged in to continue shopping');</script>");
                Response.Redirect("UserLogin.aspx");                                
            }
            
        }       
    }
}