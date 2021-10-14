using System;
using System.Collections.Generic;
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
                    removeButton.Click += new EventHandler(button_Click);
                   
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

       public void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;           
            Global.myCartList.RemoveAt(int.Parse(button.ID));
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
                Response.Redirect("Cart.aspx");
            }           
        }
        public void plusQuantityChanged(object  sender, EventArgs e)
        {
            Button button = sender as Button;
            string itemString = button.ID.Remove(1);
            int item = int.Parse(itemString);

            if (Global.myCartList[item].Quantity < 3)
            {
                Global.myCartList[item].Quantity += 1;
                Response.Redirect("Cart.aspx");
            }
        }
    }
}