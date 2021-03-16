using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace SE_Project
{
    public partial class EmpRegisteration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ltError.Visible = false;
                PopulateDdlDep();
                PopulateDdlDesign();
            }
        }

        protected string GetDepId(string depName)
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            string depId = null;
            con.Open();
            try
            {
                string com = "select dep_id from tblDepartment where dep_name ='" + depName + "'";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
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
                string com = "select design_id from tblDesignations where design_name ='" + designName + "'";
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
                string com1 = "Select * from tblEmployee where emp_id='" + txtEmpId.Text + "'";
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
                    else if (gender == "Female")
                    {
                        btnFemale.Checked = true;
                    }
                    else
                    {
                        btnOther.Checked = true;
                    }
                }
                string com2 = "Select dep_name,design_name, sal_amount from tblEmployee inner join tblDepartment on emp_dep = dep_id inner join tblDesignations on emp_design = design_id inner join tblSalary on emp_salary = sal_id where emp_id='" + txtEmpId.Text + "'";
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

                string com3 = "Select CONVERT(varchar(10), emp_dob, 103) AS birth_date,CONVERT(varchar(10), emp_join_date, 103) AS join_date from tblEmployee  where emp_id='" + txtEmpId.Text + "'";
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

       

        protected void InsertEmpDesign()
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

        protected void InsertEmpDep()
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into tblEmployee set emp_dep=@empDep where emp_id='" + Request.QueryString["emp_id"].ToString() + "'", con);
                cmd.Parameters.AddWithValue("@empDep", GetDepId(ddlDep.SelectedItem.Value));
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


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True");
            string gender = null;
            if(txtJoiningDate.Text !="" && txtDoB.Text !="")
            {
                DateTime dob = DateTime.ParseExact(txtDoB.Text, "dd/MM/yyyy", null);
                var newDoB = dob.ToString("yyyy/MM/dd");
                //dob = Convert.ToDateTime(dob, System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);
                DateTime joinDate = DateTime.ParseExact(txtJoiningDate.Text, "dd/MM/yyyy", null);
                var newJoinDate = joinDate.ToString("yyyy/MM/dd");
                //joinDate = Convert.ToDateTime(joinDate, System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);

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

                //InsertEmpDep();
                //InsertEmpDesign();
                con.Open();
                try
                {
                    string com = "insert into tblEmployee(emp_id,emp_name,emp_father_name,emp_dob,emp_join_date,emp_dep,emp_design,emp_degree,emp_address,emp_city,emp_email,emp_contact,emp_cnic,emp_password,emp_gender,emp_salary_amount) values(@empId,@empName,@empFatherName,@empDoB,@empJoinDate,@empDep,@empDesign,@empDegree,@empAddress,@empCity,@empEmail,@empContact,@empCnic,@empPassword,@empGender,@empSalAmount)";
                    SqlCommand cmd = new SqlCommand(com, con);
                    cmd.Parameters.AddWithValue("@empId", txtEmpId.Text);
                    cmd.Parameters.AddWithValue("@empName", txtName.Text);
                    cmd.Parameters.AddWithValue("@empFatherName", txtFatherName.Text);
                    cmd.Parameters.AddWithValue("@empDoB", newDoB);
                    cmd.Parameters.AddWithValue("@empJoinDate", newJoinDate);
                    cmd.Parameters.AddWithValue("@empDegree", txtDegree.Text);
                    // cmd.Parameters.AddWithValue("@empImage", txtEmpId.Text);
                    cmd.Parameters.AddWithValue("@empAddress", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@empCity", txtCity.Text);
                    cmd.Parameters.AddWithValue("@empEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@empContact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@empPassword", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@empCnic", txtCNIC.Text);
                    cmd.Parameters.AddWithValue("@empGender", gender);
                    cmd.Parameters.AddWithValue("@empDep", GetDepId(ddlDep.SelectedItem.Text));
                    cmd.Parameters.AddWithValue("@empDesign", GetDesignId(ddlDesign.SelectedItem.Text));
                    cmd.Parameters.AddWithValue("@empSalAmount", txtSalary.Text);

                    cmd.ExecuteNonQuery();
                    ltError.Visible = true;
                    ltError.Text = "<span style='color:green'>New Employee Added Successfully</span>";
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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employee.aspx");
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
                ltError.Text = "<span style='color:red'>File not supported</span>";
            }

                try
                {
                    string connectionString = "Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=EmployeeManagementSystem;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "insert into tblImages values(@imgId, @filename, @fileextension, @filesize, @filecontent)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@imgId", txtEmpId.Text);
                        cmd.Parameters.AddWithValue("@filename", filename);
                        cmd.Parameters.AddWithValue("@fileextension", fileextension);
                        cmd.Parameters.AddWithValue("@filesize", filesize);
                        cmd.Parameters.AddWithValue("@filecontent", bytes);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        ShowImage();
                        ltError.Visible = true;
                        ltError.Text = "<span style='color:green'>Image Added Successfuly</span>";
                    con.Close();
                    }
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
                    string query = "select * from tblImages where img_id='" + txtEmpId.Text + "'";
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
    }
}