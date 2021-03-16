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
    public partial class ViewLeaveDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ltError.Visible = false;
                PopulateForm();
                ShowImage();
            }
           
        }

        protected void UpdateLeaveStatusApproved()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            DateTime date = DateTime.ParseExact(Request.QueryString["leave_date"], "dd/MM/yyyy", null);
            string newDate = date.ToString("yyyy/MM/dd");

            con.Open();
            try
            {
                string com = "update tblLeave set leave_status='"+"Approved"+"' where leave_emp='" + Request.QueryString["emp_id"].ToString() + "' and leave_date=@leaveDate";
                SqlCommand cmd = new SqlCommand(com, con);

                cmd.Parameters.AddWithValue("@leaveDate",newDate);
                cmd.ExecuteNonQuery();
                ltError.Visible = true;
                ltError.Text = "<span style='color:green'>Leave Status Updated</span>";
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

        protected void UpdateLeaveStatusNotApproved()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            DateTime date = DateTime.ParseExact(Request.QueryString["leave_date"], "dd/MM/yyyy", null);
            string newDate = date.ToString("yyyy/MM/dd");
            con.Open();
            try
            {
                string com = "update tblLeave set leave_status='" + "Not Approved" + "' where leave_emp='" + Request.QueryString["emp_id"].ToString() + "' and leave_date=@leaveDate";
                SqlCommand cmd = new SqlCommand(com, con);
                cmd.Parameters.AddWithValue("@leaveDate", newDate);
                cmd.ExecuteNonQuery();
                ltError.Visible = true;
                ltError.Text = "<span style='color:green'>Leave Status Updated</span>";
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

        protected void PopulateForm()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            DateTime date = DateTime.ParseExact(Request.QueryString["leave_date"], "dd/MM/yyyy", null);
            string secondFormat = date.ToString("yyyy/MM/dd");
            con.Open();
            try
            {
                string com1 = "Select * from tblEmployee where emp_id='" + Request.QueryString["emp_id"].ToString() + "'";
                SqlDataAdapter adpt = new SqlDataAdapter(com1, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    lblEmpId.Text = dt.Rows[0]["emp_id"].ToString();
                    lblEmpName.Text = dt.Rows[0]["emp_name"].ToString();
                    lblEmpEmail.Text = dt.Rows[0]["emp_email"].ToString();
                    lblEmpContact.Text = dt.Rows[0]["emp_contact"].ToString();
                    lblEmpGender.Text = dt.Rows[0]["emp_gender"].ToString();

                }
                string com2 = "Select dep_name,design_name from tblEmployee inner join tblDepartment on emp_dep = dep_id inner join tblDesignations on emp_design = design_id where emp_id='" + Request.QueryString["emp_id"].ToString() + "'";
                SqlDataAdapter adpt2 = new SqlDataAdapter(com2, con);
                DataTable dt2 = new DataTable();
                adpt2.Fill(dt2);
                if (dt2.Rows.Count > 0)
                {
                    lblEmpDep.Text = dt2.Rows[0][0].ToString();    
                    lblEmpDesign.Text = dt2.Rows[0][1].ToString();
                }
                string com3 = "SELECT leave_type, emp_remark, leave_status, admin_remark, CONVERT(VARCHAR(10),leave_date,103) AS leaveDate FROM tblEmployee INNER JOIN tblLeave ON emp_id = leave_emp WHERE emp_id='" + Request.QueryString["emp_id"].ToString() + "' AND leave_date='"+secondFormat+"'";
                SqlDataAdapter adpt3 = new SqlDataAdapter(com3, con);
                DataTable dt3 = new DataTable();
                adpt3.Fill(dt3);
                if (dt3.Rows.Count > 0)
                {
                    lblLeaveType.Text = dt3.Rows[0]["leave_type"].ToString();
                    lblLeaveDate.Text = dt3.Rows[0]["leaveDate"].ToString();
                    hfLeaveDate.Value = dt3.Rows[0]["leaveDate"].ToString();
                    lblEmpRemark.Text = dt3.Rows[0]["emp_remark"].ToString();
                    //lblLeaveStatus.Text = dt3.Rows[0]["leave_status"].ToString();
                    if (dt3.Rows[0]["leave_status"].ToString() == "Approved")
                    {
                        lblLeaveStatus.ForeColor = System.Drawing.Color.Green;
                        lblLeaveStatus.Text = dt3.Rows[0]["leave_status"].ToString();
                    }
                    else if (dt3.Rows[0]["leave_status"].ToString() == "Not Approved")
                    {
                        lblLeaveStatus.ForeColor = System.Drawing.Color.Red;
                        lblLeaveStatus.Text = dt3.Rows[0]["leave_status"].ToString();
                    }
                    else if (dt3.Rows[0]["leave_status"].ToString() == "Pending")
                    {
                        lblLeaveStatus.ForeColor = System.Drawing.Color.Blue;
                        lblLeaveStatus.Text = dt3.Rows[0]["leave_status"].ToString();
                    }
                    lblAdminRemark.Text = dt3.Rows[0]["admin_remark"].ToString();
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

        protected void ShowImage()
        {
            string connectionString = "Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "select * from tblImages where img_id='" + Request.QueryString["emp_id"] + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        byte[] bytes = (byte[])dt.Rows[0]["img_filecontent"];
                        string str = Convert.ToBase64String(bytes);
                        imgEmp.ImageUrl = "data:Image/png;base64," + str;
                    }
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                ltError.Visible = true;
                ltError.Text = ex.Message;
            }
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            UpdateLeaveStatusApproved();
            PopulateForm();
        }

        protected void btnReject_Click(object sender, EventArgs e)
        {
            UpdateLeaveStatusNotApproved();
            PopulateForm();
        }
    }
}