using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace SEAM_Assignment.EnquiryModule
{
    public partial class enquiryStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Call the method to retrieve and display enquiries with the default "All" status.
                RetrieveEnquiries("all");
            }
        }
        protected void ddlEnquiryStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected status from the DropDownList
            string selectedStatus = ddlEnquiryStatus.SelectedValue;

            // Call the method to retrieve and display enquiries based on the selected status.
            RetrieveEnquiries(selectedStatus);
        }

        protected void RetrieveEnquiries(string statusFilter)
        {
            // Define a list or data structure to store the retrieved enquiries
            List<EnquiryClass> enquiries = new List<EnquiryClass>();

            // Initialize the count of pending processing enquiries
            int pendingProcessingCount = 0;

            // Establish a database connection using the connection string
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query;

                if (statusFilter == "all")
                {
                    // Retrieve all enquiries
                    query = "SELECT [id], [subject], [timeStamp], [description], [status] " +
                            "FROM [Enquiry] " +
                            "ORDER BY [status] desc, [timeStamp] DESC";
                }
                else
                {
                    // Retrieve enquiries based on the selected status
                    query = "SELECT [id], [subject], [timeStamp], [description], [status] " +
                            "FROM [Enquiry] " +
                            "WHERE [status] = @Status " +
                            "ORDER BY [timeStamp] DESC";
                }
                // Add parameter for status filter
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Status", statusFilter);

                    // Execute the query and populate the list of enquiries
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EnquiryClass enquiry = new EnquiryClass
                            {
                                Id = (int)reader["id"],
                                Subject = reader["subject"].ToString(),
                                Date = (DateTime)reader["timeStamp"],
                                Description = reader["description"].ToString(),
                                Status = reader["status"].ToString().ToUpper()
                            };

                            enquiries.Add(enquiry);

                            // Check if the enquiry is pending processing
                            if (enquiry.Status == "PROCESSING")
                            {
                                pendingProcessingCount++;
                            }
                        }
                    }
                }
            }

            // Bind the retrieved data to the GridView or other controls on the page
            enquiryGV.DataSource = enquiries;
            enquiryGV.DataBind();

            // Display the count of pending processing enquiries or a message for completed enquiries
            if (pendingProcessingCount == 0)
            {
                numOfProcessinglbl.Text = "All enquiries have been replied";
            }
            else
            {
                numOfProcessinglbl.Text = $"{pendingProcessingCount} enquiry(ies) pending on processing";
            }
        }


        protected void enquiryGV_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // Set the new page index
            enquiryGV.PageIndex = e.NewPageIndex;

            // Get the selected status from the DropDownList
            string selectedStatus = ddlEnquiryStatus.SelectedValue;

            // Rebind the GridView with data based on the selected status
            RetrieveEnquiries(selectedStatus);
        }

        protected void enquiryGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = enquiryGV.SelectedIndex;

            if (selectedRowIndex >= 0)
            {
                int enquiryId = Convert.ToInt32(enquiryGV.DataKeys[selectedRowIndex].Value);

                Boolean needReply = checkStatus(enquiryId);

                // Redirect to the details page with the enquiryId as a query parameter
                if (needReply)
                    Response.Redirect("enquiryStaffReply.aspx?enquiryId=" + enquiryId);
                else
                    Response.Redirect("enquiryUserView.aspx?enquiryId=" + enquiryId);



            }
        }

        protected void enquiryGV_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Get the GridView control
                GridView gridView = (GridView)sender;

                // Calculate the row number (1-based index)
                int rowNumber = (gridView.PageIndex * gridView.PageSize) + e.Row.RowIndex + 1;

                // Find the label in the row and set its text to the row number
                Label rowNumberLabel = (Label)e.Row.FindControl("lblRowNumber"); // Replace "lblRowNumber" with the ID of your label
                if (rowNumberLabel != null)
                {
                    rowNumberLabel.Text = rowNumber.ToString();
                }
            }
        }

        protected Boolean checkStatus(int enquiryId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define a SQL query to retrieve the details of the selected enquiry by its ID
                string query = "SELECT  [status] " +
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
                            string status = reader.GetString(reader.GetOrdinal("status"));
                            if (status.Equals("completed"))
                                return false;
                            else
                                return true;
                        }
                        return true;
                    }
                }
            }
        }
    }
}