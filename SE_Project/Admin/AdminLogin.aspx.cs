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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* Checkbox Code */
            if (!IsPostBack)
            {
                if (Request.Cookies["UserName"] != null && Request.Cookies["Password"] != null)
                {
                    txtEmail.Text = Request.Cookies["UserName"].Value;
                    txtPassword.Attributes["value"] = Request.Cookies["Password"].Value;
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
                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(30);
                Response.Cookies["Password"].Expires = DateTime.Now.AddDays(30);
            }
            else
            {
                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Cookies["UserName"].Value = txtEmail.Text.Trim();
            Response.Cookies["Password"].Value = txtPassword.Text.Trim();
            /* Checkbox Code */
            
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            con.Open();
            try
            {
              
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from tblAdmin where admin_email='" + txtEmail.Text.Trim() + "' and admin_password='" + txtPassword.Text.Trim() + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    setSession();
                    Response.Redirect("AdminPanel.aspx");
                }
                else
                {
                    label1.Visible = true;
                    label1.Text = "Invalid Credentials";
                }
            }
            catch (SqlException ex)
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
                SqlDataAdapter sda = new SqlDataAdapter("SELECT admin_id from tblAdmin where admin_email='" + txtEmail.Text.Trim() + "' and admin_password='" + txtPassword.Text.Trim() + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count >0)
                {
                    int adminId = Convert.ToInt32( dt.Rows[0][0].ToString());
                    hfAdminId.Value = adminId.ToString();
                    Session["admin_id"] = adminId;
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