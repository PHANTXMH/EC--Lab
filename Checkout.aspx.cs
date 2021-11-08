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
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(Session["userId"] == null)
            {
                Response.Redirect("Products.aspx");
            }
            SqlConnection con = new SqlConnection(Global.dbcon);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM orders WHERE userid = @userid;", con);
                cmd.Parameters.AddWithValue("@userid", int.Parse(Session["userId"].ToString()));
                SqlDataReader dataReader = cmd.ExecuteReader();                

                while(dataReader.Read())
                {
                    TableRow row = new TableRow();
                    TableCell dateCell = new TableCell();
                    dateCell.HorizontalAlign = HorizontalAlign.Center;
                    TableCell productCell = new TableCell();
                    productCell.HorizontalAlign = HorizontalAlign.Center;
                    TableCell userCell = new TableCell();
                    userCell.HorizontalAlign = HorizontalAlign.Center;
                    TableCell quantityCell = new TableCell();
                    quantityCell.HorizontalAlign = HorizontalAlign.Center;
                    TableCell totalCell = new TableCell();
                    totalCell.HorizontalAlign = HorizontalAlign.Center;

                    dateCell.Controls.Add(new LiteralControl(dataReader.GetValue(1).ToString()));
                    row.Cells.Add(dateCell);
                    productCell.Controls.Add(new LiteralControl(dataReader.GetValue(2).ToString()));
                    row.Cells.Add(productCell);
                    userCell.Controls.Add(new LiteralControl(dataReader.GetValue(3).ToString()));
                    row.Cells.Add(userCell);
                    quantityCell.Controls.Add(new LiteralControl(dataReader.GetValue(4).ToString()));
                    row.Cells.Add(quantityCell);
                    totalCell.Controls.Add(new LiteralControl("$"+dataReader.GetValue(5).ToString()));
                    row.Cells.Add(totalCell);

                    OrderTable.Rows.Add(row);
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