using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace SE_Project.Admin
{
    public partial class AdminProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ltError.Visible = false;
                PopulateForm();
                ShowImage();
            }
        }

        protected void PopulateForm()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            con.Open();
            try
            {
                string com1 = "Select * from tblAdmin where admin_id='" + Session["admin_id"] + "'";
                SqlDataAdapter adpt = new SqlDataAdapter(com1, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtUsername.Text = dt.Rows[0]["admin_email"].ToString();
                    txtFirstName.Text = dt.Rows[0]["admin_fname"].ToString();
                    txtLastName.Text = dt.Rows[0]["admin_lname"].ToString();
                    txtAddress.Text = dt.Rows[0]["admin_address"].ToString();
                    txtCity.Text = dt.Rows[0]["admin_city"].ToString();
                    txtCountry.Text = dt.Rows[0]["admin_country"].ToString();
                    txtContact.Text = dt.Rows[0]["admin_contact"].ToString();
                    txtCNIC.Text = dt.Rows[0]["admin_cnic"].ToString();
                    txtPassword.Text = dt.Rows[0]["admin_password"].ToString();
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

        
        private void UpdateAdminData()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update tblAdmin set admin_email=@adminEmail,admin_fname=@adminFname,admin_lname=@adminLname,admin_cnic=@adminCnic,admin_address=@adminAddress,admin_city=@adminCity, admin_country=@adminCountry,admin_contact=@adminContact,admin_password=@adminPassword where admin_id='"+Session["admin_id"]+"'", con);

                cmd.Parameters.AddWithValue("@adminEmail", txtUsername.Text);
                cmd.Parameters.AddWithValue("@adminFname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@adminLname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@adminCnic", txtCNIC.Text);
                cmd.Parameters.AddWithValue("@adminAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@adminCity", txtCity.Text);
                cmd.Parameters.AddWithValue("@adminCountry", txtCountry.Text);
                cmd.Parameters.AddWithValue("@adminContact", txtContact.Text);
                cmd.Parameters.AddWithValue("@adminPassword", txtPassword.Text);

                cmd.ExecuteNonQuery();
                ltError.Visible = true;
                ltError.Text = "Admin data Updated Successfully";
                con.Close();
      
            }
            catch (SqlException ex)
            {
                ltError.Visible = true;
                ltError.Text = ex.Message;
            }
        }

        protected bool imagePresent()
        {
            bool imgPresent = false;
            string connectionString = "Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "select * from tblImages where img_id='" + Session["admin_id"] + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        imgPresent = true;
                    }
                    else
                    {
                        imgPresent = false;
                    }
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                ltError.Visible = true;
                ltError.Text = ex.Message;
            }

            return imgPresent;
        }

        protected void btnSaveImage_Click(object sender, EventArgs e)
        {

            byte[] bytes = null;
            HttpPostedFile postedfile = FileUpload1.PostedFile;
            string filename = Path.GetFileName(postedfile.FileName);
            string fileextension = Path.GetExtension(postedfile.FileName);
            int filesize = postedfile.ContentLength;

            if (fileextension.ToLower() == ".jpg" || fileextension.ToLower() == ".bmp" || fileextension.ToLower() == ".gif" ||
                fileextension.ToLower() == ".png" || fileextension.ToLower() == ".jpeg")
            {
                Stream stream = postedfile.InputStream;
                BinaryReader binaryreader = new BinaryReader(stream);
                bytes = binaryreader.ReadBytes((int)stream.Length);
            }
            else
            {
                ltError.Visible = true;
                ltError.Text = "File fomate not supported";
            }

            if(imagePresent())
            {
                try
                {
                    string connectionString = "Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "update tblImages set img_filename=@filename, img_fileextension=@fileextension, img_filesize=@filesize, img_filecontent=@filecontent where img_id='" + Session["admin_id"] + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@filename", filename);
                        cmd.Parameters.AddWithValue("@fileextension", fileextension);
                        cmd.Parameters.AddWithValue("@filesize", filesize);
                        cmd.Parameters.AddWithValue("@filecontent", bytes);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        ShowImage();
                        con.Close();
                    }
                }
                catch (SqlException ex)
                {
                    ltError.Visible = true;
                    ltError.Text = ex.Message;
                }
            }
            else
            {
                try
                {
                    string connectionString = "Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "insert into tblImages values(@imgId, @filename, @fileextension, @filesize, @filecontent) where img_id = @imgId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@imgId", Session["admin_id"]);
                        cmd.Parameters.AddWithValue("@filename", filename);
                        cmd.Parameters.AddWithValue("@fileextension", fileextension);
                        cmd.Parameters.AddWithValue("@filesize", filesize);
                        cmd.Parameters.AddWithValue("@filecontent", bytes);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        ShowImage();
                        con.Close();
                    }
                }
                catch (SqlException ex)
                {
                    ltError.Visible = true;
                    ltError.Text = ex.Message;
                }
            }
            
            
        }
        
        
        protected void ShowImage()
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
                ltError.Visible = true;
                ltError.Text = ex.Message;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        { 
            UpdateAdminData();
            PopulateForm();
        }
    }
}