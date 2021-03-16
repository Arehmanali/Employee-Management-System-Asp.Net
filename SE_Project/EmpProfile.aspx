<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpProfile.aspx.cs" Inherits="SE_Project.EmpProfile" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>
<html>

<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <title>Employee Details</title>
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i">
    <link rel="stylesheet" href="assets/fonts/fontawesome-all.min.css">
    <link rel="stylesheet" href="assets/fonts/font-awesome.min.css">
    <link rel="stylesheet" href="assets/fonts/line-awesome.min.css"> 
    <link rel="stylesheet" href="assets/fonts/material-icons.min.css">
    <link rel="stylesheet" href="assets/fonts/fontawesome5-overrides.min.css">
    <link rel="stylesheet" href="assets/css/Footer-Basic.css">
    <link rel="stylesheet" href="assets/css/Highlight-Blue.css">
    <link rel="stylesheet" href="assets/css/Icon-Button.css">
    <link rel="stylesheet" href="assets/css/Navigation-with-Button.css">
    <link rel="stylesheet" href="assets/css/Style.css">
</head>

<body class="bg-gradient-primary">
    <form id="form1" runat="server">
        <div class="container">

            <div class="card shadow-lg o-hidden border-0 my-5">
                <div class="card-header">
                    <h2 class="text-center">Employee Details&nbsp;</h2>
                </div>
                <div class="card-body p-0">
                    <asp:Literal ID="ltError" runat="server" Visible="false"></asp:Literal>
                    <div class="row">
                        <div class="col">
                            <div class="card" style="margin-top: 10px;">
                                <div class="card-header">
                                    <h4 class="text-center">Basic Info</h4>
                                </div>
                                <div class="card-body">
                                    <div class="row">
                                        <div class="col-lg-7 offset-lg-0">
                                            <div class="p-5" style="padding-left: 48px;">
                                                <div class="text-center"></div>
                                                <div class="user">
                                                    <div class="form-group row">
                                                        <div class="col-sm-6 mb-3 mb-sm-0">
                                                            <h6>Employee Id</h6>
                                                            <asp:TextBox ID="txtEmpId" runat="server" class="border rounded form-control form-control-user"></asp:TextBox>
                                                            
                                                        </div>
                                                    </div>
                                                    <div class="form-group row">
                                                        <div class="col-sm-6 mb-3 mb-sm-0">
                                                            <h6>Name</h6>
                                                            <asp:TextBox ID="txtName" runat="server" class="border rounded form-control form-control-user"></asp:TextBox>
                                                            <asp:RegularExpressionValidator ID="revFirstName" ValidationGroup="group1" runat="server" ControlToValidate="txtName" ForeColor="Red" ValidationExpression="^[A-Z][a-z]*(\s[A-Z][a-z]*)+$" Display="Dynamic" ErrorMessage="Must Contain Alphabets" />
                                                            <asp:RequiredFieldValidator ID="rfvName" ValidationGroup="group1" runat="server" ControlToValidate="txtName" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                        
                                                        </div>
                                                        <div class="col-sm-6">
                                                            <h6>Father Name </h6>
                                                            <asp:TextBox ID="txtFatherName" runat="server" class="border rounded form-control form-control-user"></asp:TextBox>
                                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ValidationGroup="group1" runat="server" ControlToValidate="txtFatherName" ForeColor="Red" ValidationExpression="^^[A-Z][a-z]*(\s[A-Z][a-z]*)+$" Display="Dynamic" ErrorMessage="Must Contain Alphabets" />
                                                        </div>
                                                    </div>
                                                    <div class="form-group row">
                                                        <div class="col-sm-6 mb-3 mb-sm-0" style="padding-right: 50px;">
                                                            <h6>Date of Birth</h6>
                                                            <table>
                                                                <tr>
                                                                    <td>
                                                                        <asp:TextBox ID="txtDoB" runat="server" class="border rounded form-control" Style="width: 200px;"></asp:TextBox>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Image ID="Imbtn1" runat="server" ImageUrl="~/assets/img/cal.png" Image-Align="Top" Height="24px" Width="23px" />
                                                                        <ajaxToolkit:CalendarExtender ID="cal1" PopupButtonID="Imbtn1" runat="server" TargetControlID="txtDoB" Format="dd/MM/yyyy"></ajaxToolkit:CalendarExtender>
                                                                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                                                                        </asp:ScriptManager>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="group1" runat="server" ControlToValidate="txtDoB" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                                        </div>
                                                    </div>
                                                    <div class="form-group row">
                                                        <div class="col-sm-6 col-lg-8 mb-3 mb-sm-0" style="padding-right: 50px;">
                                                            <h6>Gender</h6>
                                                            <div class="form-row">
                                                                <div class="col">
                                                                    <div class="form-check">
                                                                        <asp:RadioButton ID="btnMale" runat="server" class="form-check-input" Text="Male" GroupName="gender" />
                                                                    </div>
                                                                </div>
                                                                <div class="col">
                                                                    <div class="form-check">
                                                                        <asp:RadioButton ID="btnFemale" runat="server" class="form-check-input" Text="Female" GroupName="gender" />
                                                                    </div>
                                                                </div>
                                                                <div class="col">
                                                                    <asp:RadioButton ID="btnOther" runat="server" class="form-check-input" Text="Other" GroupName="gender" />
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>

                                                    <div class="form-group row">
                                                        <div class="col-sm-6 mb-3 mb-sm-0" style="margin-top: 20px; padding-right: 50px;">
                                                            <div class="dropdown">
                                                                <h6>Department</h6>
                                                                <asp:TextBox ID="txtDepartment" runat="server" class="border rounded form-control" Style="width: 240px; padding-bottom: 6px; margin-bottom: 15px;"></asp:TextBox>
                                                            </div>
                                                        </div>
                                                        <div class="col-sm-6" style="margin-top: 20px; padding-right: 50px;">
                                                            <div class="dropdown">
                                                                <h6>Designation</h6>
                                                                <asp:TextBox ID="txtDesignation" runat="server" class="border rounded form-control" Style="width: 240px; padding-bottom: 6px; margin-bottom: 15px;"></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="form-group row">
                                                        <div class="col-sm-6 mb-3 mb-sm-0" style="padding-right: 50px;">
                                                            <div class="dropdown">
                                                                <h6>Degree</h6>
                                                                <asp:TextBox ID="txtDegree" runat="server" class="border rounded form-control" Style="width: 240px;"></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-4">
                                            <div>
                                                <asp:Image ID="imgEmp" runat="server" class="rounded-circle mb-3 mt-4" Width="160" Height="160" Style="width: 150px; height: 150px;" />

                                                <div class="mb-3">
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <asp:Button ID="btnSaveImage" runat="server" Text="Save" OnClick="btnSaveImage_Click" />
                                                            </td>
                                                            <td>
                                                                <asp:FileUpload ID="FileUpload1" runat="server" Text="Brows Image"></asp:FileUpload>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div class="card">
                                <div class="card-header" style="margin-top: 10px;">
                                    <h4 class="text-center">Contact Info</h4>
                                </div>
                                <div class="card-body">
                                    <div class="row">
                                        <div class="col">
                                            <div class="user">
                                                <div class="form-group row">
                                                    <div class="col-sm-6 col-xl-12 mb-3 mb-sm-0">
                                                        <h5>Address</h5>
                                                        <asp:TextBox ID="txtAddress" runat="server" class="border rounded form-control form-control-user" Style="margin-top: 0px; width: 410px;"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="group1" runat="server" ControlToValidate="txtAddress" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                                    </div>
                                                </div>
                                                <div class="form-group row">
                                                    <div class="col">
                                                        <h5>Email</h5>
                                                        <asp:TextBox ID="txtEmail" runat="server" class="form-control" Style="width: 410px; margin-left: 0px;"></asp:TextBox>
                                                        <asp:RegularExpressionValidator ID="revUsername" ValidationGroup="group1" runat="server" ControlToValidate="txtEmail" ForeColor="Red" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" Display="Dynamic" ErrorMessage="Invalid username" />
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="group1" runat="server" ControlToValidate="txtEmail" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                        
                                                    </div>
                                                </div>
                                                <div class="form-group row">
                                                    <div class="col">
                                                        <h5>CNIC</h5>
                                                        <asp:TextBox ID="txtCNIC" TextMode="Phone" runat="server" class="form-control" Style="width: 410px; margin-left: 0px;"></asp:TextBox>
                                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationGroup="group1" runat="server" ControlToValidate="txtCNIC" ForeColor="Red" ValidationExpression="^[0-9]{13}$" Display="Dynamic" ErrorMessage="Invalid CNIC" />
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="group1" runat="server" ControlToValidate="txtCNIC" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                        
                                                    </div>
                                                </div>
                                                <div class="form-group row">
                                                    <div class="col">
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col">
                                            <div class="form-group row">
                                                <div class="col">
                                                    <h5>City</h5>
                                                    <asp:TextBox ID="txtCity" runat="server" class="form-control" Style="width: 410px; margin-left: 0px;"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ValidationGroup="group1" runat="server" ControlToValidate="txtCity" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                                </div>
                                            </div>
                                            <div class="form-group row">
                                                <div class="col">
                                                    <h5>Contact</h5>
                                                    <asp:TextBox ID="txtContact" runat="server" TextMode="Number" class="form-control" Style="width: 410px; margin-left: 0px;"></asp:TextBox>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ValidationGroup="group1" runat="server" ControlToValidate="txtContact" ForeColor="Red" ValidationExpression="^[0-9]{10}$" Display="Dynamic" ErrorMessage="Invalid Contact" />
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ValidationGroup="group1" runat="server" ControlToValidate="txtContact" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                                </div>
                                            </div>
                                            <div class="form-group row">
                                                <div class="col">
                                                    <h5>Salary</h5>
                                                    <asp:TextBox ID="txtSalary" runat="server" TextMode="Number" class="form-control" Style="width: 410px; margin-left: 0px;"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row" style="margin-bottom: 20px; margin-top: 10px;">
                        <div class="col offset-xl-5">
                            <asp:Button ID="btnSubmit" causesvalidation="true" runat="server" ValidationGroup="group1" class="btn btn-success" Style="width: 150px; height: 38px; color: rgb(254,255,249);" Text="Update" OnClick="btnSubmit_Click" />
                            <asp:Button ID="btnCancel" runat="server" class="btn btn-primary" Style="margin-left: 10px; height: 38px; width: 150px;" Text="Cancel" OnClick="btnCancel_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <script src="assets/js/jquery.min.js"></script>
        <script src="assets/bootstrap/js/bootstrap.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.4.1/jquery.easing.js"></script>
        <script src="assets/js/theme.js"></script>
    </form>

</body>

</html>
