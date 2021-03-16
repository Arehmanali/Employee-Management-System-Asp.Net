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
    public partial class EmpSalaryReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ltError.Visible = false;
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
                        string sql = "SELECT sal_amount, sal_deduction, (med_allowance + travel_allowance + wash_allowance) AS total_allowances, (sal_amount + med_allowance + travel_allowance + wash_allowance - sal_deduction) AS net_pay  FROM tblEmployee INNER JOIN tblSalary ON emp_id = sal_empId  ";
                        sql += " WHERE (sal_amount LIKE '%'+ @search + '%' OR sal_deduction LIKE '%' + @search + '%') AND emp_id='" + Session["emp_id"].ToString() + "' AND MONTH(sal_month)='" + ddlMonth.SelectedValue + "' AND YEAR(sal_month)='" + txtYear.Text + "'";
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
                SqlDataAdapter sda = new SqlDataAdapter("SELECT sal_amount, sal_deduction, (med_allowance + travel_allowance + wash_allowance) AS total_allowances, (sal_amount + med_allowance + travel_allowance + wash_allowance - sal_deduction) AS net_pay  FROM tblEmployee INNER JOIN tblSalary ON emp_id = sal_empId WHERE emp_id='" + Session["emp_id"].ToString() + "' AND MONTH(sal_month)='" + ddlMonth.SelectedValue + "' AND YEAR(sal_month)='" + txtYear.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                GridView1.DataSource = dt;
                GridView1.DataBind();
                if(GridView1.Rows.Count<1)
                {
                    ltError.Visible = true;
                    ltError.Text = "<span style='color:red'> No Record Found !</span>";
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

        protected void ddlMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltError.Visible = false;
            PopulateGridView();
            //this.SearchGridView();
        }

        protected void linkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmpSalaryReciept.aspx?emp_id=" + Session["emp_id"].ToString() + "&sal_month=" + ddlMonth.SelectedValue + "&sal_year=" + txtYear.Text);

        }
    }
}