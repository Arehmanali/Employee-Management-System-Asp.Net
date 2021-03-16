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
    public partial class ApprovedLeaves : System.Web.UI.Page
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
                        string sql = "SELECT t1.emp_id, t1.emp_name, CONVERT(VARCHAR(10), t2.leave_date,103) AS leave_date, t2.leave_type, t2.emp_remark, t2.leave_status FROM tblEmployee t1 RIGHT JOIN tblLeave t2 ON t1.emp_id = t2.leave_emp ";
                        sql += " WHERE  (t1.emp_id LIKE '%'+ @search + '%' OR t1.emp_name LIKE '%' + @search + '%' OR t2.leave_date LIKE '%' + @search + '%' OR t2.leave_type LIKE '%' + @search + '%' OR t2.leave_status LIKE '%' + @search + '%') AND t2.leave_status='"+"Approved"+"' GROUP BY t1.emp_id, t1.emp_name, t2.leave_date, t2.leave_type, t2.leave_status, t2.emp_remark ";
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
                SqlDataAdapter sda = new SqlDataAdapter("SELECT t1.emp_id, t1.emp_name, CONVERT(VARCHAR(10),t2.leave_date,103) AS leave_date, t2.leave_type, t2.emp_remark, t2.leave_status FROM tblEmployee t1 RIGHT JOIN tblLeave t2 ON t1.emp_id = t2.leave_emp WHERE t2.leave_status='" + "Approved" + "' GROUP BY t1.emp_id, t1.emp_name, t2.leave_date, t2.leave_type, t2.leave_status, t2.emp_remark", con);

                DataTable dt = new DataTable();
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
            Label lblLeaveDate = (Label)clickedRow.FindControl("lblLeaveDate");
            Response.Redirect("ViewLeaveDetails.aspx?emp_id=" + lblEmpId.Text + "&leave_date=" + lblLeaveDate.Text);
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (Convert.ToString(DataBinder.Eval(e.Row.DataItem, "leave_status")) == "Approved")
            {
                e.Row.Cells[5].ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}