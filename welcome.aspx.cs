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
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter sda;
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
                    Response.Redirect("~/login.aspx");
                }
            }
            
        }
        protected void fnconnection()
        {
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    // Response.Write("hello gelsapa !!!!");

                }
            }
            catch (Exception e)
            {
                Response.Write(e.ToString());
            }
        }
        protected void fn_dataBind()
        {
            try
            {
                fnconnection();
                cmd = new SqlCommand("SELECT art_Name,art_Description,art_Image FROM tbl_art WHERE art_Id= art_Id", conn);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                //dgvuser.DataSource = ds;
                dgvuser.DataBind();
                dgvuser.Visible = false;

                conn.Close();
            }
            catch (Exception e)
            {
                Response.Write(e.ToString());
            }

        }
        protected void btnsearch_Click(object sender, EventArgs e)
        {
            //fn_dataBind();
            //fnsearch();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            //fnconnection();
            //string qry = "SELECT COUNT(*) FROM tbl_art where art_Name="+ e.CommandArgument.ToString();
            //cmd = new SqlCommand(qry, conn);
            //int res = (int)cmd.ExecuteScalar();
            //if (res > 0)
            //{
            //    string v = e.CommandSource.ToString();
            //    base.Session["art_name"] = v;
            //    Response.Redirect("~/artrequest.aspx");
            //}
            //else
            //{
            //    //Response.Write("Invalid Email or Password");
            //}
            //conn.Close();
            //DropDownList downList = (DropDownList)(e.Item.FindControl("DropDownList1"));
            //Response.Redirect("addtocart.aspx?art_Name=" + e.CommandArgument.ToString() /*+ "&art_price=" + downList.SelectedItem.ToString()*/);

        }
        protected void fnrequest()
        {
            
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Response.Redirect("~/addtocart.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/addtocart.aspx");
        }




        //protected void fnsearch()
        //{
        //    try
        //    {
        //        fnconnection();
        //        //string search=txtsearch.Text.Trim();
        //        string searchc=ddlart_type.SelectedValue;
        //        string qry = "select art_Name,art_Price,art_Description,art_Image from tbl_art where" + searchc + "like @searchc+--";
        //        cmd= new SqlCommand(qry, conn); 
        //        sda= new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);
        //        dgvuser.DataBind();
        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message);
        //    }
        //}

        //try
        //    {
        //        String qry = "SELECT * FROM tbl_art WHERE art_Name=@art_Name";
        //cmd = new SqlCommand(qry, conn);
        //DataSet ds = new DataSet();
        //sda.Fill(ds);
        //        //dgvuser.DataSource = ds;
        //        dgvuser.DataBind();
        //        dgvuser.Visible = true;
        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message);
        //    }



        /*     protected void fnBindArtistDDl()
    {
        fnconnection();
        cmd = new SqlCommand("select * FROM tbl_art", conn);
        sda = new SqlDataAdapter(cmd);
        DataSet dr = new DataSet();
        sda.Fill(dr);
        ddlart_type.DataSource = dr;
        ddlart_type.Items.Clear();
        ddlart_type.Items.Add("--Please Select art name--");
        ddlart_type.DataTextField = "art_Name";
    //    ddlart_type.DataValueField = "tid";
        ddlart_type.DataBind();
        conn.Close();
    }

    protected void ddlart_type_SelectedIndexChanged(object sender, EventArgs e)
    {
        fnBindArtistDDl();
    }*/
    }
}