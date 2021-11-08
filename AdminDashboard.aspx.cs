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
    public partial class AdminDashboard : System.Web.UI.Page
    {
        int i, numberformat;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminId"] == null)
            {
                Response.Write("<script>alert('Please log in as Gamora Admin');</script>");
                Response.Redirect("AdminLogin.aspx");
            }
            else
            {
                i = 0;
                SqlConnection con = new SqlConnection(Global.dbcon);
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("SELECT * FROM game;", con);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                   
                    while (dataReader.Read())
                    {
                        TableRow row = new TableRow();
                        TableCell gameCell = new TableCell();
                        gameCell.HorizontalAlign = HorizontalAlign.Center;
                        TableCell descriptionCell = new TableCell();
                        descriptionCell.HorizontalAlign = HorizontalAlign.Center;
                        TableCell categoryCell = new TableCell();
                        categoryCell.HorizontalAlign = HorizontalAlign.Center;
                        TableCell imageCell = new TableCell();
                        imageCell.HorizontalAlign = HorizontalAlign.Center;
                        TableCell priceCell = new TableCell();
                        Image gameImage = new Image();
                        priceCell.HorizontalAlign = HorizontalAlign.Center;
                        TableCell buttonCell = new TableCell();
                        buttonCell.HorizontalAlign = HorizontalAlign.Center;
                        Button updateButton = new Button();
                        Button deleteButton = new Button();

                        updateButton.ID = i.ToString() + "ub";
                        deleteButton.ID = i.ToString() + "db";

                        if (i < 10)
                        {
                            numberformat = 1;
                        }
                        else
                        {
                            numberformat = 2;
                        }
                        
                        updateButton.Text = "Update";
                        deleteButton.Text = "Delete";

                        updateButton.Click += new EventHandler(updateButton_Click);
                        deleteButton.Click += new EventHandler(deleteButton_Click);

                        gameCell.Controls.Add(new LiteralControl(dataReader.GetValue(1).ToString()));
                        row.Cells.Add(gameCell);
                        descriptionCell.Controls.Add(new LiteralControl(dataReader.GetValue(2).ToString()));
                        row.Cells.Add(descriptionCell);
                        categoryCell.Controls.Add(new LiteralControl(dataReader.GetValue(3).ToString()));
                        row.Cells.Add(categoryCell);
                        gameImage.ImageUrl = dataReader.GetValue(4).ToString();
                        imageCell.Controls.Add(gameImage);
                        row.Cells.Add(imageCell);
                        priceCell.Controls.Add(new LiteralControl("$"+dataReader.GetValue(5).ToString()));
                        row.Cells.Add(priceCell);
                        buttonCell.Controls.Add(updateButton);
                        buttonCell.Controls.Add(deleteButton);
                        row.Cells.Add(buttonCell);
                        ProductTable.Rows.Add(row);
                        i++;
                    }
                    con.Close();
                } catch (Exception ex)
                {
                    con.Close();
                    Response.Write("<script>alert('"+ex.Message+"');</script>");
                }
            }
        }
        public void updateButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int i = int.Parse(button.ID.Remove(numberformat));
            Session["outdatedGame"] = new Game(Global.gameList[i].Id, Global.gameList[i].Name, Global.gameList[i].Description,
                Global.gameList[i].Category, Global.gameList[i].ImageUrl, Global.gameList[i].Price);
            Response.Redirect("UpdateGame.aspx");
        }

        public void deleteButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int i = int.Parse(button.ID.Remove(numberformat));
            SqlConnection con = new SqlConnection(Global.dbcon);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }                

                SqlCommand cmd = new SqlCommand("DELETE FROM game WHERE id = @id;", con);
                cmd.Parameters.AddWithValue("@id", Global.gameList[i].Id);//not set to an instance of an object null exception
                int deleted = cmd.ExecuteNonQuery();

                Global.RefreshGameList();

                if (deleted == 1)
                {
                    Response.Write("<script>alert('" + deleted + " game deleted successfully!');</script>");
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

        protected void AddNewButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddGame.aspx");
        }
    }
}