using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

namespace SE_Project.Admin
{
    public partial class SalaryReceipt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ltError.Visible = false;
                PopulateForm();
                lblDate.Text = System.DateTime.Now.ToString();
            }
        }

        protected void PopulateForm()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            con.Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT sal_id,sal_deduction, emp_id,emp_name,emp_contact,emp_email,emp_salary_amount, CONVERT(VARCHAR(10),sal_month,103) AS sal_month, med_allowance,travel_allowance, wash_allowance, sal_amount FROM tblEmployee INNER JOIN tblSalary ON emp_id = sal_empId WHERE emp_id='"+ Request.QueryString["emp_id"].ToString() +"' AND MONTH(sal_month)='"+ Request.QueryString["sal_month"] +"' AND YEAR(sal_month)='"+Request.QueryString["sal_year"]+"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    lblSalaryId.Text = dt.Rows[0]["sal_id"].ToString();
                    lblEmpId.Text = dt.Rows[0]["emp_id"].ToString();
                    lblEmpName.Text = dt.Rows[0]["emp_name"].ToString();
                    lblEmpContact.Text = dt.Rows[0]["emp_contact"].ToString();
                    lblEmpEmail.Text = dt.Rows[0]["emp_email"].ToString();
                    lblSalaryAmount.Text = dt.Rows[0]["emp_salary_amount"].ToString();
                    
                    lblMedAllowance.Text = dt.Rows[0]["med_allowance"].ToString();
                    lblTravelAllowance.Text = dt.Rows[0]["travel_allowance"].ToString();
                    lblWashAllowance.Text = dt.Rows[0]["wash_allowance"].ToString();
                    lblSalId.Text = dt.Rows[0]["sal_id"].ToString();
                    lblLeaveDeductions.Text = dt.Rows[0]["sal_deduction"].ToString();
                }
                SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM tblAdmin WHERE admin_id='" + Session["admin_id"] + "'", con);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                if (dt2.Rows.Count > 0)
                {
                    lblAdminId.Text = dt2.Rows[0]["admin_id"].ToString();
                    lblAdminName.Text = dt2.Rows[0]["admin_fname"].ToString() + dt2.Rows[0]["admin_lname"].ToString();
                    lblAdminContact.Text = dt2.Rows[0]["admin_contact"].ToString();
                    lblAdminEmail.Text = dt2.Rows[0]["admin_email"].ToString();
                }
                SqlDataAdapter sda3 = new SqlDataAdapter("SELECT COUNT(*) AS totalLeaves FROM tblLeave WHERE leave_emp='" + Request.QueryString["emp_id"].ToString() + "' AND MONTH(leave_date)='" + Request.QueryString["sal_month"] + "' AND YEAR(leave_date)='" + Request.QueryString["sal_year"] + "'", con);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);
                if (dt3.Rows.Count > 0)
                {
                    lblTotalLeaves.Text = dt3.Rows[0]["totalLeaves"].ToString();
                }
                SqlDataAdapter sda4 = new SqlDataAdapter("SELECT COUNT(*) AS approvedLeaves FROM tblLeave WHERE leave_emp='" + Request.QueryString["emp_id"].ToString() + "' AND MONTH(leave_date)='" + Request.QueryString["sal_month"] + "' AND YEAR(leave_date)='" + Request.QueryString["sal_year"] + "' AND leave_status='" + "Approved" + "'", con);
                DataTable dt4 = new DataTable();
                sda4.Fill(dt4);
                if (dt4.Rows.Count > 0)
                {
                    lblApprovedLeave.Text = dt4.Rows[0]["approvedLeaves"].ToString();
                }

                string com = "Select dep_name,design_name from tblEmployee inner join tblDepartment on emp_dep = dep_id inner join tblDesignations on emp_design = design_id where emp_id='" + Request.QueryString["emp_id"].ToString() + "'";
                SqlDataAdapter adpt5 = new SqlDataAdapter(com, con);
                DataTable dt5 = new DataTable();
                adpt5.Fill(dt5);
                if (dt5.Rows.Count > 0)
                {
                    lblEmpDep.Text = dt5.Rows[0][0].ToString();
                    lblEmpDesign.Text = dt5.Rows[0][1].ToString();

                }

                if (lblSalaryAmount.Text !="")
                {
                    var totalAllowance = (Int32.Parse(lblMedAllowance.Text) + Int32.Parse(lblTravelAllowance.Text) + Int32.Parse(lblWashAllowance.Text));
                    lblTotalAllowance.Text = totalAllowance.ToString();

                    lblDeductionTotal.Text = lblLeaveDeductions.Text;
                    if (lblDeductionTotal.Text != "")
                    {
                        var netPay = (Int32.Parse(lblSalaryAmount.Text) + totalAllowance) - Int32.Parse(lblDeductionTotal.Text);
                        lblNetPay.Text = netPay.ToString();
                    }
                    else
                    {
                        ltError.Visible = true;
                        ltError.Text = "No value in Deduction Total";
                    }
                    
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

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            ExportPdf();
        }

        protected void ExportPdf()
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=SalaryReciept.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            Panel1.RenderControl(hw);

            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
        }
    }
}