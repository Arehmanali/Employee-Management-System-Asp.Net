<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepRegisteration.aspx.cs" Inherits="SE_Project.DepRegisteration" %>

<!DOCTYPE html>
<html>

<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <title>Department Registeration</title>
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
    <form runat="server">
        <div class="container">
        <div class="card shadow-lg o-hidden border-0 my-5">
            <div class="card-header">
                <h2 class="text-center">Add an Department&nbsp;<i class="fas fa-home"></i></h2>
            </div>
            <div class="card-body p-0">
                <div class="row">
                    <div class="col">
                        <div class="card" style="margin-top: 10px;">
                            <div class="card-body">
                                <asp:Literal ID="ltError" runat="server" Visible="false"></asp:Literal>
                                <div class="row">
                                    <div class="col-lg-7 offset-lg-3">
                                        <div class="p-5" style="padding-left: 48px;">
                                            <div class="text-center"></div>
                                            <div class="user" runat="server">
                                                <div class="form-group row">
                                                    <div class="col-sm-6 col-lg-12 mb-3 mb-sm-0" style="width: 300px;">
                                                        <h5>Department ID</h5>
                                                        <asp:TextBox ID="txtDepId" runat="server" class="form-control" placeholder="Department ID"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="rfvDepId" runat="server" ControlToValidate="txtDepId" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                                    </div>
                                                    <div class="col-sm-6 col-lg-12 mb-3 mb-sm-0" style="width: 300px;margin-top: 20px;">
                                                        <h5>Department Name</h5>
                                                        <asp:TextBox ID="txtDepName" runat="server" class="form-control" placeholder="Department Name"></asp:TextBox>
                                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtDepName" ForeColor="Red" ValidationExpression="^[A-Z][a-z]*(\s[A-Z][a-z]*)+$" Display="Dynamic" ErrorMessage="Must Contain Alphabets" />
                                                        <asp:RequiredFieldValidator ID="rfvDepName" runat="server" ControlToValidate="txtDepName" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col offset-xl-1">
                                                    <asp:Button ID="btnSubmit" runat="server" CausesValidation="true" class="btn btn-success" style="width: 190px;" Text="Submit" OnClick="btnSubmit_Click" />
                                                    <asp:Button ID="btnCancel" runat="server" CausesValidation="false" class="btn btn-primary" style="width: 190px;margin-left: 20px;" Text="Cancel" OnClick="btnCancel_Click" />
                                                </div>
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
                        <div class="card"></div>
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
