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
    public partial class MarkAttendance : System.Web.UI.Page
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
                PopulateDdlDep();
            }
        }

        protected void PopulateDdlDep()
        {
            DataTable table = new DataTable();
            string conString="Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conString))
            {
                string com = "Select dep_id, dep_name from tblDepartment";
                using (SqlCommand cmd = new SqlCommand(com,con))
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

        protected void MarkAttendancePresent()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
           
            if(txtAttendanceDate.Text !="")
            {
                DateTime attendDate = DateTime.ParseExact(txtAttendanceDate.Text, "dd/MM/yyyy", null);
                var newAttendDate = attendDate.ToString("yyyy/MM/dd");
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tblAttendance values(@attendEmp, @status,@date)", con);
                    cmd.Parameters.AddWithValue("@attendEmp", ddlEmp.SelectedValue);
                    cmd.Parameters.AddWithValue("@status", "Present");
                    cmd.Parameters.AddWithValue("@date", newAttendDate);
                    cmd.ExecuteNonQuery();
                    ltError.Visible = true;
                    ltError.Text = "<span style='color:green'>Attendance Marked Successfuly</span>";
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

        protected void MarkAttendanceAbsent()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            
            if(txtAttendanceDate.Text !="")
            {
                DateTime attendDate = DateTime.ParseExact(txtAttendanceDate.Text, "dd/MM/yyyy", null);
                var newAttendDate = attendDate.ToString("yyyy/MM/dd");
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tblAttendance values(@attendEmp, @status,@date)", con);
                    cmd.Parameters.AddWithValue("@attendEmp", ddlEmp.SelectedValue);
                    cmd.Parameters.AddWithValue("@status", "Absent");
                    cmd.Parameters.AddWithValue("@date", newAttendDate);
                    cmd.ExecuteNonQuery();
                    ltError.Visible = true;
                    ltError.Text = "<span style='color:green'>Attendance Marked Successfuly</span>";
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

        protected void btnPresent_Click(object sender, EventArgs e)
        {
            MarkAttendancePresent();
        }

        protected void btnAbsent_Click(object sender, EventArgs e)
        {
            MarkAttendanceAbsent();
        }

        protected void ddlDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            var autoid =ddlDep.SelectedValue.ToString();
            string conString = "Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conString))
            {
                string com = "Select emp_id, emp_name from tblEmployee where emp_dep=@empDep";
                using (SqlCommand cmd = new SqlCommand(com, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        cmd.Parameters.AddWithValue("@empDep",autoid);
                        sda.Fill(table);
                    }
                }
            }
            ddlEmp.DataSource = table;
            ddlEmp.DataBind();
            ddlEmp.Items.Insert(0, new ListItem("Select Employee", "0"));
        }
    }
}