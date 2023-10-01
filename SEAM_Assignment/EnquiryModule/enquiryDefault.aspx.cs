using System;

namespace SEAM_Assignment.EnquiryModule
{
    public partial class enquiryDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if the user is logged in (you can use a session variable or any other method to check)
                if (Session["user_id"] != null)
                {
                    // User is not logged in, redirect to enquiryDefault.aspx
                    Response.Redirect("~/EnquiryModule/enquiryUser.aspx");
                }
                else if (Session["admin_id"] != null)
                {
                    Response.Redirect("~/EnquiryModule/enquiryStaff.aspx");
                }
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AuthenticationModule/Login.aspx");
        }
    }
}