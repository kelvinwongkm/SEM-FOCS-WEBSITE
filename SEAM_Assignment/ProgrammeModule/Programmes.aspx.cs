using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace SEAM_Assignment
{
    public partial class Programmes : System.Web.UI.Page
    {
        protected void BindData()
        {

            programLevel.Text = "ALL";
            string sql = "SELECT* FROM PROGRAM";
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    program.DataSource = dt;
                    program.DataBind();

                }
            }


        }

        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();

            // Call DataBind to evaluate the data binding expression
            Page.DataBind();

            BachelorProgramsLink.CssClass = "";
            DiplomaProgramsLink.CssClass = "";
            AllProgramsLink.CssClass = "active";

        }

        protected void OnItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView dr = e.Item.DataItem as DataRowView;
            }
        }

        protected void AllProgramsLink_Click(object sender, EventArgs e)
        {
            BindData();

            BachelorProgramsLink.CssClass = "";
            DiplomaProgramsLink.CssClass = "";
            AllProgramsLink.CssClass = "active";
        }

        protected void BachelorProgramsLink_Click(object sender, EventArgs e)
        {

            programLevel.Text = "Bachelor Degree";
            string level = "Bachelor Degree";
            string sql = "SELECT* FROM PROGRAM WHERE dbo.Program.program_level = @level";
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Add a parameter for the program_level value
                    cmd.Parameters.AddWithValue("@level", level);

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        program.DataSource = dt;
                        program.DataBind();
                    }
                }
            }


            BachelorProgramsLink.CssClass = "active";
            DiplomaProgramsLink.CssClass = "";
            AllProgramsLink.CssClass = "";
        }

        protected void DiplomaProgramsLink_Click(object sender, EventArgs e)
        {

            programLevel.Text = "Diploma";
            string level = "Diploma";
            string sql = "SELECT* FROM PROGRAM WHERE dbo.Program.program_level = @level";
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Add a parameter for the program_level value
                    cmd.Parameters.AddWithValue("@level", level);

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        program.DataSource = dt;
                        program.DataBind();
                    }
                }
            }


            BachelorProgramsLink.CssClass = "";
            DiplomaProgramsLink.CssClass = "active";
            AllProgramsLink.CssClass = "";
        }



        protected void checkQbtn_Click(object sender, EventArgs e)
        {
            if (Session["user_id"] != null)
            {
                Response.Redirect("/ProgrammeModule/Enrolment.aspx");
            }
            else {
                Response.Redirect("/ProgrammeModule/EnrolmentDefault.aspx");
            }
            
        }

        protected void comparePbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ProgrammeModule/compareProgrammes.aspx");
        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            string keyword = SearchTextBox.Text;
            string sql = "SELECT * FROM PROGRAM " +
                         "WHERE program_title LIKE '%' + @keyword + '%'";

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
                        program.DataSource = dt;
                        program.DataBind();
                    }
                }
            }
        }
    }
}

