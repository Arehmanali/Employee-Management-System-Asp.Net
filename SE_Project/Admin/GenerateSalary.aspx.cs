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
    public partial class GenerateSalary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ltError.Visible = false;
                PopulateDdlDep();
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

        protected void GetSalary()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");

            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT emp_salary_amount FROM tblEmployee WHERE emp_id='" + ddlEmp.SelectedValue + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    lblSalary.Text = dt.Rows[0][0].ToString();
            
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

        protected void PopulateForm()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            GetSalary();
            con.Open();
            try
            {
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT COUNT(*) AS totalLeaves FROM tblLeave WHERE leave_emp='" + ddlEmp.SelectedValue + "' AND MONTH(leave_date)='" +ddlMonth.SelectedValue+ "' AND YEAR(leave_date)='"+ txtYear.Text +"'", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                if (dt1.Rows.Count>0)
                {
                    lblTotalLeaves.Text = dt1.Rows[0]["totalLeaves"].ToString();
                }
                SqlDataAdapter sda2 = new SqlDataAdapter("SELECT COUNT(*) AS approvedLeaves FROM tblLeave WHERE leave_emp='" + ddlEmp.SelectedValue + "' AND MONTH(leave_date)='" + ddlMonth.SelectedValue + "' AND YEAR(leave_date)='" + txtYear.Text + "' AND leave_status='" + "Approved" + "'", con);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                if (dt2.Rows.Count > 0)
                {
                    lblApprovedLeaves.Text = dt2.Rows[0]["approvedLeaves"].ToString();
                }

                if (lblSalary.Text != "")
                {
                    var salary = Int32.Parse(lblSalary.Text);
                    var totalLeaves = Int32.Parse(lblTotalLeaves.Text) - Int32.Parse(lblApprovedLeaves.Text);
                    var payPerDay = salary / 30;
                    var deduction = payPerDay * totalLeaves;
                    lblLeaveDeduction.Text = deduction.ToString();
                }
                else
                {
                    ltError.Visible = true;
                    ltError.Text = "<span style='color:red'>No Record found</span>";
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

        protected int CalculateNetPay()
        {
            int netPay = (Int32.Parse(lblSalary.Text) + Int32.Parse(txtMedAllowance.Text) + Int32.Parse(txtTravelAllowance.Text) + Int32.Parse(txtWashAllowance.Text)) - Int32.Parse(lblLeaveDeduction.Text);
            return netPay;
        }



        protected void ddlDepartment_SelectedIndexChanged(object sender, EventArgs e)
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

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            GetSalary();
            PopulateForm();
        }

        protected void btnGenerateSal_Click(object sender, EventArgs e)
        {
            int netPay = CalculateNetPay();
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            con.Open();
            DateTime date = System.DateTime.Now;
            int year = date.Year;
            int day = date.Day;
            DateTime date2 = new DateTime(year, ddlMonth.SelectedIndex, day);
            //var newdate = date2.ToShortDateString();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into tblSalary values(@sal_empId, @sal_amount, @travel_allowance, @med_allowance, @wash_allowance,@sal_month, @sal_deduction)", con);
                cmd.Parameters.AddWithValue("@sal_empId", ddlEmp.SelectedValue);
                cmd.Parameters.AddWithValue("@sal_amount", lblSalary.Text);
                cmd.Parameters.AddWithValue("@travel_allowance", txtTravelAllowance.Text);
                cmd.Parameters.AddWithValue("@med_allowance", txtMedAllowance.Text);
                cmd.Parameters.AddWithValue("@wash_allowance", txtWashAllowance.Text);
                cmd.Parameters.AddWithValue("@sal_month", date2);
                cmd.Parameters.AddWithValue("@sal_deduction", lblLeaveDeduction.Text);
            
                cmd.ExecuteNonQuery();
                ltError.Visible = true;
                ltError.Text = "<span style='color:green'>Salary Generated Successfully</span>";
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
    }
}