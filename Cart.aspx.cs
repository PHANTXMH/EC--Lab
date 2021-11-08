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
    public partial class Cart : System.Web.UI.Page
    {
        int total_price, i;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminId"] != null)//Cart page will now be log out for admin and this is the logic to log out
            {
                Session["adminId"] = null;
                Response.Redirect("UserLogin.aspx");
            }else
            if (Session["userId"] == null)
            {
                Response.Redirect("UserLogin.aspx");
            }            

            total_price = 0;
            
            if(Global.myCartList.Count < 1)
            {
                TableRow tableRow = new TableRow();
                TableCell tableCell = new TableCell();
               
                tableCell.Controls.Add(new LiteralControl("There are no games in your cart"));
                tableRow.Cells.Add(tableCell);
                Table1.Rows.Add(tableRow);
            }
            else
            {
                i = 0;
                foreach (CartItem ci in Global.myCartList)
                {
                    TableRow row1 = new TableRow();
                    TableCell nameCell = new TableCell();
                    nameCell.HorizontalAlign = HorizontalAlign.Center;
                    TableCell priceCell = new TableCell();
                    priceCell.HorizontalAlign = HorizontalAlign.Center;
                    TableCell quantityCell = new TableCell();
                    quantityCell.HorizontalAlign = HorizontalAlign.Center;
                    TableCell totalCell = new TableCell();
                    totalCell.HorizontalAlign = HorizontalAlign.Center;
                    TableCell removeCell = new TableCell();     
                    removeCell.HorizontalAlign = HorizontalAlign.Center;
                    Button removeButton = new Button();
                    Button minusButton = new Button();
                    Button plusButton = new Button();
                    Label quantityTextBox = new Label();                   

                    
                    removeButton.ID = i.ToString();
                    minusButton.ID = i.ToString() + "mb";
                    plusButton.ID = i.ToString() + "pb";

                   
                    quantityTextBox.Text = "  "+ci.Quantity.ToString()+"  ";
                    quantityTextBox.Enabled = false;
                    
                    removeButton.Text = "Remove";
                    minusButton.Text = "-";
                    plusButton.Text = "+";
                    removeButton.Click += new EventHandler(removeButton_Click);
                   
                    minusButton.Click += new EventHandler(minusQuantityChanged);
                    plusButton.Click += new EventHandler(plusQuantityChanged);

                    nameCell.Controls.Add(new LiteralControl(ci.Name));
                    row1.Cells.Add(nameCell);
                    priceCell.Controls.Add(new LiteralControl("$" + ci.Price.ToString()));
                    row1.Cells.Add(priceCell);
                    quantityCell.Controls.Add(minusButton);
                    quantityCell.Controls.Add(quantityTextBox);
                    quantityCell.Controls.Add(plusButton);
                    row1.Cells.Add(quantityCell);
                    int total = ci.Quantity * ci.Price;
                    totalCell.Controls.Add(new LiteralControl("$" + total.ToString()));
                    row1.Cells.Add(totalCell);
                    removeCell.Controls.Add(removeButton);
                    row1.Cells.Add(removeCell);
                    Table1.Rows.Add(row1);
                    total_price += total;
                    i++;
                }

                TableRow row2 = new TableRow();
                TableHeaderCell cartLabel = new TableHeaderCell();
                TableCell cartTotal = new TableCell();
                cartTotal.HorizontalAlign = HorizontalAlign.Center;
                cartLabel.BackColor = System.Drawing.Color.Goldenrod;
                cartLabel.Controls.Add(new LiteralControl("Cart Total"));
                row2.Cells.Add(cartLabel);
                cartTotal.Controls.Add(new LiteralControl("$"+total_price.ToString()));
                row2.Cells.Add(cartTotal);
                Table2.Rows.Add(row2);
            }
        }

       public void removeButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;           
            Global.myCartList.RemoveAt(int.Parse(button.ID));
            SqlConnection con = new SqlConnection(Global.dbcon);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE FROM cart where cartid = @cartid AND userid = @userid", con);
                cmd.Parameters.AddWithValue("@cartid", int.Parse(button.ID));
                cmd.Parameters.AddWithValue("@userid", int.Parse(Session["userId"].ToString()));
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("Cart.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                con.Close();
            }

            Response.Redirect("Cart.aspx");

        }

        public void minusQuantityChanged(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string itemString = button.ID.Remove(1);
            int item = int.Parse(itemString);

            if(Global.myCartList[item].Quantity > 1)
            {
                Global.myCartList[item].Quantity -= 1;            
            }
            SqlConnection con = new SqlConnection(Global.dbcon);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE cart SET quantity = @quantity WHERE userid = @userid AND cartid = @cartid;", con);
                cmd.Parameters.AddWithValue("@quantity", Global.myCartList[item].Quantity);
                cmd.Parameters.AddWithValue("@userid", int.Parse(Session["userId"].ToString()));
                cmd.Parameters.AddWithValue("@cartid", item);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("Cart.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                con.Close();
            }

            Response.Redirect("Cart.aspx");
        }

        public void plusQuantityChanged(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string itemString = button.ID.Remove(1);
            int item = int.Parse(itemString);

            if (Global.myCartList[item].Quantity < 3)
            {
                Global.myCartList[item].Quantity += 1;
            }
            SqlConnection con = new SqlConnection(Global.dbcon);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }//UPDATE cart SET quantity = 3 WHERE userid = 1 AND cartid = 0;
                SqlCommand cmd = new SqlCommand("UPDATE cart SET quantity = @quantity WHERE userid = @userid AND cartid = @cartid;", con);
                cmd.Parameters.AddWithValue("@quantity", Global.myCartList[item].Quantity);
                cmd.Parameters.AddWithValue("@userid", int.Parse(Session["userId"].ToString()));
                cmd.Parameters.AddWithValue("@cartid", item);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("Cart.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                con.Close();
            }

            Response.Redirect("Cart.aspx");
        }

        protected void ProceedButton_Click(object sender, EventArgs e)//function that runs when the checkout button is pressed
        {
            if (Global.myCartList.Count < 1)//if statement that checks if there are items in the cart
            {
                Response.Write("<script>alert('There are no items in your cart');</script>");
            }
            else
            {                
                SqlConnection con = new SqlConnection(Global.dbcon);//Global.dbcon would be your connection string that is in your web config file
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("INSERT INTO orders (orderdate, productid, userid, quantity, subtotal) VALUES" +
                            "(CURRENT_TIMESTAMP, @productid, @userid, @quantity, @subtotal);", con);//this is where your specific sql command will be stored for execution
                    
                    foreach (CartItem ci in Global.myCartList)//this foreach method goes through each product in the cart and inserts it into the database using the SqlCommand object
                    {              
                        //each of these functions subsitute the key word for example @userid with the actual value to be inputed into the sql command
                        cmd.Parameters.AddWithValue("@productid", ci.Id);
                        cmd.Parameters.AddWithValue("@userid", int.Parse(Session["userId"].ToString()));
                        cmd.Parameters.AddWithValue("@quantity", ci.Quantity);
                        cmd.Parameters.AddWithValue("@subtotal", ci.ItemTotal);
                        cmd.ExecuteNonQuery();//this is the command to execute the sql command
                    }

                    SqlCommand cmd2 = new SqlCommand("DELETE FROM cart WHERE userid = @userid;", con);//this is another sql command to delete the items that were stored in the cart database after checkout
                    cmd2.Parameters.AddWithValue("@userid", int.Parse(Session["userId"].ToString()));
                    cmd2.ExecuteNonQuery();
                    Global.myCartList = new List<CartItem>();
                    Response.Redirect("Checkout.aspx");
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
}