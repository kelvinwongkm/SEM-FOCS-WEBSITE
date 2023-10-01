using System;

namespace SEAM_Assignment
{
    public partial class UserHeaderFooter : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if the user is logged in
                if (Session["user_id"] != null || Session["admin_id"] != null)
                {

                    // User is logged in, change the button text to "Log Out"
                    btnLogIn.Text = "Log Out";
                }
                else
                {
                    // User is not logged in, button text remains "Log In"
                    btnLogIn.Text = "Log In";
                }
            }
        }

        protected void btnLogIn_Click_1(object sender, EventArgs e)
        {
            if (Session["user_id"] != null || Session["admin_id"] != null)
            {
                // User is logged in, log them out
                Session["user_id"] = null;
                Session["admin_id"] = null;
                Response.Redirect("/Home.aspx");
                btnLogIn.Text = "Log In";
            }
            else
            {
                // User is not logged in, redirect to the login page
                Response.Redirect("/AuthenticationModule/Login.aspx");
            }
        }

    }
}