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
    public partial class Salary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ltError.Visible = false;
                populateGridView();
                this.SearchGridView();
            }
        }

        private void SearchGridView()
        {
            string constr = "Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                    {
                        string sql = "SELECT t1.emp_id, t1.emp_name, t2.med_allowance,t2.travel_allowance, t2.wash_allowance,t2.sal_amount, CONVERT(VARCHAR(10), t2.sal_month,103) AS sal_month FROM tblEmployee t1 RIGHT JOIN tblSalary t2 ON t1.emp_id = t2.sal_empId   ";
                        sql += " WHERE t1.emp_id LIKE '%'+ @search + '%' OR t1.emp_name LIKE '%' + @search + '%' OR t2.med_allowance LIKE '%' + @search + '%' OR t2.sal_amount LIKE '%' + @search + '%' OR t2.sal_month LIKE '%' + @search + '%' OR t2.travel_allowance LIKE '%' + @search + '%' OR t2.wash_allowance LIKE '%' + @search + '%' GROUP BY t1.emp_id, t1.emp_name, t2.med_allowance, t2.travel_allowance, t2.wash_allowance,t2.sal_amount,t2.sal_month ";
                        cmd.Parameters.AddWithValue("@search", txtSearch.Text.Trim());
                        cmd.CommandText = sql;
                        cmd.Connection = con;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                            if (GridView1.Rows.Count < 1)
                            {
                                ltError.Visible = true;
                                ltError.Text = "<span style='color:red'> No Record Found !!! </span>";
                            }
                        }
                    }
                    else
                    {
                        ltError.Visible = false;
                        populateGridView();
                    }
                }
            }
        }

        protected void Search(object sender, EventArgs e)
        {
            ltError.Visible = false;
            this.SearchGridView();
        }

        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.SearchGridView();
        }

        protected void populateGridView()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");

            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT t1.emp_id, t1.emp_name, t2.med_allowance,t2.travel_allowance, t2.wash_allowance,t2.sal_amount, CONVERT(VARCHAR(10), t2.sal_month,103) AS sal_month FROM tblEmployee t1 RIGHT JOIN tblSalary t2 ON t1.emp_id = t2.sal_empId  GROUP BY t1.emp_id, t1.emp_name, t2.med_allowance, t2.travel_allowance, t2.wash_allowance,t2.sal_amount,t2.sal_month", con);

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

        protected void linkButton_Click(object sender, EventArgs e)
        {
            GridViewRow clickedRow = ((LinkButton)sender).NamingContainer as GridViewRow;
            Label lblEmpId = (Label)clickedRow.FindControl("lblId");
            Label lblSalDate = (Label)clickedRow.FindControl("lblSalDate");
            Response.Redirect("ViewSalaryDetails.aspx?emp_id=" + lblEmpId.Text + "&sal_month=" + lblSalDate.Text);
        }
    }
}