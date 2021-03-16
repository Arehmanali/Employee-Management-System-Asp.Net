<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPasswordForget.aspx.cs" Inherits="SE_Project.AdminPasswordForget" %>

<!DOCTYPE html>
<html>

<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <title>Forgotten Password</title>
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
    <form id="form1" runat="server">
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-9 col-lg-12 col-xl-10">
                <div class="card shadow-lg o-hidden border-0 my-5">
                    <div class="card-body p-0">
                        <div class="row" style="height: 400px;">
                            <div class="col-auto col-lg-6 offset-lg-3 align-self-center">
                                <div class="text-center text-primary border-primary">
                                    <div class="text-center">
                                        <asp:Literal ID="ltError" runat="server" Visible="false"></asp:Literal>
                                        <h4 class="text-dark mb-2">Forgot Your Password?</h4>
                                        <p class="mb-4">We get it, stuff happens. Just enter your registered email address below and we'll send you your password!</p>
                                    </div>
                                    <div class="user" runat="server">
                                        <div class="form-group" runat="server">
                                            <asp:TextBox ID="txtEmail" runat="server" class="form-control form-control-user" placeholder="Enter email addresss ..."></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ForeColor="Red" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" Display = "Dynamic" ErrorMessage = "Invalid email address"/>
                                            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required" />
                                          </div>
                                        <asp:Button ID="btnReset" runat="server" class="btn btn-primary btn-block text-white btn-user" Text="Get Your Password" OnClick="btnReset_Click" />
                                        <asp:Label ID="lblMessage" runat="server" Visible="false"></asp:Label>
                                    </div>
                                    <div class="text-center">
                                        <hr>
                                    </div>
                                    <div class="text-center"><a class="small" href="AdminLogin.aspx">Back to Login!</a></div>
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
        </form>
</body>

</html>
