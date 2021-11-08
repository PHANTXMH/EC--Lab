using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Gamora
{
    public class Global : HttpApplication
    {
        public static List<CartItem> myCartList = new List<CartItem>();
        public static List<Game> gameList;
        public static string dbcon = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RefreshGameList();
        }

        public static void RefreshGameList()
        {
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
                    int i = 0;
                    gameList = new List<Game>();
                    while (dataReader.Read())
                    {
                        gameList.Add(new Game(int.Parse(dataReader.GetValue(0).ToString()), dataReader.GetValue(1).ToString(),
                            dataReader.GetValue(2).ToString(), dataReader.GetValue(3).ToString(), dataReader.GetValue(4).ToString(),
                            int.Parse(dataReader.GetValue(5).ToString())));                        
                        i++;
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                
                con.Close();
            }
        }
    }
}