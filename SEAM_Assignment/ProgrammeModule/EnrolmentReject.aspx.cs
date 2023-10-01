using System;

namespace SEAM_Assignment.ProgrammeModule
{
    public partial class EnrolmentReject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Text = (string)Session["ErrorMsg"];
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Home.aspx");
        }
    }
}