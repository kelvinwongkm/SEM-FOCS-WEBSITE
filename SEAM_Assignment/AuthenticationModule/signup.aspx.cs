using System;
using System.Configuration;
using System.Data.SqlClient;

namespace SEAM_Assignment
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btn_login_sign_in_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            string param1 = txt_signup_email.Text;
            string selectEmail = "select student_email from [Student] where  student_email ='" + param1 + "'";
            SqlCommand checkEmail = new SqlCommand(selectEmail, con);
            SqlDataReader rdr = checkEmail.ExecuteReader();
            if (rdr.HasRows)
            {
                lbl_error_msg.Text = "Email Address is already exist. Please try with different email address.";
                lbl_error_msg.ForeColor = System.Drawing.Color.Red;
                con.Close();

            }
            else
            {
                con.Close();

                Random random = new Random();
                int myRandom = random.Next(10000000, 99999999);
                string activation_code = myRandom.ToString();
                string password = txt_signup_password.Text;

                con.Open();
                string insertQuery = "BEGIN TRANSACTION; " +
                       "DECLARE @student_id INT; " +
                       "INSERT INTO [Student] (student_name,student_email,student_password) " +
                       "VALUES (@student_name,@student_email,@student_password); " +
                       "SET @student_id = SCOPE_IDENTITY(); " +
                       "COMMIT TRANSACTION; ";

                SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                insertCmd.Parameters.AddWithValue("@student_email", txt_signup_email.Text);
                insertCmd.Parameters.AddWithValue("@student_name", txt_signup_name.Text);
                insertCmd.Parameters.AddWithValue("@student_password", txt_signup_password.Text);

                insertCmd.ExecuteNonQuery();

                lbl_error_msg.Text = "You are registered successfully.";
                lbl_error_msg.ForeColor = System.Drawing.Color.Green;

                Response.Redirect("signup_success.aspx");
            }


        }
    }
}