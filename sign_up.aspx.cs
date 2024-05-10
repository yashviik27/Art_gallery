using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Artgallery
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataAdapter sda;
        protected void Page_Load(object sender, EventArgs e)
        {
            fnconnection();
        }
        protected void fnconnection()
        {
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    //Response.Write("hello gelsapa !!!!");

                }
            }
            catch (Exception e)
            {
                Response.Write(e.ToString());
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (ddlusertype.SelectedItem.Text == "Artist")
            {
                Response.Redirect("~/artist_reg.aspx");
            }
            else if (ddlusertype.SelectedItem.Text == "User")
            {
                Response.Redirect("~/user_reg.aspx");
            }
        }
    }
}