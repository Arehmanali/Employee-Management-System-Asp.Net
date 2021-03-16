using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Drawing;

namespace SE_Project
{
    public partial class AdminPasswordForget : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ltError.Visible = false;
                lblMessage.Visible = false;
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            con.Open();
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT admin_email, admin_password from tblAdmin where admin_email='" + txtEmail.Text.Trim() + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string adminEmail = dt.Rows[0]["admin_email"].ToString();
                    string adminPassword = dt.Rows[0]["admin_password"].ToString();

                    MailMessage mm = new MailMessage("merehmanali@gmail.com", txtEmail.Text);
                    mm.Subject = "Your Password !";
                    mm.Body = string.Format("Hello : <h1>{0}</h1> is your email address <br/> your password is <h1>{1}</h1>", adminEmail, adminPassword);
                    mm.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential nc = new NetworkCredential();
                    nc.UserName = "merehmanali@gmail.com";
                    nc.Password = "arehman786";
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = nc;
                    smtp.Port = 587;
                    smtp.Send(mm);
                    lblMessage.Visible = true;
                    lblMessage.Text = "Your password has been sent to " + txtEmail.Text + " . Visit your Inbox.";
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMessage.Visible = true;
                    lblMessage.Text = txtEmail.Text + " - This email address does not exist in our database !";
                    lblMessage.ForeColor = Color.Red;
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
    }
}