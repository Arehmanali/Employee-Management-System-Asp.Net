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
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!IsPostBack)
            {
                ltError.Visible = false;
                populateGridView();
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
                    }
                }
            }
        }

        protected void Search(object sender, EventArgs e)
        {
            this.SearchGridView();
        }

        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.SearchGridView();
        }

        protected void populateGridView()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");

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

        protected void linkButton_Click(object sender, EventArgs e)
        {
            GridViewRow clickedRow = ((LinkButton)sender).NamingContainer as GridViewRow;
            Label lblEmpId = (Label)clickedRow.FindControl("lblId");
            Response.Redirect("EmpDetails.aspx?emp_id=" + lblEmpId.Text);
        }
    }
}