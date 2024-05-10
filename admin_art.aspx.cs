using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Drawing;

namespace Artgallery
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataAdapter sda;
        protected void Page_Load(object sender, EventArgs e)
        {
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
                    //Response.Write("HELLO GELSAPAAA!!!!!!!!!");

                }
            }
            catch (Exception e)
            {
                Response.Write(e.ToString());
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
                dgv_art.DataSource = ds;
                dgv_art.DataBind();
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void dgv_art_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow rw = dgv_art.Rows[e.RowIndex];
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

        

       

      

        //protected void dgv_art_RowUpdating(object sender, GridViewUpdateEventArgs e)
        //{
        //    fnconnection();
        //    GridViewRow row = dgv_art.Rows[e.RowIndex];

        //    int art_Id = Convert.ToInt32(dgv_art.DataKeys[e.RowIndex].Value);

        //    string art_Name = (row.Cells[2].Controls[0] as System.Web.UI.WebControls.TextBox).Text;
        //    //     string art_Description = (row.Cells[3].Controls[0] as System.Web.UI.WebControls.TextBox).Text;
        //    decimal art_price = Convert.ToDecimal((row.Cells[3].Controls[0] as System.Web.UI.WebControls.TextBox).Text);

        //    //  DropDownList cat1 = dgv_art.Rows[e.RowIndex].FindControl("ddl_category") as DropDownList;
        //    //int cat2 = Convert.ToInt16(cat1.SelectedValue);

        //    //  DropDownList brand1 = gvProducts.Rows[e.RowIndex].FindControl("ddl_brand") as DropDownList;
        //    //  int brand2 = Convert.ToInt16(brand1.SelectedValue);


        //    // UPDATE CODE 

        //    cmd = new SqlCommand();
        //    cmd.CommandText = "UPDATE tbl_art SET art_Name='" + art_Name + "', art_price='" + art_price + " WHERE art_Id=" + art_Id;
        //    cmd.Connection = conn;
        //    int i = cmd.ExecuteNonQuery();

        //    if (i > 0)
        //    {
        //        Response.Write("<script> alert('Record Updated Successfully...')</script>");
        //    }
        //    conn.Close();
        //    dgv_art.EditIndex = -1;
        //    fndgvart();
        //}

        //protected void dgv_art_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}
    
