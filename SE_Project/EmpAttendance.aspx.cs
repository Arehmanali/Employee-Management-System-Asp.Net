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
    public partial class EmpAttendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
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
                        string sql = "SELECT CONVERT(VARCHAR(10),attend_date,103) AS attend_date, attend_status, DATENAME(dw, attend_date) AS attend_day FROM tblAttendance ";
                        sql += " WHERE (attend_date LIKE '%'+ @search + '%' OR attend_status LIKE '%' + @search + '%') AND attend_emp='" + Session["emp_id"].ToString() + "'";
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
                SqlDataAdapter sda = new SqlDataAdapter("SELECT CONVERT(VARCHAR(10),attend_date,103) AS attend_date, attend_status, DATENAME(dw, attend_date) AS attend_day FROM tblAttendance WHERE attend_emp='" + Session["emp_id"].ToString() +"'", con);
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
            if (Convert.ToString(DataBinder.Eval(e.Row.DataItem, "attend_status")) == "Present")
            {
                e.Row.Cells[2].ForeColor = System.Drawing.Color.Green;
            }
            else if (Convert.ToString(DataBinder.Eval(e.Row.DataItem, "attend_status")) == "Absent")
            {
                e.Row.Cells[2].ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}