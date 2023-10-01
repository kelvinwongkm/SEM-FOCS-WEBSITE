using System;
using System.Configuration;
using System.Data.SqlClient;

namespace SEAM_Assignment.ProgrammeModule
{
    public partial class ProgramInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (int.TryParse(Request.QueryString["ID"], out int id))
            {

                // Use the ID to load and display the corresponding information
                LoadInfoById(id);
            }
        }

        private void LoadInfoById(int id)
        {
            if (!IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                string connectionString = constr; //replace with your connection string
                string query = "SELECT* FROM PROGRAM WHERE dbo.Program.program_id = @id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string title = reader["program_title"].ToString();
                        string duration = reader["program_duration"].ToString();
                        string campuses = reader["program_campuses"].ToString();
                        string intake = reader["program_intake"].ToString();
                        string estimatedFees = reader["program_estimatedFees"].ToString();
                        string overview = reader["program_overview"].ToString();
                        string qualifications = reader["program_qualifications"].ToString();

                        //set the product details to your label controls
                        //lblStaffName.Text = staffName;
                        programTitle.Text = title;
                        programOverviewLbl.Text = overview;
                        programDurationLbl.Text = duration;
                        programCampusesLbl.Text = campuses;
                        programIntakeLbl.Text = intake;
                        estimatedFeesLbl.Text = "RM " + estimatedFees;

                        qualificationImg.ImageUrl = qualifications;
                    }
                    else
                    {
                        Response.Write("Program not found for the given primary key: " + id);
                    }
                    reader.Close();
                }

            }
        }
    }
}