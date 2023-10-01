using System;

namespace SEAM_Assignment.ProgrammeModule
{
    public partial class EnrolmentAccept : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Home.aspx");
        }
    }
}