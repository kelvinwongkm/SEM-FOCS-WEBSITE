using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SEAM_Assignment.AuthenticationModule
{
    public partial class qualification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ddlLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCGPAError.Visible = false;
            lblError.Visible = false;
            ddlQua.Items.Clear();

            if (ddlLevel.SelectedValue == "Diploma")
            {
                ddlQua.Items.Add(new ListItem("Select Qualification"));
                ddlQua.Items.Add(new ListItem("SPM"));
                ddlQua.Items.Add(new ListItem("O Level"));
                ddlQua.Items.Add(new ListItem("UEC"));
            }
            else if (ddlLevel.SelectedValue == "Bachelor")
            {
                ddlQua.Items.Add(new ListItem("Select Qualification"));
                ddlQua.Items.Add(new ListItem("STPM"));
                ddlQua.Items.Add(new ListItem("A Level"));
                ddlQua.Items.Add(new ListItem("Diploma"));
            }
            else
            {
                ddlQua.Items.Add(new ListItem("Select Qualification"));
            }

            if (ddlQua.SelectedValue == "Diploma")
            {
                lblCGPA.Visible = true;
                txtCGPA.Visible = true;
                myTable.Visible = false;
            }
            else if (ddlQua.SelectedIndex == 0 || string.IsNullOrEmpty(ddlQua.SelectedValue))
            {
                lblCGPA.Visible = false;
                txtCGPA.Text = "";
                txtCGPA.Visible = false;
                myTable.Visible = false;
            }
            else
            {
                lblCGPA.Visible = false;
                txtCGPA.Text = "";
                txtCGPA.Visible = false;
                myTable.Visible = true;
            }
        }
        protected void ddlQua_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCGPAError.Visible = false;
            lblError.Visible = false;
            if (ddlQua.SelectedValue == "Diploma")
            {
                lblCGPA.Visible = true;
                txtCGPA.Visible = true;
                myTable.Visible = false;
            }
            else if (ddlQua.SelectedIndex == 0 || string.IsNullOrEmpty(ddlQua.SelectedValue))
            {
                lblCGPA.Visible = false;
                txtCGPA.Text = "";
                txtCGPA.Visible = false;
                myTable.Visible = false;
            }
            else
            {
                lblCGPA.Visible = false;
                txtCGPA.Text = "";
                txtCGPA.Visible = false;
                myTable.Visible = true;
            }
        }

        private void insertDatabase(string level, string qua, float cgpa,
            string subject1, string grade1, string subject2, string grade2, string subject3, string grade3,
            string subject4, string grade4, string subject5, string grade5, string subject6, string grade6,
            string subject7, string grade7, string subject8, string grade8, string subject9, string grade9,
            string subject10, string grade10, string subject11, string grade11, string subject12, string grade12)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            int studentID = (int)Session["user_id"]; ;

            // Define the SQL query to insert the reply into the database and update the status
            string insertQuery = "INSERT INTO Qualification (student_id, level, qua, enrol_status, cgpa, " +
                                "subject1, grade1, subject2, grade2, subject3, grade3, subject4, grade4, subject5, grade5, subject6, grade6, " +
                                "subject7, grade7, subject8, grade8, subject9, grade9, subject10, grade10, subject11, grade11, subject12, grade12) " +
                                "VALUES (@student_id, @level, @qua, @enrol_status, @cgpa, " +
                                "@subject1, @grade1, @subject2, @grade2, @subject3, @grade3, @subject4, @grade4, @subject5, @grade5, @subject6, @grade6, " +
                                "@subject7, @grade7, @subject8, @grade8, @subject9, @grade9, @subject10, @grade10, @subject11, @grade11, @subject12, @grade12)";

            // Create a SqlConnection and SqlCommand
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                // Add parameters to the SqlCommand
                command.Parameters.AddWithValue("@student_id", studentID);
                command.Parameters.AddWithValue("@level", level); // Replace with actual level
                command.Parameters.AddWithValue("@qua", qua); // Replace with actual qualification
                command.Parameters.AddWithValue("@enrol_status", "Pending"); // Replace with actual qualification

                if (cgpa == -1)
                {
                    command.Parameters.AddWithValue("@cgpa", DBNull.Value); // Replace with actual CGPA
                }
                else
                {
                    command.Parameters.AddWithValue("@cgpa", cgpa); // Replace with actual CGPA
                }

                command.Parameters.AddWithValue("@subject1", subject1); // Replace with actual subjects and grades
                command.Parameters.AddWithValue("@grade1", grade1);

                command.Parameters.AddWithValue("@subject2", subject2); // Replace with actual subjects and grades
                command.Parameters.AddWithValue("@grade2", grade2);

                command.Parameters.AddWithValue("@subject3", subject3); // Replace with actual subjects and grades
                command.Parameters.AddWithValue("@grade3", grade3);

                command.Parameters.AddWithValue("@subject4", subject4); // Replace with actual subjects and grades
                command.Parameters.AddWithValue("@grade4", grade4);

                command.Parameters.AddWithValue("@subject5", subject5); // Replace with actual subjects and grades
                command.Parameters.AddWithValue("@grade5", grade5);

                command.Parameters.AddWithValue("@subject6", subject6); // Replace with actual subjects and grades
                command.Parameters.AddWithValue("@grade6", grade6);

                command.Parameters.AddWithValue("@subject7", subject7); // Replace with actual subjects and grades
                command.Parameters.AddWithValue("@grade7", grade7);

                command.Parameters.AddWithValue("@subject8", subject8); // Replace with actual subjects and grades
                command.Parameters.AddWithValue("@grade8", grade8);

                command.Parameters.AddWithValue("@subject9", subject9); // Replace with actual subjects and grades
                command.Parameters.AddWithValue("@grade9", grade9);

                command.Parameters.AddWithValue("@subject10", subject10); // Replace with actual subjects and grades
                command.Parameters.AddWithValue("@grade10", grade10);

                command.Parameters.AddWithValue("@subject11", subject11); // Replace with actual subjects and grades
                command.Parameters.AddWithValue("@grade11", grade11);

                command.Parameters.AddWithValue("@subject12", subject12); // Replace with actual subjects and grades
                command.Parameters.AddWithValue("@grade12", grade12);

                // Open the connection and execute the query
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void checkLevel()
        {
            //Level
            if (ddlLevel.SelectedIndex == 0 || string.IsNullOrEmpty(ddlLevel.SelectedValue))
            {
                lblLevelError.Visible = true;
            }
            else
            {
                lblLevelError.Visible = false; // Make the label invisible
            }
        }

        private void checkQualification()
        {
            //Qualification
            if (ddlQua.SelectedIndex == 0 || string.IsNullOrEmpty(ddlQua.SelectedValue))
            {
                lblQuaError.Visible = true;
            }
            else
            {
                lblQuaError.Visible = false; // Make the label invisible
            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            bool allFieldSelected = false;
            bool atLeastOneSelected = false;
            bool subjectNotSelected = false;
            bool gradeNotSelected = false;

            DropDownList[] subject = {
                ddlSub1, ddlSub2, ddlSub3, ddlSub4, ddlSub5,
                ddlSub6, ddlSub7, ddlSub8, ddlSub9, ddlSub10, ddlSub11, ddlSub12
            };

            DropDownList[] grade = {
                ddlGra1, ddlGra2, ddlGra3, ddlGra4, ddlGra5,
                ddlGra6, ddlGra7, ddlGra8, ddlGra9, ddlGra10, ddlGra11, ddlGra12
            };

            for (int i = 0; i < grade.Length; i++)
            {
                DropDownList subjectDDL = subject[i];
                DropDownList gradeDDL = grade[i];

                if (subjectDDL.SelectedItem.Value != "Select Subject" && gradeDDL.SelectedItem.Value != "Select Grade")
                {
                    atLeastOneSelected = true;
                }

                if (subjectDDL.SelectedItem.Value != "Select Subject")
                {
                    if (gradeDDL.SelectedItem.Value == "Select Grade")
                    {
                        gradeNotSelected = true;
                    }
                }

                if (gradeDDL.SelectedItem.Value != "Select Grade")
                {
                    if (subjectDDL.SelectedItem.Value == "Select Subject")
                    {
                        subjectNotSelected = true;
                    }
                }
            }

            //Check
            if (ddlLevel.SelectedIndex == 0 || string.IsNullOrEmpty(ddlLevel.SelectedValue) ||
                ddlQua.SelectedIndex == 0 || string.IsNullOrEmpty(ddlQua.SelectedValue))
            {
                allFieldSelected = false;
            }
            else
            {
                allFieldSelected = true;
            }

            //Check 2
            if (!allFieldSelected)
            {
                checkLevel();
                checkQualification();
            }
            else
            {
                if (ddlQua.SelectedItem.Value == "Diploma")
                {
                    if (float.TryParse(txtCGPA.Text, out float cgpa))
                    {
                        if (cgpa >= 2.5 && cgpa <= 4)
                        {
                            insertDatabase(ddlLevel.SelectedValue, ddlQua.SelectedValue, cgpa,
                            subject[0].SelectedItem.Value, grade[0].SelectedItem.Value,
                            subject[1].SelectedItem.Value, grade[1].SelectedItem.Value,
                            subject[2].SelectedItem.Value, grade[2].SelectedItem.Value,
                            subject[3].SelectedItem.Value, grade[3].SelectedItem.Value,
                            subject[4].SelectedItem.Value, grade[4].SelectedItem.Value,
                            subject[5].SelectedItem.Value, grade[5].SelectedItem.Value,
                            subject[6].SelectedItem.Value, grade[6].SelectedItem.Value,
                            subject[7].SelectedItem.Value, grade[7].SelectedItem.Value,
                            subject[8].SelectedItem.Value, grade[8].SelectedItem.Value,
                            subject[9].SelectedItem.Value, grade[9].SelectedItem.Value,
                            subject[10].SelectedItem.Value, grade[10].SelectedItem.Value,
                            subject[11].SelectedItem.Value, grade[11].SelectedItem.Value);
                            Response.Redirect("/Home.aspx");
                        }
                        else if (cgpa < 0 || cgpa > 4)
                        {
                            lblCGPAError.Visible = true;
                            lblCGPAError.Text = "Please enter a valid CGPA";
                        }
                        else
                        {
                            insertDatabase(ddlLevel.SelectedValue, ddlQua.SelectedValue, cgpa,
                            subject[0].SelectedItem.Value, grade[0].SelectedItem.Value,
                            subject[1].SelectedItem.Value, grade[1].SelectedItem.Value,
                            subject[2].SelectedItem.Value, grade[2].SelectedItem.Value,
                            subject[3].SelectedItem.Value, grade[3].SelectedItem.Value,
                            subject[4].SelectedItem.Value, grade[4].SelectedItem.Value,
                            subject[5].SelectedItem.Value, grade[5].SelectedItem.Value,
                            subject[6].SelectedItem.Value, grade[6].SelectedItem.Value,
                            subject[7].SelectedItem.Value, grade[7].SelectedItem.Value,
                            subject[8].SelectedItem.Value, grade[8].SelectedItem.Value,
                            subject[9].SelectedItem.Value, grade[9].SelectedItem.Value,
                            subject[10].SelectedItem.Value, grade[10].SelectedItem.Value,
                            subject[11].SelectedItem.Value, grade[11].SelectedItem.Value);
                            Response.Redirect("/Home.aspx");
                        }
                    }
                    else if (string.IsNullOrEmpty(txtCGPA.Text))
                    {
                        lblCGPAError.Visible = true;
                        lblCGPAError.Text = "Please enter your CGPA";
                    }
                    else
                    {
                        lblCGPAError.Visible = true;
                        lblCGPAError.Text = "Please enter a valid numeric value for CGPA";
                    }
                }
                else
                {
                    if (subjectNotSelected)
                    {
                        lblError.Visible = true;
                        lblError.Text = "You are required to choose a subject for grade selected!";
                    }
                    else if (gradeNotSelected)
                    {
                        lblError.Visible = true;
                        lblError.Text = "You are required to choose a grade for subject selected!";
                    }
                    else if (!atLeastOneSelected)
                    {
                        lblError.Visible = true;
                        lblError.Text = "At least one subject and grade level need to be selected!";
                    }
                    else
                    {
                        insertDatabase(ddlLevel.SelectedValue, ddlQua.SelectedValue, -1,
            subject[0].SelectedItem.Value, grade[0].SelectedItem.Value,
            subject[1].SelectedItem.Value, grade[1].SelectedItem.Value,
            subject[2].SelectedItem.Value, grade[2].SelectedItem.Value,
            subject[3].SelectedItem.Value, grade[3].SelectedItem.Value,
            subject[4].SelectedItem.Value, grade[4].SelectedItem.Value,
            subject[5].SelectedItem.Value, grade[5].SelectedItem.Value,
            subject[6].SelectedItem.Value, grade[6].SelectedItem.Value,
            subject[7].SelectedItem.Value, grade[7].SelectedItem.Value,
            subject[8].SelectedItem.Value, grade[8].SelectedItem.Value,
            subject[9].SelectedItem.Value, grade[9].SelectedItem.Value,
            subject[10].SelectedItem.Value, grade[10].SelectedItem.Value,
            subject[11].SelectedItem.Value, grade[11].SelectedItem.Value);
                        Response.Redirect("/Home.aspx");
                    }
                }
            }

        }
    }
}