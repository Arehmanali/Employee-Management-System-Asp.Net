using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;

namespace SE_Project.Admin
{
    public partial class EmpDetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ltError.Visible = false;
                txtEmpId.Attributes.Add("readonly", "readonly");
                PopulateDdlDep();
                PopulateDdlDesign();
                ShowImage();
                PopulateForm();
            }
        }

        protected string GetDepId(string depName)
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            string depId = null;
            con.Open();
            try
            {
                string com = "select dep_id from tblDepartment where dep_name ='"+depName+"'";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    depId = dt.Rows[0][0].ToString();
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
            return depId;
        }

        protected string GetDesignId(string designName)
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            string designId = null;
            con.Open();
            try
            {
                string com = "select design_id from tblDesignations where design_name ='" +designName+ "'";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    designId = dt.Rows[0][0].ToString();
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
            return designId;
        }

        protected void UpdateEmpDesign()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update tblEmployee set emp_design=@empDesign where emp_id='" + Request.QueryString["emp_id"].ToString() + "'", con);
                cmd.Parameters.AddWithValue("@empDesign", GetDesignId(ddlDesign.SelectedItem.Text));
                cmd.ExecuteNonQuery();
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

        protected void UpdateEmpDep()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update tblEmployee set emp_dep=@empDep where emp_id='"+Request.QueryString["emp_id"].ToString()+"'", con);
                cmd.Parameters.AddWithValue("@empDep", GetDepId(ddlDep.SelectedItem.Text));
                cmd.ExecuteNonQuery();
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

        private void UpdateEmpData()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            string gender = null;
            if(txtDoB.Text !="" && txtJoiningDate.Text !="")
            {
                DateTime dob = DateTime.ParseExact(txtDoB.Text, "dd/MM/yyyy", null);
                var newDoB = dob.ToString("yyyy/MM/dd");
                DateTime joinDate = DateTime.ParseExact(txtJoiningDate.Text, "dd/MM/yyyy", null);
                var newJoinDate = joinDate.ToString("yyyy/MM/dd");

                if (btnMale.Checked == true)
                {
                    gender = "Male";
                }
                else if (btnFemale.Checked == true)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Other";
                }
                UpdateEmpDep();
                UpdateEmpDesign();
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update tblEmployee set emp_id=@empId,emp_name=@empName,emp_father_name=@empFatherName,emp_dob=@empDoB,emp_join_date=@empJoinDate,emp_degree=@empDegree, emp_address=@empAddress,emp_city=@empCity,emp_email=@empEmail, emp_contact=@empContact, emp_Cnic=@empCnic, emp_password=@empPassword, emp_gender=@empGender, emp_salary_amount=@empSalAmount where emp_id=@empId", con);

                    cmd.Parameters.AddWithValue("@empId", txtEmpId.Text);
                    cmd.Parameters.AddWithValue("@empName", txtName.Text);
                    cmd.Parameters.AddWithValue("@empFatherName", txtFatherName.Text);
                    cmd.Parameters.Add("@empDoB", SqlDbType.Date).Value = newDoB;
                    cmd.Parameters.AddWithValue("@empSalAmount", txtSalary.Text);
                    cmd.Parameters.Add("@empJoinDate", SqlDbType.Date).Value = newJoinDate;
                    //cmd.Parameters.AddWithValue("@empJoinDate", newJoinDate);
                    cmd.Parameters.AddWithValue("@empDegree", txtDegree.Text);
                    cmd.Parameters.AddWithValue("@empAddress", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@empCity", txtCity.Text);
                    cmd.Parameters.AddWithValue("@empEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@empContact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@empPassword", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@empCnic", txtCNIC.Text);
                    cmd.Parameters.AddWithValue("@empGender", gender);

                    cmd.ExecuteNonQuery();
                    ltError.Visible = true;
                    ltError.Text = "<span style='color:green'>Employee data Updated Successfully</span>";
                    con.Close();
                    PopulateForm();
                }
                catch (SqlException ex)
                {
                    ltError.Visible = true;
                    ltError.Text = ex.Message;
                }
            }
            
        }

        protected void PopulateDdlDep()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            con.Open();
            try 
            {
                string com = "Select * from tblDepartment";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                ddlDep.DataSource = dt;
                ddlDep.DataBind();
                ddlDep.DataTextField = "dep_name";
                ddlDep.DataValueField = "dep_id";
                ddlDep.DataBind();
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


        protected void PopulateForm()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            string gender = null;
            con.Open();
            try
            {
                string com1 = "Select * from tblEmployee where emp_id='" + Request.QueryString["emp_id"].ToString() + "'";
                SqlDataAdapter adpt = new SqlDataAdapter(com1, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtEmpId.Text = dt.Rows[0]["emp_id"].ToString();
                    txtName.Text = dt.Rows[0]["emp_name"].ToString();
                    txtFatherName.Text = dt.Rows[0]["emp_father_name"].ToString();
                    //Label2.Text = dt.Rows[0]["emp_image"].ToString();
                    //DateTime dob = Convert.ToDateTime(dt.Rows[0]["emp_dob"].ToString());
                    //txtDoB.Text = dob.ToString();
                    //DateTime joiningDate = Convert.ToDateTime(dt.Rows[0]["emp_join_date"].ToString());
                    //txtJoiningDate.Text = joiningDate.ToString();
                    txtDegree.Text = dt.Rows[0]["emp_degree"].ToString();
                    txtAddress.Text = dt.Rows[0]["emp_address"].ToString();
                    txtCity.Text = dt.Rows[0]["emp_city"].ToString();
                    txtEmail.Text = dt.Rows[0]["emp_email"].ToString();
                    txtContact.Text = dt.Rows[0]["emp_contact"].ToString();
                    txtCNIC.Text = dt.Rows[0]["emp_cnic"].ToString();
                    txtPassword.Text = dt.Rows[0]["emp_password"].ToString();
                    txtSalary.Text = dt.Rows[0]["emp_salary_amount"].ToString();
                    gender = dt.Rows[0]["emp_gender"].ToString();

                    if (gender == "Male")
                    {
                        btnMale.Checked = true;
                    }
                    else if(gender == "Female")
                    {
                        btnFemale.Checked = true;
                    }
                    else
                    {
                        btnOther.Checked = true;
                    }
                }
                string com2 = "Select dep_name,design_name from tblEmployee inner join tblDepartment on emp_dep = dep_id inner join tblDesignations on emp_design = design_id where emp_id='" + Request.QueryString["emp_id"].ToString() + "'";
                SqlDataAdapter adpt2 = new SqlDataAdapter(com2, con);
                DataTable dt2 = new DataTable();
                adpt2.Fill(dt2);
                if (dt2.Rows.Count > 0)
                {
                    //ddlDep.Items.FindByValue(dt2.Rows[0][0].ToString()).Selected = true;
                    ddlDep.SelectedItem.Text = dt2.Rows[0][0].ToString();
                    //ddlDesign.Items.FindByValue(dt2.Rows[0][1].ToString()).Selected = true;
                    ddlDesign.SelectedItem.Text = dt2.Rows[0][1].ToString();
                    
                }

                string com3 = "Select CONVERT(varchar(10), emp_dob, 103) AS birth_date,CONVERT(varchar(10), emp_join_date, 103) AS join_date from tblEmployee  where emp_id='" + Request.QueryString["emp_id"].ToString() + "'";
                SqlDataAdapter adpt3 = new SqlDataAdapter(com3, con);
                DataTable dt3 = new DataTable();
                adpt3.Fill(dt3);
                if (dt3.Rows.Count > 0)
                {
    
                    txtDoB.Text = dt3.Rows[0]["birth_date"].ToString();
                    txtJoiningDate.Text = dt3.Rows[0]["join_date"].ToString();
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

        protected void PopulateDdlDesign()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");

            con.Open();
            try
            {
                string com = "Select * from tblDesignations";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                ddlDesign.DataSource = dt;
                ddlDesign.DataBind();
                ddlDesign.DataTextField = "design_name";
                ddlDesign.DataValueField = "design_id";
                ddlDesign.DataBind();
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
            UpdateEmpData();
            PopulateForm();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPanel.aspx");
        }

        protected bool imagePresent()
        {
            bool imgPresent = false;
            string connectionString = "Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "select * from tblImages where img_id='" + Request.QueryString["emp_id"].ToString() + "'";
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
                ltError.Text = "<span style='color:Red'>File not supported</span>";
            }

            if(imagePresent())
            {
                try
                {
                    string connectionString = "Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "update tblImages set img_filename=@filename, img_fileextension=@fileextension, img_filesize=@filesize, img_filecontent=@filecontent where img_id='" + Request.QueryString["emp_id"].ToString() + "'";
                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@filename", filename);
                        cmd.Parameters.AddWithValue("@fileextension", fileextension);
                        cmd.Parameters.AddWithValue("@filesize", filesize);
                        cmd.Parameters.AddWithValue("@filecontent", bytes);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ShowImage();

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
                        string query = "insert into tblImages values(@imgId, @filename, @fileextension, @filesize, @filecontent)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@imgId", Request.QueryString["emp_id"].ToString());
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

        protected void DeleteEmpData()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");

            try
            {
                con.Open();
                var empId = txtEmpId.Text;
                SqlCommand cmdDelImg = new SqlCommand("delete from tblImages where img_id=@imgId",con);
                cmdDelImg.Parameters.AddWithValue("@imgId", Request.QueryString["emp_id"].ToString());
                cmdDelImg.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand("delete from tblSalary where sal_empId=@empId", con);
                cmd.Parameters.AddWithValue("@empId", empId);
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("delete from tblAttendance where attend_emp=@empId", con);
                cmd1.Parameters.AddWithValue("@empId", empId);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("delete from tblLeave where leave_emp=@empId", con);
                cmd2.Parameters.AddWithValue("@empId", empId);
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand("delete from tblEmployee where emp_id=@empId", con);
                cmd3.Parameters.AddWithValue("@empId", empId);
                cmd3.ExecuteNonQuery();
                con.Close();
                ltError.Visible = true;
                ltError.Text = "<span style='color:Green'>Employee with Emp Id " + empId + " Deleted Successfully</span>";
                txtEmpId.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                txtCity.Text = "";
                txtCNIC.Text = "";
                txtDegree.Text = "";
                txtDoB.Text = "";
                txtJoiningDate.Text = "";
                txtFatherName.Text = "";
                txtName.Text = "";
                txtSalary.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                btnMale.Checked = false;
                btnFemale.Checked = false;
                btnOther.Checked = false;
                ddlDep.SelectedItem.Text= "";
                ddlDesign.SelectedItem.Text = "";
            }
            catch (SqlException ex)
            {
                ltError.Visible = true;
                ltError.Text = ex.Message;
            }
        }

        protected void ShowImage()
        {
            string connectionString = "Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "select * from tblImages where img_id='"+Request.QueryString["emp_id"]+"'";
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
                        imgEmp.ImageUrl = "data:Image/png;base64," + str;
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

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEmpData();
        }
    }
}