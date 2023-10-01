using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace SEAM_Assignment.StaffModule
{
    public partial class staff_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string staffID = Request.QueryString["staff_id"];

            if (!IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                string staffId = Request.QueryString["staff_id"];
                string connectionString = constr; //replace with your connection string
                string query = "SELECT* FROM STAFF WHERE dbo.staff.staff_id = @staffId";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@staffId", staffId);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string staffName = reader["staff_name"].ToString();
                        string staffPosition = reader["staff_position"].ToString();
                        string staffDivision = reader["staff_division"].ToString();
                        string staffEmail = reader["staff_email"].ToString();
                        string staffQualification = reader["staff_qua"].ToString();

                        //set the product details to your label controls
                        lblStaffName.Text = staffName;
                        lblStaffPosition.Text = staffPosition;
                        lblStaffDivision.Text = staffDivision;
                        lblStaffEmail.Text = staffEmail;
                        lblStaffQualification.Text = staffQualification;
                        Image1.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])reader["staff_img"]);
                    }
                    reader.Close();
                }

            }
        }


        protected void OnItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

                DataRowView dr = e.Item.DataItem as DataRowView;
                string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["staff_img"]);
                (e.Item.FindControl("Image1") as Image).ImageUrl = imageUrl;

            }
        }



    }
}