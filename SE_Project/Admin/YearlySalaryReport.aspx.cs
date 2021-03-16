using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SE_Project.Admin
{
    public partial class YearlySalaryReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ltError.Visible = false;
                PopulateDdlDep();
            }
        }
        protected void PopulateGridView()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");

            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT emp_id, emp_name, emp_salary_amount, sal_deduction, (med_allowance + travel_allowance + wash_allowance) AS total_allowances, (sal_amount + med_allowance + travel_allowance + wash_allowance - sal_deduction) AS net_pay, CONVERT(VARCHAR(10),sal_month,103) AS sal_month FROM tblEmployee INNER JOIN tblSalary ON emp_id = sal_empId WHERE emp_id='" + ddlEmp.SelectedValue + "' AND YEAR(sal_month)='" + txtYear.Text + "'", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                else
                {
                    ltError.Visible = true;
                    ltError.Text = "<span style='color:red'>No Record Found</span>";
                }
            }
            catch (SqlException ex)
            {
                ltError.Visible = true;
                ltError.Text = ex.Message;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        protected void PopulateDdlDep()
        {
            DataTable table = new DataTable();
            string conString = "Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conString))
            {
                string com = "Select dep_id, dep_name from tblDepartment";
                using (SqlCommand cmd = new SqlCommand(com, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(table);
                    }
                }

            }
            ddlDep.DataSource = table;
            ddlDep.DataBind();
            ddlDep.Items.Insert(0, new ListItem("Select Department", "0"));

        }

        protected void ddlDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            var autoid = ddlDep.SelectedValue.ToString();
            string conString = "Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conString))
            {
                string com = "Select emp_id, emp_name from tblEmployee where emp_dep=@empDep";
                using (SqlCommand cmd = new SqlCommand(com, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        cmd.Parameters.AddWithValue("@empDep", autoid);
                        sda.Fill(table);
                    }
                }
            }
            ddlEmp.DataSource = table;
            ddlEmp.DataBind();
            ddlEmp.Items.Insert(0, new ListItem("Select Employee", "0"));
        }

        protected void ddlEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltError.Visible = false;
            PopulateGridView();
        }

        protected void linkButton_Click(object sender, EventArgs e)
        {
            GridViewRow clickedRow = ((LinkButton)sender).NamingContainer as GridViewRow;
            Label lblID = (Label)clickedRow.FindControl("lblID");
            Response.Redirect("YearlySalaryReciept.aspx?emp_id=" + lblID.Text + "&sal_year=" + txtYear.Text);
        }
    }
}