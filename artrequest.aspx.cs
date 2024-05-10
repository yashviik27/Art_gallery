using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Artgallery
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter sda;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["art_name"] != null)
            {
                //art_name = (string)Session["art_name"];
                
            }
            else
            {
                Response.Redirect("~/welcome.aspx");
            }
            fndgvart();
        }
        protected void fnconnection()
        {
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                Response.Write(e.ToString());
            }
        }
        protected void btnaccept_Click(object sender, EventArgs e)
        {
            Response.Write("insert successfull");
        }

        protected void btndecline_Click(object sender, EventArgs e)
        {

            GridViewRow rw = dgvrequest.SelectedRow;
            int del_id = Convert.ToInt32(rw.Cells[1].Text);
            try
            {
                fnconnection();
                string qry = "delete from tbl_art where art_Id=" + del_id + ";";
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
                fndgvart();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void fndgvart()
        {
            try
            {
                fnconnection();
                string qry = "select art.art_Id,art.art_Name,art.art_price,art.art_Description,a.aName from tbl_art art,tbl_artist a where art.aID=a.aId";
                cmd = new SqlCommand(qry, conn);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dgvrequest.DataSource = ds;
                dgvrequest.DataBind();
                dgvrequest.Visible = false; 
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}