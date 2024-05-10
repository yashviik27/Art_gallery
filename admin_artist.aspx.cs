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
    public partial class WebForm8 : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataAdapter sda;
        protected void Page_Load(object sender, EventArgs e)
        {
            //fnconnection();
            fndgvartist();
            
            //fndgvuser();    
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
        protected void fndgvartist()
        {
            try
            {
                fnconnection();
                string qry = "select a.aId,a.aName,a.aEmail,a.aPhoneno,a.aAddress,a.aState,a.acity,a.aGender,t.artist_type from tbl_artist a,tbl_artist_type t where t.tID=a.tId";
                cmd = new SqlCommand(qry, conn);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dgv_artist.DataSource = ds;
                dgv_artist.DataBind();
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void dgv_artist_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow rw = dgv_artist.Rows[e.RowIndex];
            int del_id = Convert.ToInt32(rw.Cells[1].Text);
            try
            {
                fnconnection();
                string qry = "delete from tbl_artist where aId=" + del_id + ";";
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
                fndgvartist();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        
    }
}