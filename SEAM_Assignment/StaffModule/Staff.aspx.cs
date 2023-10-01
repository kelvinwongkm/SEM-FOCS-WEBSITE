using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace SEAM_Assignment.StaffModule
{
    public partial class Staff : System.Web.UI.Page
    {

        protected void bindData()
        {
            if (!this.IsPostBack)
            {

                string division = "All Staff";
                staffTitle.Text = division;
                string sql = "SELECT* FROM STAFF";
                string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        rptImages.DataSource = dt;
                        rptImages.DataBind();

                    }
                }

            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            bindData();
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


        protected void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txt_staff_search.Text;
            string sql = "SELECT * FROM STAFF " +
                         "WHERE staff_name LIKE '%' + @keyword + '%'";

            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", keyword);

                    conn.Open();
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        rptImages.DataSource = dt;
                        rptImages.DataBind();
                    }
                }
            }
        }


        protected void rdl_staff_sorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortBy = rdl_alphabet.SelectedValue;
            string division = rdl_staff_division.SelectedValue;
            string sql;

            if (division == "All Staff")
            {
                sql = "SELECT * FROM STAFF";
            }
            else
            {
                sql = "SELECT DISTINCT dbo.Staff.staff_id, dbo.Staff.staff_name," +
                      "dbo.Staff.staff_position, dbo.Staff.staff_division, dbo.Staff.staff_email, " +
                      "dbo.Staff.staff_qua, dbo.Staff.staff_img " +
                      "FROM dbo.Staff " +
                      "WHERE dbo.Staff.staff_division = @division";
            }

            // Determine the sorting order based on the selected radio button
            string orderByClause = (sortBy == "Alphabetical") ? "ORDER BY staff_name ASC" : "";

            // Check if a department is selected, and add the parameter and order by clause accordingly

            sql += " " + orderByClause;

            // Connection string
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@division", division); // Set the parameter value
                    conn.Open();

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        rptImages.DataSource = dt;
                        rptImages.DataBind();
                    }
                }
            }
        }


        protected void rdl_staff_division_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected division from the radio button list
            string division = rdl_staff_division.SelectedValue;
            string sql = "";

            // Update the title to display the selected division
            staffTitle.Text = division;

            // Define the SQL query to fetch staff based on the selected division
            if (division == "All Staff")
            {
                sql = "SELECT * FROM STAFF";
            }
            else
            {
                sql = "SELECT DISTINCT dbo.Staff.staff_id, dbo.Staff.staff_name," +
                      "dbo.Staff.staff_position, dbo.Staff.staff_division, dbo.Staff.staff_email, " +
                      "dbo.Staff.staff_qua, dbo.Staff.staff_img " +
                      "FROM dbo.Staff " +
                      "WHERE dbo.Staff.staff_division = @division";
            }

            // Check if alphabetical sorting is selected
            if (rdl_alphabet.SelectedValue == "Alphabetical")
            {
                // Append ORDER BY clause to sort by staff_name
                sql += " ORDER BY staff_name ASC";
            }

            // Connection string
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@division", division); // Set the parameter value

                    conn.Open();

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        rptImages.DataSource = dt;
                        rptImages.DataBind();
                    }
                }
            }
        }

    }
}