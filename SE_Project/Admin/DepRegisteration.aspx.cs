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
    public partial class DepRegisteration : System.Web.UI.Page
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
            }
        }

        protected void AddDepartment()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into tblDepartment values(@depId, @depName)", con);
                cmd.Parameters.AddWithValue("@depId", txtDepId.Text);
                cmd.Parameters.AddWithValue("@depName", txtDepName.Text);
                cmd.ExecuteNonQuery();
                ltError.Visible = true;
                ltError.Text = "<span style='color:green'> Department Added Successfully. </span>";
                txtDepId.Text = "";
                txtDepName.Text = "";
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            AddDepartment();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Departments.aspx");
        }
    }
}