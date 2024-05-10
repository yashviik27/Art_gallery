using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace Artgallery
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter sda;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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
                }
            }
            catch (Exception e)
            {
                Response.Write(e.ToString());
            }
        }
        protected void fninsert()
        {
            String name = txtmname.Text;
            String email = txtmemail.Text;
            String password = txtmpass.Text;
            String confpass = txtmconfirmpass.Text;
            String phone = txtmphone.Text;
            String state = ddlmstate.SelectedValue;
            String city = ddlmcity.SelectedValue;
            String gender = rblmgender.SelectedValue;
            String add = txtmaddress.Text;

            try
            {
                fnconnection();
                String qry = "INSERT INTO tbl_members (mName,mEmail,mPassword,mCon_password,mPhoneno,mState,mCity,mGender,mAddress) VALUES ('" + name + "','" + email + "'," + password + ",'" + confpass + "','" + phone + "','" + state + "','" + city + "','" + gender + "','" + add + "')";

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
                //    fngridbind();

            }
            catch (Exception e)
            {
                Response.Write(e.Message);
            }
        }

        protected void btnmsubmit_Click(object sender, EventArgs e)
        {
            fninsert();
            Response.Redirect("home.aspx");
        }
        public void fnbinddrop()
        {
            try
            {
                fnconnection();
                string qry = "SELECT * FROM tbl_members";
                // string qry = "SELECT * FROM tbl_brand WHERE b_type=mobile";
                //Response.Write(ddlmstate.SelectedItem.ToString());
                cmd = new SqlCommand(qry, conn);
                //cmd.Parameters.AddWithValue("mState", ddlmstate.SelectedValue);
                sda = new SqlDataAdapter(cmd);
                DataSet ds2 = new DataSet();
                sda.Fill(ds2);
                ddlmstate.DataSource = ds2;
                ddlmstate.DataValueField = "mState";
                ddlmstate.DataTextField = "mState";
                ddlmstate.DataBind();
                conn.Close();
                ddlmstate.Items.Insert(0, new ListItem("--SELECT--"));

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
            cmd = new SqlCommand("select * from tbl_members where mState ='" + ddlmstate.SelectedValue + "'", conn);
            sda = new SqlDataAdapter(cmd);
            DataSet dr = new DataSet();
            sda.Fill(dr);
            ddlmcity.DataSource = dr;
            ddlmcity.Items.Clear();
            ddlmcity.Items.Add("--Please Select city--");
            ddlmcity.DataTextField = "mCity";
            ddlmcity.DataValueField = "mCity";
            ddlmcity.DataBind();
            conn.Close();
        }

        protected void fninsertOrUpdate()
        {
            string name = txtmname.Text;
            string email = txtmemail.Text;
            string pass = txtmpass.Text;
            string conpass = txtmconfirmpass.Text;
            string phone = txtmphone.Text;
            string add = txtmaddress.Text;
            string state = ddlmstate.SelectedValue;
            string city = ddlmcity.SelectedValue;
            string gender = rblmgender.SelectedValue;
            

            try
            {
                fnconnection();
                string qry = "SELECT COUNT(*) FROM tbl_artist WHERE aName = '" + name + "'";
                cmd = new SqlCommand(qry, conn);
                int artistCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (artistCount > 0)
                {
                    // Artist exists, update the record
                    fnUpdate(name, email, pass,conpass, phone, add, state, city, gender);
                }
                else
                {
                    // Artist does not exist, insert a new record
                    qry = "INSERT INTO tbl_members (mName,mEmail,mPassword,mCon_password,mPhoneno,mAddress,mState,mCity,mGender) " +
                          "VALUES ('" + name + "','" + email + "','" + pass + "','" + conpass + "','" + phone + "','" + add + "','" + state + "','" + city + "','" + gender + "')";
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

        protected void fnUpdate(string name, string email, string pass,string conpass, string phone, string add, string state, string city, string gender)
        {
            try
            {
                fnconnection();
                string qry = "UPDATE tbl_members SET mEmail = '" + email + "', mPassword = '" + pass + "',mCon_password = '" + conpass + "', mPhoneno = '" + phone + "', " +
                             "mAddress = '" + add + "', mState = '" + state + "', mCity = '" + city + "', mGender = '" + gender + "' WHERE mName = '" + name + "'";

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
        protected void ddlmstate_SelectedIndexChanged(object sender, EventArgs e)
        {

            Bind_ddlCity();
        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            {
                txtmname.Text = "";
                txtmemail.Text = "";
                txtmpass.Text = "";
                txtmconfirmpass.Text = "";
                txtmphone.Text = "";
                ddlmstate.Items.Clear();
                ddlmcity.ClearSelection();
                txtmaddress.Text = "";
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            fninsertOrUpdate();
        }
    }
}