using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace SEAM_Assignment
{
    public partial class compareProgrammes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate initial data in ddlProgramme
                PopulateProgrammeDropDown();

            }
        }
        protected void ddlLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateProgrammeDropDown();
        }

        private void PopulateProgrammeDropDown()
        {
            string selectedLevel = ddlLevel.SelectedValue;

            ddlCompare1.Items.Clear();
            ddlCompare2.Items.Clear();

            if (selectedLevel == "Diploma")
            {
                ddlCompare1.Items.Add(new ListItem("Select Programme", 0.ToString()));
                ddlCompare1.Items.Add(new ListItem("DIPLOMA IN COMPUTER SCIENCE", 4.ToString()));
                ddlCompare1.Items.Add(new ListItem("DIPLOMA IN INFORMATION TECHNOLOGY", 5.ToString()));
                ddlCompare1.Items.Add(new ListItem("DIPLOMA IN SOFTWARE ENGINEERING", 6.ToString()));

                ddlCompare2.Items.Add(new ListItem("Select Programme", 0.ToString()));
                ddlCompare2.Items.Add(new ListItem("DIPLOMA IN COMPUTER SCIENCE", 4.ToString()));
                ddlCompare2.Items.Add(new ListItem("DIPLOMA IN INFORMATION TECHNOLOGY", 5.ToString()));
                ddlCompare2.Items.Add(new ListItem("DIPLOMA IN SOFTWARE ENGINEERING", 6.ToString()));
            }
            else if (selectedLevel == "Bachelor")
            {
                ddlCompare1.Items.Add(new ListItem("Select Programme", 0.ToString()));
                ddlCompare1.Items.Add(new ListItem("BACHELOR DEGREE IN MANAGEMENT MATHEMATICS WITH COMPUTING", 1.ToString()));
                ddlCompare1.Items.Add(new ListItem("BACHELOR DEGREE IN DATA SCIENCE", 2.ToString()));
                ddlCompare1.Items.Add(new ListItem("BACHELOR DEGREE IN ENTERPRISE INFORMATION SYSTEM", 3.ToString()));

                ddlCompare2.Items.Add(new ListItem("Select Programme", 0.ToString()));
                ddlCompare2.Items.Add(new ListItem("BACHELOR DEGREE IN MANAGEMENT MATHEMATICS WITH COMPUTING", 1.ToString()));
                ddlCompare2.Items.Add(new ListItem("BACHELOR DEGREE IN DATA SCIENCE", 2.ToString()));
                ddlCompare2.Items.Add(new ListItem("BACHELOR DEGREE IN ENTERPRISE INFORMATION SYSTEM", 3.ToString()));
            }
            else
            {
                ddlCompare1.Items.Add(new ListItem("Select Programme", 0.ToString()));
                ddlCompare2.Items.Add(new ListItem("Select Programme", 0.ToString()));
            }
        }

        protected void btnCompare_Click(object sender, EventArgs e)
        {
            if (ddlLevel.SelectedItem.Value == "Select Level")
            {
                string script = "alert('You are required to select a level!');";
                ClientScript.RegisterStartupScript(this.GetType(), "PopupScript", script, true);
            }
            else if (ddlCompare1.SelectedItem.Value == "0")
            {
                string script = "alert('You are required to select a programme!');";
                ClientScript.RegisterStartupScript(this.GetType(), "PopupScript", script, true);
            }
            else if (ddlCompare2.SelectedItem.Value == "0")
            {
                string script = "alert('You are required to select a programme!');";
                ClientScript.RegisterStartupScript(this.GetType(), "PopupScript", script, true);
            }
            else if (ddlCompare1.SelectedItem.Value == ddlCompare2.SelectedItem.Value)
            {
                string script = "alert('You are required to select 2 different programme!');";
                ClientScript.RegisterStartupScript(this.GetType(), "PopupScript", script, true);
            }
            else
            {
                if (int.TryParse((ddlCompare1.SelectedItem.Value), out int id1))
                {
                    LoadInfoById1(id1);
                }

                if (int.TryParse((ddlCompare2.SelectedItem.Value), out int id2))
                {
                    LoadInfoById2(id2);
                }
            }

        }



        private void LoadInfoById1(int id)
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string connectionString = constr; //replace with your connection string

            string query1 = "SELECT* FROM PROGRAM WHERE dbo.Program.program_id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query1, connection);
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

                    //set the product details to your label controls
                    programlbl1.Text = title;
                    duration1.Text = duration;
                    campuses1.Text = campuses;
                    intake1.Text = intake;
                    estimatedFees1.Text = "RM" + string.Format("{0:0.00}", estimatedFees);


                }
                else
                {
                    Response.Write("Program not found for the given primary key: " + id);
                }
                reader.Close();

            }


        }

        private void LoadInfoById2(int id)
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string connectionString = constr; //replace with your connection string

            string query1 = "SELECT* FROM PROGRAM WHERE dbo.Program.program_id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query1, connection);
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

                    //set the product details to your label controls
                    programlbl2.Text = title;
                    duration2.Text = duration;
                    campuses2.Text = campuses;
                    intake2.Text = intake;
                    estimatedFees2.Text = "RM" + estimatedFees;



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


