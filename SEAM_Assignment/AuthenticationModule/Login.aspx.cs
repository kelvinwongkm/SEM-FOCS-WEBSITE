using System;
using System.Configuration;
using System.Data.SqlClient;

namespace SEAM_Assignment
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["student_email"] != null && Request.Cookies["student_email"] != null)
                {
                    txt_login_email.Text = Request.Cookies["student_email"].Value;
                    txt_login_password.Text = Request.Cookies["student_password"].Value;
                }

            }
        }

        private void checkQualification()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int studentId = (int)Session["user_id"]; // Replace with the actual student ID
                string query = "SELECT TOP 1 1 FROM Qualification WHERE student_id = @student_id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@student_id", studentId);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        Response.Redirect("/home.aspx");
                    }
                    else
                    {
                        Response.Redirect("qualification.aspx");
                    }
                }
            }
        }

        protected void btn_login_sign_in_Click(object sender, EventArgs e)
        {
            con.Open();

            string password = txt_login_password.Text;

            // Hash the password

            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string connectionString = constr; //replace with your connection string
            using (SqlConnection connection = new SqlConnection(connectionString)) ;
            string selectUser = "SELECT * FROM STUDENT WHERE student_email=@Email AND student_password=@Password";
            SqlCommand com = new SqlCommand(selectUser, con);
            com.Parameters.AddWithValue("@Email", txt_login_email.Text);
            com.Parameters.AddWithValue("@Password", password);

            SqlDataReader userReader = com.ExecuteReader();
            if (userReader.Read())
            {

                Response.Cookies["student_email"].Expires = DateTime.Now.AddMinutes(-1);
                Response.Cookies["student_password"].Expires = DateTime.Now.AddMinutes(-1);
                Session["student_id from [Student]"] = userReader.GetValue(0).ToString();

                Session["user_id"] = userReader.GetValue(0);
                con.Close();

                checkQualification();
            }
            else
            {
                userReader.Close();
                // Check if the email exists in the staff table
                string staffSelectQuery = "SELECT * FROM [Admin] WHERE admin_email=@Email AND admin_password=@Password";
                SqlCommand staffSelectCommand = new SqlCommand(staffSelectQuery, con);
                staffSelectCommand.Parameters.AddWithValue("@Email", txt_login_email.Text);
                staffSelectCommand.Parameters.AddWithValue("@Password", txt_login_password.Text);
                SqlDataReader staffReader = staffSelectCommand.ExecuteReader();

                if (staffReader.Read())
                {
                    Session["admin_name from [Admin]"] = staffReader.GetValue(1).ToString();

                    Session["admin_id"] = staffReader.GetValue(0);
                    con.Close();
                    //Response.Redirect("/Staff.aspx");
                    Response.Redirect("../EnquiryModule/enquiryStaff.aspx");
                }
                else
                {
                    lbl_error_msg.Text = "Wrong Email Or Password";
                    lbl_error_msg.ForeColor = System.Drawing.Color.Red;
                    con.Close();
                }

            }

        }

    }
}