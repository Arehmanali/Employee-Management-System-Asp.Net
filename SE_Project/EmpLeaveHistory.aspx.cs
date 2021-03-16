using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SE_Project
{
    public partial class EmpLeaveHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ltError.Visible = false;
                PopulateGridView();
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
                        string sql = "SELECT leave_status, CONVERT(VARCHAR(10),leave_date,103) AS leave_date, leave_emp, admin_remark, emp_remark, leave_type FROM tblLeave ";
                        sql += " WHERE (leave_status LIKE '%'+ @search + '%' OR leave_date LIKE '%' + @search + '%' OR leave_emp LIKE '%' + @search + '%' OR admin_remark LIKE '%' + @search + '%' OR emp_remark LIKE '%' + @search + '%' OR leave_type LIKE '%' + @search + '%') AND leave_emp='" + Session["emp_id"].ToString() + "'";
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
                        PopulateGridView();
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


        protected void PopulateGridView()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");

            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT leave_status, CONVERT(VARCHAR(10),leave_date,103) AS leave_date, leave_emp, admin_remark, emp_remark, leave_type FROM tblLeave WHERE leave_emp='" + Session["emp_id"].ToString() + "'", con);
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

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (Convert.ToString(DataBinder.Eval(e.Row.DataItem, "leave_status")) == "Approved")
            {
                e.Row.Cells[4].ForeColor = System.Drawing.Color.Green;
            }
            else if (Convert.ToString(DataBinder.Eval(e.Row.DataItem, "leave_status")) == "Not Approved")
            {
                e.Row.Cells[4].ForeColor = System.Drawing.Color.Red;
            }
            else if (Convert.ToString(DataBinder.Eval(e.Row.DataItem, "leave_status")) == "Pending")
            {
                e.Row.Cells[4].ForeColor = System.Drawing.Color.Blue;
            }
        }
    }
}