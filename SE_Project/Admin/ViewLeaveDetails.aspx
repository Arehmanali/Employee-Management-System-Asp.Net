<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewLeaveDetails.aspx.cs" Inherits="SE_Project.Admin.ViewLeaveDetails" %>

<!DOCTYPE html>
<html>

<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <title>View Leave Details</title>
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
    <form runat="server">
    <div class="container">
        <div class="card shadow-lg o-hidden border-0 my-5">
            <div class="card-header">
                <h2 class="text-center">Leave Details&nbsp;</h2>
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
                                    <div class="col-lg-8 offset-lg-0">
                                        <div class="p-5" style="padding-left: 48px;">
                                            <div class="text-center"></div>
                                            <div class="user">
                                                <div class="form-group row">
                                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                                        <div class="form-row">
                                                            <div class="col">
                                                                <label class="col-form-label">Name :&nbsp;</label>
                                                            </div>
                                                            <div class="col">
                                                                <asp:Label ID="lblEmpName" runat="server" class="col-form-label" style="color: rgb(67,102,207);"></asp:Label>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="col-sm-6 col-lg-6">
                                                        <div class="form-row">
                                                            <div class="col"><label class="col-form-label">Emp Id :&nbsp;</label></div>
                                                            <div class="col">
                                                                <asp:Label ID="lblEmpId" runat="server" class="col-form-label" style="color: rgb(67,102,207);"></asp:Label>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="form-group row">
                                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                                        <div class="form-row">
                                                            <div class="col">
                                                                <label class="col-form-label">Gender :&nbsp;</label>
                                                            </div>
                                                            <div class="col">
                                                                <asp:Label ID="lblEmpGender" runat="server" class="col-form-label" style="color: rgb(67,102,207);"></asp:Label>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="form-group row">
                                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                                        <div class="form-row">
                                                            <div class="col"><label class="col-form-label">Email Id:&nbsp;</label></div>
                                                            <div class="col">
                                                                <asp:Label ID="lblEmpEmail" runat="server" class="col-form-label" style="color: rgb(67,102,207);"></asp:Label>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="col-sm-6 col-lg-6">
                                                        <div class="form-row">
                                                            <div class="col"><label class="col-form-label">Contact :&nbsp;</label></div>
                                                            <div class="col">
                                                                <asp:Label ID="lblEmpContact" runat="server" class="col-form-label" style="color: rgb(67,102,207);"></asp:Label>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="form-group row">
                                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                                        <div class="form-row">
                                                            <div class="col"><label class="col-form-label">Department :&nbsp;</label></div>
                                                            <div class="col">
                                                                <asp:Label ID="lblEmpDep" runat="server" class="col-form-label" style="color: rgb(67,102,207);"></asp:Label>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="col-sm-6 col-lg-6">
                                                        <div class="form-row">
                                                            <div class="col"><label class="col-form-label">Designation :</label></div>
                                                            <div class="col">
                                                                <asp:Label ID="lblEmpDesign" runat="server" class="col-form-label" style="color: rgb(67,102,207);"></asp:Label>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-4">
                                        <div>
                                            <asp:Image ID="imgEmp" runat="server" style="margin: 20px;margin-left: 50px;width: 150px;height: 150px;"/>
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
                                <h4 class="text-center">Leave Info</h4>
                            </div>
                            <div class="card-body">
                                <div class="p-5" style="padding-left: 48px;">
                                    <div class="text-center"></div>
                                    <div class="user">
                                        <div class="form-group row">
                                            <div class="col-sm-6 mb-3 mb-sm-0">
                                                <div class="form-row">
                                                    <div class="col"><label class="col-form-label">Leave Type :&nbsp;</label></div>
                                                    <div class="col">
                                                        <asp:Label ID="lblLeaveType" runat="server" class="col-form-label" Style="color: rgb(67,102,207);"></asp:Label>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-sm-6 col-lg-6">
                                                <div class="form-row">
                                                    <div class="col"><label class="col-form-label">Leave Date :</label></div>
                                                    <div class="col">
                                                        <asp:Label ID="lblLeaveDate" runat="server" class="col-form-label" Style="color: rgb(67,102,207);"></asp:Label>
                                                        <asp:HiddenField ID="hfLeaveDate" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group row">
                                            <div class="col-sm-6 col-lg-12 mb-3 mb-sm-0">
                                                <div class="form-row">
                                                    <div class="col-lg-3"><label class="col-form-label">Employee Leave Remarks:&nbsp;</label></div>
                                                    <div class="col-lg-8">
                                                        <asp:Label ID="lblEmpRemark" runat="server" class="col-form-label" Style="color: rgb(67,102,207);"></asp:Label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group row">
                                            <div class="col-sm-6 col-lg-12 mb-3 mb-sm-0">
                                                <div class="form-row">
                                                    <div class="col-lg-3"><label class="col-form-label">Leave Status :</label></div>
                                                    <div class="col-lg-8">
                                                       <asp:Label ID="lblLeaveStatus" runat="server" class="col-form-label"></asp:Label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group row">
                                            <div class="col-sm-6 col-lg-12 mb-3 mb-sm-0">
                                                <div class="form-row">
                                                    <div class="col-lg-3"><label class="col-form-label">Admin Leave Remarks:&nbsp;</label></div>
                                                    <div class="col-lg-8">
                                                        <asp:TextBox ID="txtAdminRemark" TextMode="MultiLine" runat="server" class="col-form-label" Style="width:300px; color: rgb(67,102,207);"></asp:TextBox>
                                                       <!-- <asp:Label ID="lblAdminRemark" runat="server" class="col-form-label" Style="color: rgb(67,102,207);"></asp:Label> -->
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row text-left" style="margin-bottom: 20px;margin-top: 10px;">
                    <div class="col-lg-2 offset-xl-5 text-left">
                        <asp:Button ID="btnApprove" runat="server" Text="Approve" OnClick="btnApprove_Click" class="btn btn-success text-center" style="width: 150px;height: 40px;color: rgb(254,255,249);" />
                    </div>
                    <div class="col text-left">
                        <asp:Button ID="btnReject" runat="server" Text="Reject" OnClick="btnReject_Click" CssClass="btn btn-danger text-center" style="margin-left: 10px;height: 40px;width: 150px;" />
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
