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
    public partial class EmpLeave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ltError.Visible = false;
            }
        }
        
        

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            con.Open();
           
            try
            {
                SqlCommand cmd = new SqlCommand("insert into tblLeave(leave_type,leave_emp,leave_date,emp_remark,leave_status) values(@leave_type, @leave_emp, @leave_date, @emp_remark, @leave_status)", con);
                cmd.Parameters.AddWithValue("@leave_emp", Session["emp_id"].ToString());
                cmd.Parameters.AddWithValue("@leave_type", ddlLeaveType.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@leave_date", txtLeaveDate.Text);
                cmd.Parameters.AddWithValue("@emp_remark", txtDescription.Text);
                cmd.Parameters.AddWithValue("@leave_status", "Pending");
                cmd.ExecuteNonQuery();
                ltError.Visible = true;
                ltError.Text = "<span style='color:green'>Leave Request Submited Successfuly</span>";
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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmpPanel.aspx");
        }
    }
}