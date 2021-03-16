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
    public partial class AttendanceHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ltError.Visible = false;
                PopulateDdlEmp();
            }
        }
        protected void populateGridView()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");

            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT t1.emp_id, t1.emp_name, CONVERT(VARCHAR(10), t2.attend_date,103) AS attend_date, DATENAME(dw, t2.attend_date) AS attend_day, t2.attend_status FROM tblEmployee t1 LEFT JOIN tblAttendance t2 ON t1.emp_id = t2.attend_emp WHERE t1.emp_id='" + ddlEmp.SelectedValue+"' AND t2.attend_date='"+txtAttendanceDate.Text+"' GROUP BY t1.emp_id, t1.emp_name, t2.attend_date, t2.attend_status", con);
               
                DataTable dt = new DataTable();
                sda.Fill(dt);   
                GridView1.DataSource = dt;
                GridView1.DataBind();
                if(GridView1.Rows.Count < 1)
                {
                    ltError.Visible = true;
                    ltError.Text = "<span style='color:red'> No Record Found !!! </span>";
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

        protected void PopulateDdlEmp()
        {
            DataTable table = new DataTable();
            string conString = "Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conString))
            {
                string com = "Select emp_id,emp_name from tblEmployee";
                using (SqlCommand cmd = new SqlCommand(com, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(table);
                    }
                }
            }
            ddlEmp.DataSource = table;
            ddlEmp.DataBind();
            ddlEmp.Items.Insert(0, new ListItem("Select Employee", "0"));
        }

        protected void ddlEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltError.Visible = false;
            populateGridView();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (Convert.ToString(DataBinder.Eval(e.Row.DataItem, "attend_status")) == "Present")
            {
                e.Row.Cells[4].ForeColor = System.Drawing.Color.Green;
            }
            else if (Convert.ToString(DataBinder.Eval(e.Row.DataItem, "attend_status")) == "Absent")
            {
                e.Row.Cells[4].ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void txtAttendanceDate_TextChanged(object sender, EventArgs e)
        {
            ltError.Visible = false;
            PopulateDdlEmp();
        }
    }
}