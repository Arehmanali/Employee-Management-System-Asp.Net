using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SE_Project.Admin
{
    public partial class AdminPanel : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin_id"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
            else if(!IsPostBack)
            {
                ltMessage.Visible = false;
                populateGridView();
                this.SearchGridView();
                lblTotalEmp.Text = ShowTotalEmp();
                lblTotalDep.Text = ShowTotalDep();
                lblAttendance.Text = ShowAttendance()+"%";
                lblLeaveRequest.Text = ShowLeaveRequests();
            }
        }

        private void SearchGridView()
        {
            string constr = "Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True";
            //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string sql = "Select emp_id, emp_name, design_name, dep_name, emp_contact, emp_email from tblEmployee inner join tblDesignations on tblEmployee.emp_design = tblDesignations.design_id inner join tblDepartment on tblEmployee.emp_dep = tblDepartment.dep_id";
                    if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                    {
                        sql += " WHERE emp_id LIKE '%'+ @search + '%' OR emp_name LIKE '%' + @search + '%' OR design_name LIKE '%' + @search + '%' OR dep_name LIKE '%' + @search + '%' OR emp_contact LIKE '%' + @search + '%' OR emp_email LIKE '%' + @search + '%'";
                        cmd.Parameters.AddWithValue("@search", txtSearch.Text.Trim());
                    }
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
                            ltMessage.Visible = true;
                            ltMessage.Text = "<span style='color:red'> No Record Found !!! </span>";
                        }
                    }
                }
            }
        }

        protected void Search(object sender, EventArgs e)
        {
            ltMessage.Visible = false;
            this.SearchGridView();
        }
        
        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.SearchGridView();
        }

        protected string ShowTotalEmp()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            string totalEmp =null;
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from tblEmployee ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                totalEmp = dt.Rows[0][0].ToString();
            }
            catch (SqlException ex)
            {
                ltMessage.Visible = true;
                ltMessage.Text = ex.Message;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return totalEmp;
        }

        protected string ShowLeaveRequests()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            string leaveRequests = null;
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from tblLeave where leave_status='Pending' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                leaveRequests = dt.Rows[0][0].ToString();
            }
            catch (SqlException ex)
            {
                ltMessage.Visible = true;
                ltMessage.Text = ex.Message;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return leaveRequests;
        }

        protected string ShowTotalDep()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            string totalDep = null;
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from tblDepartment ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                totalDep = dt.Rows[0][0].ToString();
            }
            catch (SqlException ex)
            {
                ltMessage.Visible = true;
                ltMessage.Text = ex.Message;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return totalDep;
        }

        protected string ShowAttendance()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            string Attendance = null;
            string attendStatus = "Present";
            int attend, totalEmp = 0;
            DateTime date = DateTime.Now.Date;
            string newdate = date.ToString("yyyy/MM/dd");
            try
            {
                con.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT COUNT(*) from tblEmployee ", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                totalEmp = Int32.Parse(dt1.Rows[0][0].ToString());
               
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from tblAttendance where attend_date='"+ newdate +"' AND attend_status='"+ attendStatus + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt); 
                attend = Int32.Parse(dt.Rows[0][0].ToString());
                int percentComplete = (int)Math.Round((double)(100 * attend) / totalEmp);
                Attendance = percentComplete.ToString();
            }
            catch (SqlException ex)
            {
                ltMessage.Visible = true;
                ltMessage.Text = ex.Message;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return Attendance;
        }

        protected void populateGridView()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select emp_id, emp_name, design_name, dep_name, emp_contact, emp_email from tblEmployee inner join tblDesignations on tblEmployee.emp_design = tblDesignations.design_id inner join tblDepartment on tblEmployee.emp_dep = tblDepartment.dep_id", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                else
                {
                    ltMessage.Visible = true;
                    ltMessage.Text = "<span style='color:red'>No Record Found !</span>";
                }
                
            }
            catch (SqlException ex)
            {
                ltMessage.Visible = true;
                ltMessage.Text = ex.Message;
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
            Response.Redirect("EmpDetails.aspx?emp_id=" + lblEmpId.Text);
        }
    }
}