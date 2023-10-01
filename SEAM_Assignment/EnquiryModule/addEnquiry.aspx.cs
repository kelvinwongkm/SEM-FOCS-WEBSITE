using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace SEAM_Assignment.EnquiryModule
{
    public partial class addEnquiry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addEnquiryBtn_Click(object sender, EventArgs e)
        {
            // Retrieve the subject and description from the TextBoxes
            string enquirySubject = enqSubjectTxt.Text.Trim();
            string description = enqDescriptionTxt.Text.Trim();

            // Check if the subject or description is empty
            if (string.IsNullOrEmpty(enquirySubject) || string.IsNullOrEmpty(description))
            {
                // Display an error message
                ShowErrorMessage("Enquiry subject and description are required fields.");
            }
            else
            {
                // Subject and description are not empty, proceed with inserting into the database
                int userId = Convert.ToInt32(Session["user_id"]);
                string status = "processing";
                string timestamp = DateTime.Now.ToString();

                // Establish a database connection using the connection string
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Define an SQL query to insert data into the "Enquiry" table
                    string query = "INSERT INTO Enquiry (subject, description, timeStamp, status, userId) VALUES (@subject, @description, @timestamp, @status, @userId)";

                    // Create a SqlCommand object
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        cmd.Parameters.AddWithValue("@subject", enquirySubject);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@timestamp", timestamp);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@userId", userId); // Set the userId parameter

                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }
                }

                // Redirect the user to the previous page
                ShowConfirmationMessage("Your enquiry has been successfully submitted!");
            }
        }


        private void ShowErrorMessage(string message)
        {
            // Display a JavaScript alert with the specified error message
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ErrorScript", $"alert('{message}');", true);
        }

        protected void cancelBtn_Click(object sender, EventArgs e)
        {

            Response.Redirect("enquiryUser.aspx");

        }

        private void ShowConfirmationMessage(string message)
        {
            // Display a JavaScript alert with the specified message
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ConfirmationScript", $"alert('{message}');", true);

            // Redirect the admin to the previous page
            Response.Redirect("enquiryUser.aspx");
        }
    }
}