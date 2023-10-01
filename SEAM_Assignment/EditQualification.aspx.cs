using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SEAM_Assignment
{
    public partial class EditQualification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                readDatabase();
            }
        }

        private void checkQua() {
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
        }
        private void readDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //int studentId = 2;
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
                            ddlLevel.SelectedValue = (string)reader["level"];

                            checkQua();

                            ddlQua.SelectedValue = (string)reader["qua"];

                            if (ddlQua.SelectedValue == "Diploma")
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
                                ddlSub1.SelectedValue = (string)reader["subject1"];
                                ddlGra1.SelectedValue = (string)reader["grade1"];

                                ddlSub2.SelectedValue = (string)reader["subject2"];
                                ddlGra2.SelectedValue = (string)reader["grade2"];

                                ddlSub3.SelectedValue = (string)reader["subject3"];
                                ddlGra3.SelectedValue = (string)reader["grade3"];

                                ddlSub4.SelectedValue = (string)reader["subject4"];
                                ddlGra4.SelectedValue = (string)reader["grade4"];

                                ddlSub5.SelectedValue = (string)reader["subject5"];
                                ddlGra5.SelectedValue = (string)reader["grade5"];

                                ddlSub6.SelectedValue = (string)reader["subject6"];
                                ddlGra6.SelectedValue = (string)reader["grade6"];

                                ddlSub7.SelectedValue = (string)reader["subject7"];
                                ddlGra7.SelectedValue = (string)reader["grade7"];

                                ddlSub8.SelectedValue = (string)reader["subject8"];
                                ddlGra8.SelectedValue = (string)reader["grade8"];

                                ddlSub9.SelectedValue = (string)reader["subject9"];
                                ddlGra9.SelectedValue = (string)reader["grade9"];

                                ddlSub10.SelectedValue = (string)reader["subject10"];
                                ddlGra10.SelectedValue = (string)reader["grade10"];

                                ddlSub11.SelectedValue = (string)reader["subject11"];
                                ddlGra11.SelectedValue = (string)reader["grade11"];

                                ddlSub12.SelectedValue = (string)reader["subject12"];
                                ddlGra12.SelectedValue = (string)reader["grade12"];
                            }
                        }
                    }
                }
            }
        }
        private void updateDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //int studentId = 2; // Replace with the actual student ID
                int studentId = (int)Session["user_id"]; // Replace with the actual student ID
                string level = ddlLevel.SelectedValue;
                string qua = ddlQua.SelectedValue;

                string subject1 = ddlSub1.SelectedItem.Value;
                string grade1 = ddlGra1.SelectedItem.Value;

                string subject2 = ddlSub2.SelectedItem.Value;
                string grade2 = ddlGra2.SelectedItem.Value;

                string subject3 = ddlSub3.SelectedItem.Value;
                string grade3 = ddlGra3.SelectedItem.Value;

                string subject4 = ddlSub4.SelectedItem.Value;
                string grade4 = ddlGra4.SelectedItem.Value;

                string subject5 = ddlSub5.SelectedItem.Value;
                string grade5 = ddlGra5.SelectedItem.Value;

                string subject6 = ddlSub6.SelectedItem.Value;
                string grade6 = ddlGra6.SelectedItem.Value;

                string subject7 = ddlSub7.SelectedItem.Value;
                string grade7 = ddlGra7.SelectedItem.Value;

                string subject8 = ddlSub8.SelectedItem.Value;
                string grade8 = ddlGra8.SelectedItem.Value;

                string subject9 = ddlSub9.SelectedItem.Value;
                string grade9 = ddlGra9.SelectedItem.Value;

                string subject10 = ddlSub10.SelectedItem.Value;
                string grade10 = ddlGra10.SelectedItem.Value;

                string subject11 = ddlSub11.SelectedItem.Value;
                string grade11 = ddlGra11.SelectedItem.Value;

                string subject12 = ddlSub12.SelectedItem.Value;
                string grade12 = ddlGra12.SelectedItem.Value;

                string query = @"
        UPDATE [dbo].[Qualification]
        SET
            [level] = @level,
            [qua] = @qua,
            [enrol_status] = @enrol_status,
            [cgpa] = @cgpa,
            [subject1] = @subject1,
            [grade1] = @grade1,
            [subject2] = @subject2,
            [grade2] = @grade2,
            [subject3] = @subject3,
            [grade3] = @grade3,
            [subject4] = @subject4,
            [grade4] = @grade4,
            [subject5] = @subject5,
            [grade5] = @grade5,
            [subject6] = @subject6,
            [grade6] = @grade6,
            [subject7] = @subject7,
            [grade7] = @grade7,
            [subject8] = @subject8,
            [grade8] = @grade8,
            [subject9] = @subject9,
            [grade9] = @grade9,
            [subject10] = @subject10,
            [grade10] = @grade10,
            [subject11] = @subject11,
            [grade11] = @grade11,
            [subject12] = @subject12,
            [grade12] = @grade12
        WHERE
            [student_id] = @student_id
    ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@student_id", studentId);
                    command.Parameters.AddWithValue("@level", level);
                    command.Parameters.AddWithValue("@qua", qua);
                    command.Parameters.AddWithValue("@enrol_status", "Pending");

                    if (txtCGPA.Text == "-1")
                    {
                        command.Parameters.AddWithValue("@cgpa", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@cgpa", txtCGPA.Text);
                    }

                    command.Parameters.AddWithValue("@subject1", subject1);
                    command.Parameters.AddWithValue("@grade1", grade1);

                    command.Parameters.AddWithValue("@subject2", subject2);
                    command.Parameters.AddWithValue("@grade2", grade2);

                    command.Parameters.AddWithValue("@subject3", subject3);
                    command.Parameters.AddWithValue("@grade3", grade3);

                    command.Parameters.AddWithValue("@subject4", subject4);
                    command.Parameters.AddWithValue("@grade4", grade4);

                    command.Parameters.AddWithValue("@subject5", subject5);
                    command.Parameters.AddWithValue("@grade5", grade5);

                    command.Parameters.AddWithValue("@subject6", subject6);
                    command.Parameters.AddWithValue("@grade6", grade6);

                    command.Parameters.AddWithValue("@subject7", subject7);
                    command.Parameters.AddWithValue("@grade7", grade7);

                    command.Parameters.AddWithValue("@subject8", subject8);
                    command.Parameters.AddWithValue("@grade8", grade8);

                    command.Parameters.AddWithValue("@subject9", subject9);
                    command.Parameters.AddWithValue("@grade9", grade9);

                    command.Parameters.AddWithValue("@subject10", subject10);
                    command.Parameters.AddWithValue("@grade10", grade10);

                    command.Parameters.AddWithValue("@subject11", subject11);
                    command.Parameters.AddWithValue("@grade11", grade11);

                    command.Parameters.AddWithValue("@subject12", subject12);
                    command.Parameters.AddWithValue("@grade12", grade12);

                    command.ExecuteNonQuery();
                }
            }

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
        private void resetSubGra()
        {
            ddlSub1.SelectedValue = "Select Subject";
            ddlSub2.SelectedValue = "Select Subject";
            ddlSub3.SelectedValue = "Select Subject";
            ddlSub4.SelectedValue = "Select Subject";
            ddlSub5.SelectedValue = "Select Subject";
            ddlSub6.SelectedValue = "Select Subject";
            ddlSub7.SelectedValue = "Select Subject";
            ddlSub8.SelectedValue = "Select Subject";
            ddlSub9.SelectedValue = "Select Subject";
            ddlSub10.SelectedValue = "Select Subject";
            ddlSub11.SelectedValue = "Select Subject";
            ddlSub12.SelectedValue = "Select Subject";

            ddlGra1.SelectedValue = "Select Grade";
            ddlGra2.SelectedValue = "Select Grade";
            ddlGra3.SelectedValue = "Select Grade";
            ddlGra4.SelectedValue = "Select Grade";
            ddlGra5.SelectedValue = "Select Grade";
            ddlGra6.SelectedValue = "Select Grade";
            ddlGra7.SelectedValue = "Select Grade";
            ddlGra8.SelectedValue = "Select Grade";
            ddlGra9.SelectedValue = "Select Grade";
            ddlGra10.SelectedValue = "Select Grade";
            ddlGra11.SelectedValue = "Select Grade";
            ddlGra12.SelectedValue = "Select Grade";
        }

        private void resetCGPA()
        {
            txtCGPA.Text = "-1";
        }
        protected void btnSave_Click(object sender, EventArgs e)
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
                            resetSubGra();
                            updateDatabase();
                            Response.Redirect("Profile.aspx");
                        }
                        else if (cgpa < 0 || cgpa > 4)
                        {
                            lblCGPAError.Visible = true;
                            lblCGPAError.Text = "Please enter a valid CGPA";
                        }
                        else
                        {
                            resetSubGra();
                            updateDatabase();
                            Response.Redirect("Profile.aspx");
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
                        resetCGPA();
                        updateDatabase();
                        Response.Redirect("Profile.aspx");
                    }
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}