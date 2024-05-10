using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Artgallery
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["Email"] != null)
                {
                    //Response.Redirect("~/home.aspx");
                }
                else
                {
                    Response.Redirect("~/admin_login.aspx");
                }
            }
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
        protected void btnenter_Click(object sender, EventArgs e)
        {
            if (ddladmintype.SelectedItem.Text == "Artist")
            {
                Response.Redirect("~/admin_artist.aspx");
            }
            else if (ddladmintype.SelectedItem.Text == "User")
            {
                Response.Redirect("~/admin_user.aspx");
            }
            else if (ddladmintype.SelectedItem.Text=="Art")
            {
                Response.Redirect("~/admin_art.aspx");
            }
            //else if (ddladmintype.SelectedItem.Text == "Welcome")
            //{
            //    Response.Redirect("~/welcome.aspx");
            //}
        }
    }
}