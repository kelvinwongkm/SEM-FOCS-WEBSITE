using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace SEAM_Assignment.EnquiryModule
{
    public partial class enquiryStaffReply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if the enquiryId query parameter is present in the URL
                if (Request.QueryString["enquiryId"] != null)
                {
                    int enquiryId = Convert.ToInt32(Request.QueryString["enquiryId"]);

                    // Fetch and display the details of the selected enquiry
                    DisplayEnquiryDetails(enquiryId);
                }
            }
        }

        void DisplayEnquiryDetails(int enquiryId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define a SQL query to retrieve the details of the selected enquiry by its ID
                string query = "SELECT [Id], [subject], [description], [timeStamp], [status], [userId]" +
                               "FROM [Enquiry] " +
                               "WHERE [Id] = @EnquiryId";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Add the parameter for the enquiryId
                    cmd.Parameters.AddWithValue("@EnquiryId", enquiryId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve the enquiry details from the database
                            int id = reader.GetInt32(reader.GetOrdinal("Id"));
                            string subject = reader.GetString(reader.GetOrdinal("subject"));
                            string description = reader.GetString(reader.GetOrdinal("description"));
                            DateTime timeStamp = reader.GetDateTime(reader.GetOrdinal("timeStamp"));
                            string status = reader.GetString(reader.GetOrdinal("status"));
                            //string userId = reader.IsDBNull(reader.GetOrdinal("userId")) ? "null" : reader.GetString(reader.GetOrdinal("userId"));
                            int userID = reader.GetOrdinal("userId");
                            // Display the enquiry details on the page
                            enqIDlbl.Text = id.ToString();
                            enqSubjectlbl.Text = subject;
                            enqDesclbl.Text = description;
                            timeLbl.Text = timeStamp.ToString("MM/dd/yyyy HH:mm:ss");
                            enqStatuslbl.Text = status;
                            //enqUserIdlbl.Text = userId;
                        }
                        else
                        {
                            // Display a message indicating that the enquiry was not found
                            enqIDlbl.Text = "Enquiry not found.";
                        }
                    }
                }
            }
        }

        private bool InsertReplyIntoDatabase(int enquiryId, string replyText)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            int adminid = Convert.ToInt32(Session["admin_id"]);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define the SQL query to insert the reply into the database and update the status
                string insertQuery = "INSERT INTO [EnquiryReply] ([EnquiryId], [ReplyText], [ReplyTime], [adminid]) " +
                                    "VALUES (@EnquiryId, @ReplyText, @ReplyTime, @adminid)";

                string updateQuery = "UPDATE [Enquiry] SET [status] = 'completed' WHERE [Id] = @EnquiryId";

                using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                {
                    insertCmd.Parameters.AddWithValue("@EnquiryId", enquiryId);
                    insertCmd.Parameters.AddWithValue("@ReplyText", replyText);
                    insertCmd.Parameters.AddWithValue("@ReplyTime", DateTime.Now); // Use the current date/time as the reply date
                    insertCmd.Parameters.AddWithValue("@adminid", adminid); // Use the current date/time as the reply date

                    // Execute the SQL command to insert the reply
                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // The reply was successfully inserted, now update the status
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@EnquiryId", enquiryId);
                            int statusRowsAffected = updateCmd.ExecuteNonQuery();

                            // Return true if both the reply and status update were successful
                            return statusRowsAffected > 0;
                        }
                    }
                    else
                    {
                        // Return false if the reply insertion failed
                        return false;
                    }
                }
            }
        }

        protected void enqReplyBtn_Click(object sender, EventArgs e)
        {
            // Get the reply text from the TextBox
            string replyText = enqReplyTxt.Text.Trim(); // Trim any leading or trailing whitespace

            // Check if the reply text is empty
            if (string.IsNullOrEmpty(replyText))
            {
                // Display an error message
                ShowErrorMessage("Reply text cannot be empty.");
            }
            else
            {
                // Reply text is not empty, proceed with inserting into the database
                int enquiryId = Convert.ToInt32(enqIDlbl.Text); // Assuming enqIDlbl contains the Enquiry ID
                InsertReplyIntoDatabase(enquiryId, replyText);

                // Redirect the admin to the previous page
                ShowConfirmationMessage("Reply has been successfully submitted!");
            }

        }
        private void ShowErrorMessage(string message)
        {
            // Display a JavaScript alert with the specified error message
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ErrorScript", $"alert('{message}');", true);
        }


        protected void enqCancelBtn_Click(object sender, EventArgs e)
        {
            // Redirect the admin to the previous page without any action
            Response.Redirect("enquiryStaff.aspx");
        }

        private void ShowConfirmationMessage(string message)
        {
            // Display a JavaScript alert with the specified message
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ConfirmationScript", $"alert('{message}');", true);

            // Redirect the admin to the previous page
            Response.Redirect("enquiryStaff.aspx");
        }
    }
}