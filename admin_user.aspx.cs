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
    public partial class WebForm10 : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataAdapter sda;
        protected void Page_Load(object sender, EventArgs e)
        {
            fndgvuser();
        }
        protected void fnconnection()
        {
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    //Response.Write("HELLO GELSAPAAA!!!!!!!!!");

                }
            }
            catch (Exception e)
            {
                Response.Write(e.ToString());
            }
        }
        protected void fndgvuser()
        {
            try
            {
                fnconnection();
                string qry = "select * from tbl_members";
                cmd = new SqlCommand(qry, conn);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dgv_user.DataSource = ds;
                dgv_user.DataBind();
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void dgv_user_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow rw = dgv_user.Rows[e.RowIndex];
            int del_id = Convert.ToInt32(rw.Cells[1].Text);
            try
            {
                fnconnection();
                string qry = "delete from tbl_members where mId=" + del_id + ";";
                cmd = new SqlCommand(qry, conn);
                int isdel = cmd.ExecuteNonQuery();
                if (isdel > 0)
                {
                    Response.Write("row deleted successfully");
                }
                else
                {
                    Response.Write("row deletion fail");
                }
                fndgvuser();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}