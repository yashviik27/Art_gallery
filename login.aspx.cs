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
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataAdapter sda;
        protected void Page_Load(object sender, EventArgs e)
        {
            //login();
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
        protected void login()
        {
            try
            {
                fnconnection();
                cmd = new SqlCommand("SELECT count(*) FROM tbl_members where mEmail='" + txtemail.Text + "' AND mPassword = '" + txtpassword.Text + "';", conn);
                int e = (int)cmd.ExecuteScalar();
                if (e > 0)
                {
                    Session["Email"] = txtemail.Text;
                    
                    Response.Redirect("~/welcome.aspx");
                }
                else
                {
                    
                    Response.Write("Invalid email & password");
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Response.Write(e.ToString());

            }
        }
        protected void loginartist()
        {
            try
            {
                fnconnection();
                cmd = new SqlCommand("SELECT count(*) FROM tbl_artist where aEmail='" + txtemail.Text + "' AND aPassword = '" + txtpassword.Text + "';", conn);
                int e = (int)cmd.ExecuteScalar();
                if (e > 0)
                {
                    Session["Email"] = txtemail.Text;
                   
                    Response.Redirect("~/welcome.aspx");
                }
                else
                {
                    
                    Response.Write("Invalid email & password");
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Response.Write(e.ToString());

            }
        }
        protected void loginadmin()
        {
            try
            {
                fnconnection();
                cmd = new SqlCommand("SELECT count(*) FROM tbl_admin where email='" + txtemail.Text + "' AND password = '" + txtpassword.Text + "';", conn);
                int e = (int)cmd.ExecuteScalar();
                if (e > 0)
                {
                    Session["Email"] = txtemail.Text;

                    Response.Redirect("~/welcome.aspx");
                }
                else
                {

                    Response.Write("Invalid email & password");
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Response.Write(e.ToString());

            }
        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            login();
            loginartist();
            loginadmin();
        }
    }
}