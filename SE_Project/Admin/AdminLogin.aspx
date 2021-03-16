<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="SE_Project.Login" %>

<!DOCTYPE html>
<html>

<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <title>Admin Login</title>
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i">
    <link rel="stylesheet" href="assets/fonts/fontawesome-all.min.css">
    <link rel="stylesheet" href="assets/fonts/font-awesome.min.css">
    <link rel="stylesheet" href="assets/fonts/material-icons.min.css">
    <link rel="stylesheet" href="assets/fonts/typicons.min.css">
    <link rel="stylesheet" href="assets/fonts/fontawesome5-overrides.min.css">
    <link rel="stylesheet" href="assets/css/Footer-Basic.css">
    <link rel="stylesheet" href="assets/css/Highlight-Blue.css">
    <link rel="stylesheet" href="assets/css/Icon-Button.css">
    <link rel="stylesheet" href="assets/css/Navigation-with-Button.css">
    <link rel="stylesheet" href="assets/css/Style.css">
</head>

<body class="bg-gradient-primary">
    <div class="container">
        <div class="row justify-content-center">
           
            <div class="col-md-9 col-lg-12 col-xl-10">
                <div class="card shadow-lg o-hidden border-0 my-5">
                    <div class="card-body p-0">
                        <div class="row" style="height: 500px;padding-top: 10px;">
                            <div class="col-auto col-lg-6 offset-lg-3" style="height: 450px;">
                                <div class="text-left align-content-center"><img class="rounded-circle d-lg-flex align-items-center justify-content-lg-center align-items-lg-center" src="assets/img/generaluser.png" style="margin-left: 180px;">
                                    <div class="text-center">
                                        <asp:Literal ID="literal1" runat="server" Visible="false"></asp:Literal>
                                        <h4 class="text-dark mb-4">Member Login!</h4>
                                    </div>
                                    <form class="user" runat="server">
                                         <asp:HiddenField ID="hfAdminId" runat="server"/>
                                        <div class="form-group" runat="server">
                                            <asp:TextBox ID="txtEmail" runat="server" class="form-control form-control-user" placeholder="username"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ForeColor="Red" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" Display = "Dynamic" ErrorMessage = "Invalid username"/>
                                            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required" />
                                        </div>
                                        <div class="form-group" runat="server">
                                            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" class="form-control form-control-user" placeholder="Password"></asp:TextBox>
                                            <asp:RequiredFieldValidator runat="server" ID="rfvPassword" ControlToValidate="txtPassword" ErrorMessage="Please enter password" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                        <div class="form-group" runat="server">
                                            <asp:CheckBox ID="chkRememberMe"   Text="&nbsp&nbsp Remeber Me" runat="server" />
                                        </div>
                                        <asp:Button ID="btnLogin" runat="server" Text="Login" class="btn btn-primary btn-block text-white btn-user" OnClick="btnLogin_Click" />
                                         <asp:Label ID="label1" runat="server" Visible="false" ForeColor="Red"></asp:Label>
                                        <hr>
                                        <hr>
                                    </form>
                                    <div class="text-center"><a class="small" href="AdminPasswordForget.aspx">Forgot Password?</a></div>
                                    <div class="text-center"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.4.1/jquery.easing.js"></script>
    <script src="assets/js/theme.js"></script>
</body>

</html>