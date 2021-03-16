<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="MarkAttendance.aspx.cs" Inherits="SE_Project.Admin.MarkAttendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div class="card shadow"></div>
        <div class="card" style="margin-top: 10px;">
            <div class="card-header">
                <h4 class="text-center"><i class="fa fa-check"></i>&nbsp;Mark Attendance</h4>
            </div>
            <div class="card-body">
                <asp:Literal ID="ltError" runat="server" Visible="false"></asp:Literal>
                <div class="row">
                    <div class="col-lg-7 offset-lg-0">
                        <div class="p-5" style="padding-left: 48px;">
                            <div class="text-center"></div>
                            <div class="user">
                                <h6></h6>
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0" style="padding-right: 50px;">
                                        <h6>Date of Attendance</h6>
                                        <table>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="txtAttendanceDate" runat="server" class="border rounded form-control" Style="width: 200px;"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:Image ID="Imbtn1" runat="server" ImageUrl="~/assets/img/cal.png" Image-Align="Top" Height="24px" Width="23px" />
                                                    <ajaxToolkit:CalendarExtender ID="cal1" PopupButtonID="Imbtn1" runat="server" TargetControlID="txtAttendanceDate" Format="dd/MM/yyyy">
                                                    </ajaxToolkit:CalendarExtender>
                                                </td>
                                            </tr>
                                        </table>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAttendanceDate" ForeColor="Red" Display="Dynamic" ErrorMessage="Required Field" />
                                    </div>
                                </div>
                                <div class="dropdown">
                                    <asp:DropDownList ID="ddlDep" AutoPostBack="true" DataValueField="dep_id" DataTextField="dep_name" OnSelectedIndexChanged="ddlDep_SelectedIndexChanged" runat="server" class="dropdown-toggle border rounded" Style="width: 240px; height: 50px; background-color: rgb(255,255,255); color: rgb(113,109,108); padding-bottom: 6px; margin-bottom: 15px;">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlDep" ForeColor="Red" Display="Dynamic" ErrorMessage="Required Field" />
                                </div>
                                <div class="dropdown">
                                    <asp:DropDownList ID="ddlEmp" DataValueField="emp_id" DataTextField="emp_name" runat="server" class="dropdown-toggle border rounded" Style="width: 240px; height: 50px; background-color: rgb(255,255,255); color: rgb(113,109,108); padding-bottom: 6px; margin-bottom: 15px;">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvEmp" runat="server" ControlToValidate="ddlEmp" ForeColor="Red" Display="Dynamic" ErrorMessage="Required Field" />
                                </div>
                            </div>
                            <div class="text-center">
                            </div>
                            <asp:Button ID="btnPresent" class="btn btn-success" runat="server" Text="Present" Style="margin: 0px; margin-right: 20px; width: 100px;" OnClick="btnPresent_Click" />
                            <asp:Button ID="btnAbsent" class="btn btn-primary" runat="server" Text="Absent" Style="width: 100px; margin-left: 20px;" OnClick="btnAbsent_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
