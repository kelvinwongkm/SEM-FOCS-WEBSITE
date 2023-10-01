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
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            readStudentDatabase();
            readQualificationDatabase();
        }

        private void readStudentDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //int studentId = 2;
                int studentId = (int)Session["user_id"]; // Replace with the actual student ID
                string query = "SELECT * FROM Student WHERE student_id = @student_id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@student_id", studentId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Access the columns using reader["column_name"] or reader[column_index]
                            txtName.Text = (string)reader["student_name"];
                            txtEmail.Text = (string)reader["student_email"];
                        }
                    }
                }
            }

        }

        private void readQualificationDatabase()
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
                            txtStatus.Text = (string)reader["enrol_status"];
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

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditQualification.aspx");
        }
    }
}