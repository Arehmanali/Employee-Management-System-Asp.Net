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
    public partial class EmpPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["emp_id"] == null)
            {
                Response.Redirect("EmpLogin.aspx");
            }
            else if(!IsPostBack)
            {
                ltMessage.Visible = false;
                PopulatePage();
            }
        }

        protected void PopulatePage()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            con.Open();
            DateTime date = System.DateTime.Now;
            int month = date.Month;
            int year = date.Year;
            try
            {
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT COUNT(*) AS totalLeaves FROM tblLeave WHERE leave_emp='" + Session["emp_id"].ToString() + "' AND MONTH(leave_date)='" + month + "' AND YEAR(leave_date)='" + year + "'", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    lblTotalLeaves.Text = dt1.Rows[0]["totalLeaves"].ToString();
                }
                SqlDataAdapter sda2 = new SqlDataAdapter("SELECT COUNT(*) AS approvedLeaves FROM tblLeave WHERE leave_emp='" + Session["emp_id"].ToString() + "' AND MONTH(leave_date)='" + month + "' AND YEAR(leave_date)='" + year + "' AND leave_status='" + "Approved" + "'", con);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                if (dt2.Rows.Count > 0)
                {
                    lblApprovedLeaves.Text = dt2.Rows[0]["approvedLeaves"].ToString();
                }
                SqlDataAdapter sda3 = new SqlDataAdapter("SELECT COUNT(*) AS pendingLeaves FROM tblLeave WHERE leave_emp='" + Session["emp_id"].ToString() + "' AND MONTH(leave_date)='" + month + "' AND YEAR(leave_date)='" + year + "' AND leave_status='" + "Pending" + "'", con);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);
                if (dt3.Rows.Count > 0)
                {
                    lblPendingLeaves.Text = dt3.Rows[0]["pendingLeaves"].ToString();
                }
                SqlDataAdapter sda4 = new SqlDataAdapter("SELECT sal_amount, (med_allowance+travel_allowance+wash_allowance) AS allowances, sal_deduction FROM tblSalary t INNER JOIN( SELECT sal_empId, MAX(sal_month) AS MaxDate FROM tblSalary GROUP BY sal_empId ) tm ON t.sal_empId = tm.sal_empId AND t.sal_month = tm.MaxDate WHERE t.sal_empId = '" + Session["emp_id"].ToString() + "'", con);
                DataTable dt4 = new DataTable();
                sda4.Fill(dt4);
                if (dt4.Rows.Count > 0)
                {
                    lblLastSalary.Text = dt4.Rows[0]["sal_amount"].ToString();
                    lblAllowances.Text = dt4.Rows[0]["allowances"].ToString();
                    lblDeduction.Text = dt4.Rows[0]["sal_deduction"].ToString();
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
    }
}