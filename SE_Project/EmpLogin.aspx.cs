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
    public partial class EmpLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* Checkbox Code */
            if (!IsPostBack)
            {
                if (Request.Cookies["EmpUserName"] != null && Request.Cookies["EmpPassword"] != null)
                {
                    txtEmail.Text = Request.Cookies["EmpUserName"].Value;
                    txtPassword.Attributes["Empvalue"] = Request.Cookies["EmpPassword"].Value;
                }
                literal1.Visible = false;
                label1.Visible = false;
                setSession();
            }
            /* CheckBox Code */
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            /* Checkbox Code */
            if (chkRememberMe.Checked)
            {
                Response.Cookies["EmpUserName"].Expires = DateTime.Now.AddDays(30);
                Response.Cookies["EmpPassword"].Expires = DateTime.Now.AddDays(30);
            }
            else
            {
                Response.Cookies["EmpUserName"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["EmpPassword"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Cookies["EmpUserName"].Value = txtEmail.Text.Trim();
            Response.Cookies["EmpPassword"].Value = txtPassword.Text.Trim();
            /* Checkbox Code */
            
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            con.Open();
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from tblEmployee where emp_email='" + txtEmail.Text.Trim() + "' and emp_password='" + txtPassword.Text.Trim() + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    setSession();
                    Response.Redirect("EmpPanel.aspx");
                }
                else
                {
                    label1.Visible = true;
                    label1.Text = "Invalid Credentials";
                }
            }
            catch (Exception ex)
            {
                literal1.Visible = true;
                literal1.Text = ex.Message;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        protected void setSession()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            con.Open();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT emp_id,emp_password from tblEmployee where emp_email='" + txtEmail.Text.Trim() + "' and emp_password='" + txtPassword.Text.Trim() + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Session["emp_id"] = dt.Rows[0][0].ToString();
                    hfEmpId.Value = dt.Rows[0][0].ToString();
                    Session["emp_password"] = dt.Rows[0][1].ToString();
                }

            }
            catch (Exception ex)
            {
                literal1.Visible = true;
                literal1.Text = ex.Message;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}