using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public class EnquiryClass
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }

    public string Status { get; set; }
}

namespace SEAM_Assignment.EnquiryModule
{
    public partial class enquiryUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] != null)
            {
                int userId = Convert.ToInt32(Session["user_id"]);

                // Call the method to retrieve and display enquiries specific to the user
                RetrieveEnquiries(userId, "all");
            }
        }

        protected void ddlEnquiryStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["user_id"]);
            // Get the selected status from the DropDownList
            string selectedStatus = ddlEnquiryStatus.SelectedValue;

            // Call the method to retrieve and display enquiries based on the selected status.
            RetrieveEnquiries(userId, selectedStatus);
        }

        protected void addEnqBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("addEnquiry.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("enquiryStaff.aspx");
        }

        protected void RetrieveEnquiries(int userId, string statusFilter)
        {
            // Define a list or data structure to store the retrieved enquiries
            List<EnquiryClass> enquiries = new List<EnquiryClass>();

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
                            "WHERE [userId] = @UserId " +
                            "ORDER BY [status] desc, [timeStamp] DESC";
                }
                else
                {
                    // Retrieve enquiries based on the selected status
                    query = "SELECT [id], [subject], [timeStamp], [description], [status] " +
                            "FROM [Enquiry] " +
                            "WHERE [userId] = @UserId AND [status] = @Status " + // Add user-specific filter
                            "ORDER BY [timeStamp] DESC";
                }
                // Add parameter for status filter
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId); // Add user-specific parameter
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
                        }
                    }
                }
            }


            // Bind the retrieved data to the GridView or other controls on the page
            enquiryGV.DataSource = enquiries;
            enquiryGV.DataBind();
        }

        protected void enquiryGV_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int userId = Convert.ToInt32(Session["user_id"]);
            // Set the new page index
            enquiryGV.PageIndex = e.NewPageIndex;

            // Get the selected status from the DropDownList
            string selectedStatus = ddlEnquiryStatus.SelectedValue;

            // Rebind the GridView with data based on the selected status
            RetrieveEnquiries(userId, selectedStatus);
        }

        protected void enquiryGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = enquiryGV.SelectedIndex;

            if (selectedRowIndex >= 0)
            {
                int enquiryId = Convert.ToInt32(enquiryGV.DataKeys[selectedRowIndex].Value);

                // Redirect to the details page with the enquiryId as a query parameter
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
    }
}