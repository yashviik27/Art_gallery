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
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter sda;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fnBindArtistDDl();
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
                }
            }
            catch (Exception e)
            {
                Response.Write(e.ToString());
            }
        }

        protected void fninsert()
        {
            string aId = ddlartistname.Text;
            String name = txtartname.Text;
            String price = txtartprice.Text;
            String desc = txtartdesc.Text;
            String img = "~/image/" + artimgpath.FileName;

            try
            {
                fnconnection();
                String qry = "INSERT INTO tbl_art (aId,art_Name,art_price,art_Description,art_Image) VALUES ('" + aId + "','" + name + "','" + price + "','" + desc + "','" + img + "')";

                cmd = new SqlCommand(qry, conn);
                int isInsert = cmd.ExecuteNonQuery();
                artimgpath.SaveAs(Server.MapPath(img));
                if (isInsert > 0)
                {
                    //Response.Write("Inserted Succ");
                }
                else
                {
                    Response.Write("Inserted Fail");
                }

            }
            catch (Exception e)
            {
                Response.Write(e.Message);
            }
        }

        protected void btsubmit_Click(object sender, EventArgs e)
        {
            fninsert();
            Response.Redirect("~/artrequest.aspx");
        }
        protected void fnBindArtistDDl()
        {
            fnconnection();
            cmd = new SqlCommand("select * FROM tbl_artist", conn);
            sda = new SqlDataAdapter(cmd);
            DataSet dr = new DataSet();
            sda.Fill(dr);
            ddlartistname.DataSource = dr;
            ddlartistname.Items.Clear();
            ddlartistname.Items.Add("--Please Select artist--");
            ddlartistname.DataTextField = "aName";
            ddlartistname.DataValueField = "aId";
            ddlartistname.DataBind();
            conn.Close();
        }
    }
}