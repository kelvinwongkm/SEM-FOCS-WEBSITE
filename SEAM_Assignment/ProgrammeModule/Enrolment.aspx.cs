using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SEAM_Assignment.ProgrammeModule
{
    public partial class Enrolment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            readDatabase();
            if (!IsPostBack) {
                if (txtLevel.Text == "Diploma")
                {
                    ddlProgramme.Items.Add(new ListItem("Select Programme"));
                    ddlProgramme.Items.Add(new ListItem("DIPLOMA IN COMPUTER SCIENCE"));
                    ddlProgramme.Items.Add(new ListItem("DIPLOMA IN INFORMATION TECHNOLOGY"));
                    ddlProgramme.Items.Add(new ListItem("DIPLOMA IN SOFTWARE ENGINEERING"));
                }
                else
                {
                    ddlProgramme.Items.Add(new ListItem("Select Programme"));
                    ddlProgramme.Items.Add(new ListItem("BACHELOR IN MANAGEMENT MATHEMATICS WITH COMPUTING"));
                    ddlProgramme.Items.Add(new ListItem("BACHELOR IN DATA SCIENCE"));
                    ddlProgramme.Items.Add(new ListItem("BACHELOR IN ENTERPRISE INFORMATION SYSTEM"));
                }
            }
        }

        private void checkIntake()
        {
            //Intake
            if (ddlIntake.SelectedIndex == 0 || string.IsNullOrEmpty(ddlIntake.SelectedValue))
            {
                lblIntakeError.Visible = true;
            }
            else
            {
                lblIntakeError.Visible = false; // Make the label invisible
            }
        }

        private void checkCampus()
        {
            //Campus
            if (ddlCampus.SelectedIndex == 0 || string.IsNullOrEmpty(ddlCampus.SelectedValue))
            {
                lblCampusError.Visible = true;
            }
            else
            {
                lblCampusError.Visible = false; // Make the label invisible
            }
        }

        private void checkProgramme()
        {
            //Programme
            if (ddlProgramme.SelectedIndex == 0 || string.IsNullOrEmpty(ddlProgramme.SelectedValue))
            {
                lblProgrammeError.Visible = true;
            }
            else
            {
                lblProgrammeError.Visible = false; // Make the label invisible
            }
        }

        private void updateDatabase(string status)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //int studentId = 1;
                int studentId = (int)Session["user_id"]; // Replace with the actual student ID
                string newStatus = status; // Replace with the actual new status

                string query = "UPDATE Qualification SET enrol_status = @new_status WHERE student_id = @student_id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@new_status", newStatus);
                    command.Parameters.AddWithValue("@student_id", studentId);

                    command.ExecuteNonQuery();
                }
            }

        }
        private void readDatabase()
        {
            TextBox[] txtSub = {
        txtSub1, txtSub2, txtSub3, txtSub4, txtSub5,
        txtSub6, txtSub7, txtSub8, txtSub9, txtSub10, txtSub11, txtSub12
    };

            TextBox[] txtGra = {
        txtGra1, txtGra2, txtGra3, txtGra4, txtGra5,
        txtGra6, txtGra7, txtGra8, txtGra9, txtGra10, txtGra11, txtGra12
    };

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //int studentId = 1;
                int studentId = (int)Session["user_id"]; // Replace with the actual student ID
                string query = "SELECT * FROM Qualification WHERE student_id = @student_id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@student_id", studentId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Access the columns using reader["column_name"] or reader[column_index]
                            txtLevel.Text = (string)reader["level"];
                            txtQua.Text = (string)reader["qua"];

                            if (txtQua.Text == "Diploma")
                            {
                                myTable.Visible = false;
                                lblCGPA.Visible = true;
                                txtCGPA.Visible = true;
                                txtCGPA.Text = reader["cgpa"].ToString();
                            }
                            else
                            {
                                myTable.Visible = true;
                                lblCGPA.Visible = false;
                                txtCGPA.Visible = false;
                                txtSub1.Text = (string)reader["subject1"];
                                txtGra1.Text = (string)reader["grade1"];

                                txtSub2.Text = (string)reader["subject2"];
                                txtGra2.Text = (string)reader["grade2"];

                                txtSub3.Text = (string)reader["subject3"];
                                txtGra3.Text = (string)reader["grade3"];

                                txtSub4.Text = (string)reader["subject4"];
                                txtGra4.Text = (string)reader["grade4"];

                                txtSub5.Text = (string)reader["subject5"];
                                txtGra5.Text = (string)reader["grade5"];

                                txtSub6.Text = (string)reader["subject6"];
                                txtGra6.Text = (string)reader["grade6"];

                                txtSub7.Text = (string)reader["subject7"];
                                txtGra7.Text = (string)reader["grade7"];

                                txtSub8.Text = (string)reader["subject8"];
                                txtGra8.Text = (string)reader["grade8"];

                                txtSub9.Text = (string)reader["subject9"];
                                txtGra9.Text = (string)reader["grade9"];

                                txtSub10.Text = (string)reader["subject10"];
                                txtGra10.Text = (string)reader["grade10"];

                                txtSub11.Text = (string)reader["subject11"];
                                txtGra11.Text = (string)reader["grade11"];

                                txtSub12.Text = (string)reader["subject12"];
                                txtGra12.Text = (string)reader["grade12"];

                                for (int i = 0; i < 12; i++)
                                {
                                    if (txtSub[i].Text == "Select Subject")
                                    {
                                        txtSub[i].Text = "-";
                                    }

                                    if (txtGra[i].Text == "Select Grade")
                                    {
                                        txtGra[i].Text = "-";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int countCAndAbove = 0;
            bool hasMatematikTambahanWithCredit = false;
            bool allFieldSelected = false;

            TextBox[] subjectLists = {
        txtSub1, txtSub2, txtSub3, txtSub4, txtSub5,
        txtSub6, txtSub7, txtSub8, txtSub9, txtSub10, txtSub11, txtSub12
    };

            TextBox[] gradeLists = {
        txtGra1, txtGra2, txtGra3, txtGra4, txtGra5,
        txtGra6, txtGra7, txtGra8, txtGra9, txtGra10, txtGra11, txtGra12
    };

            for (int i = 0; i < gradeLists.Length; i++)
            {
                TextBox subjectTXT = subjectLists[i];
                TextBox gradeTXT = gradeLists[i];

                if (gradeTXT.Text == "A" || gradeTXT.Text == "B" || gradeTXT.Text == "C")
                {
                    countCAndAbove++;
                }

                // Check if Matematik Tambahan is selected with at least a grade of "C"
                if (subjectTXT.Text == "Matematik Tambahan" && (gradeTXT.Text == "A" || gradeTXT.Text == "B" || gradeTXT.Text == "C"))
                {
                    hasMatematikTambahanWithCredit = true;
                }
            }

            //Check
            if (ddlIntake.SelectedIndex == 0 || string.IsNullOrEmpty(ddlIntake.SelectedValue) ||
                ddlCampus.SelectedIndex == 0 || string.IsNullOrEmpty(ddlCampus.SelectedValue) ||
                ddlProgramme.SelectedIndex == 0 || string.IsNullOrEmpty(ddlProgramme.SelectedValue))
            {
                allFieldSelected = false;
            }
            else
            {
                allFieldSelected = true;
            }

            if (!allFieldSelected)
            {
                checkIntake();
                checkCampus();
                checkProgramme();
            }
            else
            {
                if (txtQua.Text == "Diploma")
                {
                    if (double.TryParse(txtCGPA.Text, out double cgpa))
                    {
                        if (cgpa >= 2.5 && cgpa <= 4)
                        {
                            // Register the script to show the pop-up
                            updateDatabase("Accepted");
                            Response.Redirect("EnrolmentAccept.aspx");
                        }
                        else
                        {
                            Session["ErrorMsg"] = "You're required to achieve 2.5 or above for cgpa!";
                            // Do something if the condition is not met
                            updateDatabase("Rejected");
                            Response.Redirect("EnrolmentReject.aspx");
                        }
                    }
                }
                else
                {
                    if (txtLevel.Text == "Diploma")
                    {
                        if (ddlProgramme.SelectedItem.Value == "DIPLOMA IN COMPUTER SCIENCE")
                        {
                            if (countCAndAbove >= 3 && hasMatematikTambahanWithCredit)
                            {
                                // Register the script to show the pop-up
                                updateDatabase("Accepted");
                                Response.Redirect("EnrolmentAccept.aspx");
                            }
                            else
                            {
                                Session["ErrorMsg"] = "You're required to have at least 3 credit (including Add Math)!";
                                // Do something if the condition is not met
                                updateDatabase("Rejected");
                                Response.Redirect("EnrolmentReject.aspx");
                            }
                        }
                        else
                        {
                            if (countCAndAbove >= 3)
                            {
                                // Register the script to show the pop-up
                                updateDatabase("Accepted");
                                Response.Redirect("EnrolmentAccept.aspx");
                            }
                            else
                            {
                                Session["ErrorMsg"] = "You're required to have at least 3 credit!";
                                // Do something if the condition is not met
                                updateDatabase("Rejected");
                                Response.Redirect("EnrolmentReject.aspx");
                            }
                        }
                    }
                    else
                    {
                        if (countCAndAbove >= 5)
                        {
                            // Register the script to show the pop-up
                            updateDatabase("Accepted");
                            Response.Redirect("EnrolmentAccept.aspx");
                        }
                        else
                        {
                            Session["ErrorMsg"] = "You're required to have at least 5 credit!";
                            // Do something if the condition is not met
                            updateDatabase("Rejected");
                            Response.Redirect("EnrolmentReject.aspx");
                        }
                    }
                }
            }
        }

        protected void ddlIntake_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIntake();
        }
        protected void ddlCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIntake();
            checkCampus();
        }

        protected void ddlProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIntake();
            checkCampus();
            checkProgramme();
        }
    }
}