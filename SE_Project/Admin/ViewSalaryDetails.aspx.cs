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
    public partial class ViewSalaryDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ltError.Visible = false;
                PopulateForm();
                ShowImage();
            }
        }

        protected void PopulateForm()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            DateTime date = DateTime.ParseExact(Request.QueryString["sal_month"], "dd/MM/yyyy", null);
            string newDate = date.ToString("yyyy/MM/dd");
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
                string com3 = "SELECT sal_amount, med_allowance, travel_allowance, wash_allowance, sal_deduction, CONVERT(VARCHAR(10),sal_month,103) AS salaryDate FROM tblEmployee INNER JOIN tblSalary ON emp_id = sal_empId WHERE emp_id='" + Request.QueryString["emp_id"].ToString() + "' AND sal_month='"+ newDate +"'";
                SqlDataAdapter adpt3 = new SqlDataAdapter(com3, con);
                DataTable dt3 = new DataTable();
                adpt3.Fill(dt3);
                if (dt3.Rows.Count > 0)
                {
                    lblSalaryAmount.Text = dt3.Rows[0]["sal_amount"].ToString();
                    lblSalDate.Text = dt3.Rows[0]["salaryDate"].ToString();
                    hfSalDate.Value = dt3.Rows[0]["salaryDate"].ToString();
                    lblMedAllowance.Text = dt3.Rows[0]["med_allowance"].ToString();
                    lblWashAllowance.Text = dt3.Rows[0]["wash_allowance"].ToString();
                    lblTravelAllowance.Text = dt3.Rows[0]["travel_allowance"].ToString();
                    lblDeductions.Text = dt3.Rows[0]["sal_deduction"].ToString();
                }

                int salAmount = Int32.Parse(lblSalaryAmount.Text);
                int medAllowance = Int32.Parse(lblMedAllowance.Text);
                int travelAllowance = Int32.Parse(lblTravelAllowance.Text);
                int washAllowance = Int32.Parse(lblWashAllowance.Text);
                int deduct = Int32.Parse(lblDeductions.Text);
                int netPay = (salAmount + medAllowance + travelAllowance + washAllowance) - deduct;
                lblNetPay.Text = netPay.ToString();
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
    }
}