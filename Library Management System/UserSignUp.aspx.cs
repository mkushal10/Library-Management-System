using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_Management_System
{
    public partial class UserSignUp : System.Web.UI.Page
    {
        //holding ConnectionStrings through strncon object
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSignUp_Click(object sender, EventArgs e)
        {
            //hard coded, JavaScript
            //Response.Write("<script>alert('Testing');</script>");
            if (checkMemberExists())
            {
                Response.Write("<script>alert('Username is already exist with this username, try other ID');</script>");
            }
            else
            {
                signUpNewMember();
            }
        }
        // user defined method
        bool checkMemberExists()
        {
            try
            {
                //in-build class of Sql Connection
                //need to add namespace -- System.Data.SqlClient
                //con object requires a parameter, that parameter is strcon which is ConnectionStrings
                SqlConnection con = new SqlConnection(strcon);

                //check the connection is open or not
                //if closed essential to open
                if (con.State == ConnectionState.Closed)
                {
                    //opened the connection
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from member_master_table where member_id='" + TextBox8.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }
        void signUpNewMember()
        {
            //Response.Write("<script>alert('Testing');</script>");
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO member_master(full_name,dob,contact_no,email,state,city,pincode,full_address,member_id,password,account_status) values(@full_name,@dob,@contact_no,@email,@state,@city,@pincode,@full_address,@member_id,@password,@account_status)", con);
                cmd.Parameters.AddWithValue("@full_name", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@dob", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@contact_no", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@email", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@state", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@city", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@pincode", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@full_address", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@member_id", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@password", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@account_status", "pending");
                //inserts all the values from the form
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('You are successfullt Sign Up. Go to User Login to Login');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}