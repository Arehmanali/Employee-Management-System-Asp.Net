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
    public partial class YearlySalaryReciept : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ltError.Visible = false;
                PopulateForm();
                lblDate.Text = System.DateTime.Now.ToString();
            }
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
               server control at run time. */
        }
        protected void PopulateForm()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            con.Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT (sal_amount+med_allowance+travel_allowance+wash_allowance-sal_deduction) As net_pay, sal_deduction, emp_id,emp_name,emp_contact,emp_email, sal_amount, DATENAME(month, sal_month) AS salary_month, med_allowance,travel_allowance, wash_allowance, sal_amount FROM tblEmployee INNER JOIN tblSalary ON emp_id = sal_empId WHERE emp_id='" + Request.QueryString["emp_id"].ToString() + "' AND YEAR(sal_month)='" + Request.QueryString["sal_year"] + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    lblEmpId.Text = dt.Rows[0]["emp_id"].ToString();
                    lblEmpName.Text = dt.Rows[0]["emp_name"].ToString();
                    lblEmpContact.Text = dt.Rows[0]["emp_contact"].ToString();
                    lblEmpEmail.Text = dt.Rows[0]["emp_email"].ToString();
                }
                GridView1.DataSource = dt;
                GridView1.DataBind();
                
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
               
                string com = "Select dep_name,design_name from tblEmployee inner join tblDepartment on emp_dep = dep_id inner join tblDesignations on emp_design = design_id where emp_id='" + Request.QueryString["emp_id"].ToString() + "'";
                SqlDataAdapter adpt5 = new SqlDataAdapter(com, con);
                DataTable dt5 = new DataTable();
                adpt5.Fill(dt5);
                if (dt5.Rows.Count > 0)
                {
                    lblEmpDep.Text = dt5.Rows[0][0].ToString();
                    lblEmpDesign.Text = dt5.Rows[0][1].ToString();
                }

                SqlDataAdapter sda6 = new SqlDataAdapter("SELECT(SUM(sal_amount) + SUM(med_allowance) + SUM(travel_allowance) + SUM(wash_allowance) - SUM(sal_deduction)) As totalNetPay, SUM(sal_deduction) AS totalSalDeduction, SUM(sal_amount) AS totalSalAmount, SUM(med_allowance) AS totalMedAllowance, SUM(travel_allowance) AS totalTravelAllowance, SUM(wash_allowance) AS totalWashAllowance FROM tblEmployee INNER JOIN tblSalary ON emp_id = sal_empId WHERE emp_id = '" + Request.QueryString["emp_id"].ToString() + "' AND YEAR(sal_month) = '"+Request.QueryString["sal_year"]+"'", con);
                DataTable dt6 = new DataTable();
                sda6.Fill(dt6);
                if (dt6.Rows.Count > 0)
                {
                    lblTotalNetPay.Text = dt6.Rows[0]["totalNetPay"].ToString();
                    lblTotalDeduction.Text = dt6.Rows[0]["totalSalDeduction"].ToString();
                    lblTotalSalary.Text = dt6.Rows[0]["totalSalAmount"].ToString();
                    lblTotalTravelAll.Text = dt6.Rows[0]["totalTravelAllowance"].ToString();
                    lblTotalMedAll.Text = dt6.Rows[0]["totalMedAllowance"].ToString();
                    lblTotalWashAll.Text = dt6.Rows[0]["totalWashAllowance"].ToString();
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
            Response.AddHeader("content-disposition", "attachment;filename=YearlySalaryReciept.pdf");
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