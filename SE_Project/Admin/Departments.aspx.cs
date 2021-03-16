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
    public partial class Departments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin_id"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
            else if(!IsPostBack)
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
                    if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                    {
                        string sql = "SELECT t2.dep_id, t2.dep_name, COUNT(t1.emp_dep) as total_emp FROM tblEmployee t1 RIGHT JOIN tblDepartment t2 ON t1.emp_dep = t2.dep_id ";
                        sql += " WHERE t2.dep_id LIKE '%'+ @search + '%' OR t2.dep_name LIKE '%' + @search + '%' GROUP BY t2.dep_id, t2.dep_name";
                        cmd.Parameters.AddWithValue("@search", txtSearch.Text.Trim());
                        cmd.CommandText = sql;
                        cmd.Connection = con;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                            if(GridView1.Rows.Count <1)
                            {
                                ltError.Visible = true;
                                ltError.Text = "<span style='color:red'> No Record Found !!! </span>";
                            }
                        }
                    }
                    else
                    {
                        ltError.Visible = false;
                        populateGridView();
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

        protected void DeleteDep(string depId)
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(emp_dep) FROM tblEmployee RIGHT JOIN tblDepartment ON emp_dep = dep_id WHERE dep_id='"+depId+"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int totalEmp =Int32.Parse(dt.Rows[0][0].ToString());
                if(totalEmp < 1)
                {
                    SqlCommand cmd = new SqlCommand("delete from tblDepartment where dep_id=@depId", con);
                    cmd.Parameters.AddWithValue("@depId", depId);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    ltError.Visible = true;
                    ltError.Text= "<span style='color:red'> To Delete Department, Employee Should be 0. </span>";
                }
                
                con.Close();
            }
            catch (SqlException ex)
            {
                ltError.Visible = true;
                ltError.Text = ex.Message;
            }
        }

        protected void populateGridView()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");

            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT t2.dep_id, t2.dep_name, COUNT(t1.emp_dep) as total_emp FROM tblEmployee t1 RIGHT JOIN tblDepartment t2 ON t1.emp_dep = t2.dep_id GROUP BY t2.dep_id, t2.dep_name ORDER BY total_emp DESC", con);
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

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string item = e.Row.Cells[1].Text;
                foreach (Button button in e.Row.Cells[3].Controls.OfType<Button>())
                {
                    if (button.CommandName == "Select")
                    {
                        button.Attributes["onclick"] = "if(!confirm('Do you want to delete " + item + "?')){ return false; };";
                    }
                }
            }
        }

        protected void linkButton_Click(object sender, EventArgs e)
        {
            GridViewRow clickedRow = ((LinkButton)sender).NamingContainer as GridViewRow;
            Label lblDepId = (Label)clickedRow.FindControl("lblId");
            DeleteDep(lblDepId.Text);
            ltError.Visible = false;
            populateGridView();
        }
    }
}