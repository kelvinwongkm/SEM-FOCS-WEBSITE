using System;
using System.Configuration;
using System.Data.SqlClient;

namespace SEAM_Assignment.EnquiryModule
{
    public partial class enquiryUserView : System.Web.UI.Page
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

                    // Fetch and display the reply for the selected enquiry
                    DisplayEnquiryReply(enquiryId);
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
                string query = "SELECT [Id], [subject], [description], [timeStamp], [status], [userId] " +
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
                            int userID = reader.GetInt32(reader.GetOrdinal("UserId"));

                            // Display the enquiry details on the page
                            enqIDulbl.Text = id.ToString();
                            enqSubjectulbl.Text = subject;
                            enqDesculbl.Text = description;
                            utimeLbl.Text = timeStamp.ToString("MM/dd/yyyy HH:mm:ss");
                            enqStatusulbl.Text = status.ToUpper();
                            //enqUserIdlbl.Text = userId;
                        }
                        else
                        {
                            // Display a message indicating that the enquiry was not found
                            enqIDulbl.Text = "Enquiry not found.";
                        }
                    }
                }
            }
        }

        private void DisplayEnquiryReply(int enquiryId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define a SQL query to retrieve the reply for the selected enquiry by its ID
                string query = "SELECT [ReplyText], [ReplyTime], [adminid] FROM [EnquiryReply] WHERE [EnquiryId] = @EnquiryId";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Add the parameter for the enquiryId
                    cmd.Parameters.AddWithValue("@EnquiryId", enquiryId);

                    // Execute the query to retrieve the reply
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Get the reply text and the reply time
                        string replyText = reader["ReplyText"].ToString();
                        DateTime? replyTime = reader.IsDBNull(reader.GetOrdinal("ReplyTime")) ? null : (DateTime?)reader["ReplyTime"];
                        string adminid = reader["adminid"].ToString();

                        // Display the reply text and the reply time
                        enqReplyulbl.Text = replyText;
                        replyTimelbl.Text = "Replied on: " + replyTime.Value.ToString();
                        handledbylbl.Text = "Handled by (Admin ID): " + adminid;

                    }
                    else
                    {
                        // Display a message if no reply is found
                        enqReplyulbl.Text = "Pending on the admin reply. Please come back within 2 to 3 working days.";
                        replyTimelbl.Text = "";
                        handledbylbl.Text = "";
                    }
                }
            }
        }
    }
}