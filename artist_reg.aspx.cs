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
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataAdapter sda;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fnBindArtistDDl();
                fnbinddrop();


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

        protected void fnBindArtistDDl()
        {
            fnconnection();
            cmd = new SqlCommand("select * FROM tbl_artist_type", conn);
            sda = new SqlDataAdapter(cmd);
            DataSet dr = new DataSet();
            sda.Fill(dr);
            ddlartist_type.DataSource = dr;
            ddlartist_type.Items.Clear();
            ddlartist_type.Items.Add("--Please Select artist--");
            ddlartist_type.DataTextField = "artist_type";
            ddlartist_type.DataValueField = "tid";
            ddlartist_type.DataBind();
            conn.Close();
        }

        protected void fninsert()
        {
            String name = txtname.Text;
            String email = txtemail.Text;
            String pass = txtpass.Text;
            String phone = txtphoneno.Text;
            String add = txtaddeess.Text;
            String state = ddlstate.SelectedValue;
            String city = ddlcity.SelectedValue;
            String gender = rblgender.SelectedValue;
            string tid = ddlartist_type.SelectedValue;

            try
            {
                fnconnection();
                String qry = "INSERT INTO tbl_artist (aName,aEmail,aPassword,aPhoneno,aAddress,aState,aCity,aGender,tId) VALUES ('" + name + "','" + email + "','" + pass + "'," + phone + ",'" + add + "','" + state + "','" + city + "','" + gender + "','" + tid + "')";

                cmd = new SqlCommand(qry, conn);
                int isInsert = cmd.ExecuteNonQuery();

                if (isInsert > 0)
                {
                    Response.Write("Inserted Succ");
                }
                else
                {
                    Response.Write("Inserted Fail");
                }
                //     fngridbind();
            }
            catch (Exception e)
            {
                Response.Write(e.Message);
            }
        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            //fninsert();
            fninsertOrUpdate();
            Response.Redirect("art_reg.aspx");

        }



        protected void btnreset_Click(object sender, EventArgs e)
        {
            {
                txtname.Text = "";
                txtemail.Text = "";
                txtphoneno.Text = "";
                txtaddeess.Text = "";
                ddlstate.Items.Clear();
                ddlcity.ClearSelection();
            }
        }
        public void fnbinddrop()
        {
            try
            {
                fnconnection();
                string qry = "SELECT * FROM tbl_artist";
                // string qry = "SELECT * FROM tbl_brand WHERE b_type=mobile";
                //Response.Write(ddlmstate.SelectedItem.ToString());
                cmd = new SqlCommand(qry, conn);
                //cmd.Parameters.AddWithValue("mState", ddlmstate.SelectedValue);
                sda = new SqlDataAdapter(cmd);
                DataSet ds2 = new DataSet();
                sda.Fill(ds2);
                ddlstate.DataSource = ds2;
                ddlstate.DataValueField = "aState";
                ddlstate.DataTextField = "aState";
                ddlstate.DataBind();
                conn.Close();
                ddlstate.Items.Insert(0, new ListItem("--SELECTCITY--"));

                // Response.Write(qry);

            }
            catch (Exception ex)
            {

                Response.Write(ex.ToString());
            }
        }

        public void Bind_ddlCity()
        {
            fnconnection();
            cmd = new SqlCommand("select * from tbl_artist where aState ='" + ddlstate.SelectedValue + "'", conn);
            sda = new SqlDataAdapter(cmd);
            DataSet dr = new DataSet();
            sda.Fill(dr);
            ddlcity.DataSource = dr;
            ddlcity.Items.Clear();
            ddlcity.Items.Add("--Please Select city--");
            ddlcity.DataTextField = "aCity";
            ddlcity.DataValueField = "aCity";
            ddlcity.DataBind();
            conn.Close();
        }
        protected void fninsertOrUpdate()
        {
            string name = txtname.Text;
            string email = txtemail.Text;
            string pass = txtpass.Text;
            string phone = txtphoneno.Text;
            string add = txtaddeess.Text;
            string state = ddlstate.SelectedValue;
            string city = ddlcity.SelectedValue;
            string gender = rblgender.SelectedValue;
            string tid = ddlartist_type.SelectedValue;

            try
            {
                fnconnection();
                string qry = "SELECT COUNT(*) FROM tbl_artist WHERE aName = '" + name + "'";
                cmd = new SqlCommand(qry, conn);
                int artistCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (artistCount > 0)
                {
                    // Artist exists, update the record
                    fnUpdate(name, email, pass, phone, add, state, city, gender, tid);
                }
                else
                {
                    // Artist does not exist, insert a new record
                    qry = "INSERT INTO tbl_artist (aName,aEmail,aPassword,aPhoneno,aAddress,aState,aCity,aGender,tId) " +
                          "VALUES ('" + name + "','" + email + "','" + pass + "','" + phone + "','" + add + "','" + state + "','" + city + "','" + gender + "','" + tid + "')";
                    cmd = new SqlCommand(qry, conn);
                    int isInsert = cmd.ExecuteNonQuery();

                    if (isInsert > 0)
                    {
                        Response.Write("Inserted Successfully");
                    }
                    else
                    {
                        Response.Write("Insertion Failed");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void fnUpdate(string name, string email, string pass, string phone, string add, string state, string city, string gender, string tid)
        {
            try
            {
                fnconnection();
                string qry = "UPDATE tbl_artist SET aEmail = '" + email + "', aPassword = '" + pass + "', aPhoneno = '" + phone + "', " +
                             "aAddress = '" + add + "', aState = '" + state + "', aCity = '" + city + "', aGender = '" + gender + "', " +
                             "tId = '" + tid + "' WHERE aName = '" + name + "'";
                cmd = new SqlCommand(qry, conn);
                int isUpdated = cmd.ExecuteNonQuery();

                if (isUpdated > 0)
                {
                    Response.Write("Updated Successfully");
                }
                else
                {
                    Response.Write("Update Failed");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }


        protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_ddlCity();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            fninsertOrUpdate();
        }
    }
}