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
    public partial class SiteMaster : MasterPage
    {
        SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin_id"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
           
            lblAdminName.Text = ReturnAdminName();
            ShowImageAdmin();

        }

        protected void ShowImageAdmin()
        {
            string connectionString = "Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "select * from tblImages where img_id='"+Session["admin_id"]+"'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        byte[] bytes = (byte[])dt.Rows[0]["img_filecontent"];
                        string str = Convert.ToBase64String(bytes);
                        imgAdmin.ImageUrl = "data:Image/png;base64," + str;
                    }
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                ltMessage.Visible = true;
                ltMessage.Text = ex.Message;
            }
        }


        protected string ReturnAdminName()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            string adminName = null;
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT CONCAT(admin_fname,' ',admin_lname) from tblAdmin where admin_id='" + Session["admin_id"] + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                adminName = dt.Rows[0][0].ToString();
            }
            catch (SqlException ex)
            {
                ltMessage.Visible = true;
                ltMessage.Text = ex.Message;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return adminName;
        }
    }
}