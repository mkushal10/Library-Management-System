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
    }
}