using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_Management_System
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(""))
                {
                    BtnUserLogin.Visible = true; // user login link button
                    BtnSignUp.Visible = true; // sign up link button

                    BtnLogout.Visible = false; // logout link button
                    BtnUserName.Visible = false; // hello user link button


                    BtnAdminLogin.Visible = true; // admin login link button
                    BtnAuthorManagement.Visible = false; // author management link button
                    BtnPublisherManagement.Visible = false; // publisher management link button
                    BtnBookInventory.Visible = false; // book inventory link button
                    BtnBookIssuing.Visible = false; // book issuing link button
                    BtnMemberManagement.Visible = false; // member management link button

                }
                else if (Session["role"].Equals("user"))
                {
                    BtnUserLogin.Visible = false; // user login link button
                    BtnSignUp.Visible = false; // sign up link button

                    BtnLogout.Visible = true; // logout link button
                    BtnUserName.Visible = true; // hello user link button
                    BtnUserName.Text = "Hello " + Session["username"].ToString();


                    BtnAdminLogin.Visible = true; // admin login link button
                    BtnAuthorManagement.Visible = false; // author management link button
                    BtnPublisherManagement.Visible = false; // publisher management link button
                    BtnBookInventory.Visible = false; // book inventory link button
                    BtnBookIssuing.Visible = false; // book issuing link button
                }
                else if (Session["role"].Equals("admin"))
                {
                    BtnUserLogin.Visible = false; // user login link button
                    BtnSignUp.Visible = false; // sign up link button

                    BtnLogout.Visible = true; // logout link button
                    BtnUserName.Visible = true; // hello user link button
                    BtnUserName.Text = "Hello Admin";


                    BtnAdminLogin.Visible = false; // admin login link button
                    BtnAuthorManagement.Visible = true; // author management link button
                    BtnPublisherManagement.Visible = true; // publisher management link button
                    BtnBookInventory.Visible = true; // book inventory link button
                    BtnBookIssuing.Visible = true; // book issuing link button
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        protected void BtnAuthorManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageAuthor.aspx");
        }

        protected void BtnPublisherManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManagePublisher.aspx");
        }

        protected void BtnBookInventory_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookInventory.aspx");
        }

        protected void BtnBookIssuing_Click(object sender, EventArgs e)
        {
            Response.Redirect("IssueBook.aspx");
        }

        protected void BtnMemberManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageMember.aspx");
        }

        protected void BtnViewBooks_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbooks.aspx");
        }

        protected void BtnUserLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserLogin.aspx");
        }

        protected void BtnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserSignUp.aspx");
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";

            BtnUserLogin.Visible = true; // user login link button
            BtnSignUp.Visible = true; // sign up link button

            BtnLogout.Visible = false; // logout link button
            BtnUserName.Visible = false; // hello user link button


            BtnAdminLogin.Visible = true; // admin login link button
            BtnAuthorManagement.Visible = false; // author management link button
            BtnPublisherManagement.Visible = false; // publisher management link button
            BtnBookInventory.Visible = false; // book inventory link button
            BtnBookIssuing.Visible = false; // book issuing link button
            BtnMemberManagement.Visible = false; // member management link button
        }
    }
}