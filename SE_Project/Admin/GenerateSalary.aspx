<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="GenerateSalary.aspx.cs" Inherits="SE_Project.Admin.GenerateSalary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <asp:Literal ID="ltError" runat="server" Visible="false"></asp:Literal>
        <h3 class="text-center text-dark mb-1" style="color: rgb(76,113,221);">Generate Salary</h3>
        <div style="padding-top: 50px;">
            <div class="row">
                <table>
                    <div class="col-1">
                    </div>
                    <tr>
                        <td>
                            <asp:Label ID="lblMonth" runat="server" Text="Month"></asp:Label>
                        </td>
                        <td>
                            <div class="dropdown">
                                <asp:DropDownList ID="ddlMonth" runat="server" ValidationGroup="group1" class="dropdown-toggle border rounded" Style="background-color: rgb(255,255,255); color: rgb(137,139,153); width: 150px; height: 38px">
                                    <asp:ListItem Text="Select Month" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="January" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="February" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="March" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="April" Value="4"></asp:ListItem>
                                    <asp:ListItem Text="May" Value="5"></asp:ListItem>
                                    <asp:ListItem Text="June" Value="6"></asp:ListItem>
                                    <asp:ListItem Text="July" Value="7"></asp:ListItem>
                                    <asp:ListItem Text="August" Value="8"></asp:ListItem>
                                    <asp:ListItem Text="September" Value="9"></asp:ListItem>
                                    <asp:ListItem Text="October" Value="10"></asp:ListItem>
                                    <asp:ListItem Text="November" Value="11"></asp:ListItem>
                                    <asp:ListItem Text="December" Value="12"></asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="group1" runat="server"
                                    ControlToValidate="ddlMonth" ErrorMessage="!!" ForeColor="Red" Display="Dynamic"
                                    InitialValue="SELECT" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </div>
                        </td>
                        <td>
                            <div class="col-2"></div>
                        </td>
                        <td>
                            <asp:Label ID="lblYear" runat="server" Text="Current Year"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtYear" Text="2021" ValidationGroup="group1" runat="server" class="border rounded" Width="150px" Height="38px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="group1" runat="server"
                                ControlToValidate="txtYear" ErrorMessage="!!" ForeColor="Red" Display="Dynamic"
                                SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <div class="col-1">
                    </div>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Department"></asp:Label>
                        </td>
                        <td>
                            <div class="dropdown">
                                <asp:DropDownList ID="ddlDep" AutoPostBack="true" DataValueField="dep_id" DataTextField="dep_name" OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged" runat="server" class="dropdown-toggle border rounded" Style="width: 150px; height: 38px; background-color: rgb(255,255,255); color: rgb(113,109,108);">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlDep" ForeColor="Red" Display="Dynamic" ErrorMessage="Required Field" />
                            </div>
                        </td>
                        <td></td>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Employee"></asp:Label>
                        </td>
                        <td>
                            <div class="dropdown">
                                <asp:DropDownList ID="ddlEmp" DataValueField="emp_id" DataTextField="emp_name" runat="server" class="dropdown-toggle border rounded" Style="width: 150px; height: 38px; background-color: rgb(255,255,255); color: rgb(113,109,108);">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfvEmp" runat="server" ControlToValidate="ddlEmp" ForeColor="Red" Display="Dynamic" ErrorMessage="Required Field" />
                            </div>
                        </td>
                        <td>
                            <div class="col-10"></div>
                        </td>
                        <td>
                            <asp:Button ID="btnSelect" runat="server" ValidationGroup="group1" class="btn-primary" Text="SELECT" OnClick="btnSelect_Click" />
                        </td>
                    </tr>

                </table>
            </div>
        </div>
        <div class="container" style="padding-top: 20px; margin-top: 10px">
            <div style="background-color: #dcd6a7;">
                <div class="row">
                    <div class="col text-right">
                        <label class="col-form-label" style="color: rgb(71,108,217);">Salary :&nbsp;</label>
                    </div>
                    <div class="col">
                        <asp:Label ID="lblSalary" runat="server" class="col-form-label" Style="color: rgb(21,22,23);"></asp:Label>
                    </div>
                    <div class="col"></div>
                    <div class="col"></div>
                </div>
                <div class="row">
                    <div class="col text-right">
                        <label class="col-form-label" style="color: rgb(76,113,221);">Total Leaves :&nbsp;</label>
                    </div>
                    <div class="col">
                        <asp:Label ID="lblTotalLeaves" runat="server" class="col-form-label" Style="color: rgb(21,22,23);"></asp:Label>
                    </div>
                    <div class="col offset-lg-0 text-right">
                        <label class="col-form-label" style="color: rgb(76,113,221);">Travel Allowance :&nbsp;</label>
                    </div>
                    <div class="col text-left">
                        <asp:TextBox ID="txtTravelAllowance" runat="server" TextMode="Number" Style="width: 100px;" placeholder="Rs."></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtTravelAllowance" Display="Dynamic" ValidationGroup="group2" ErrorMessage="Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <div class="col text-right">
                        <label class="col-form-label" style="color: rgb(76,113,221);">Approved Leaves :</label>
                    </div>
                    <div class="col">
                        <asp:Label ID="lblApprovedLeaves" runat="server" class="col-form-label" Style="color: rgb(21,22,23);"></asp:Label>
                    </div>
                    <div class="col text-right">
                        <label class="col-form-label" style="color: rgb(76,113,221);">Medical Allowance :&nbsp;</label>
                    </div>
                    <div class="col">
                        <asp:TextBox ID="txtMedAllowance" runat="server" TextMode="Number" Style="width: 100px;" placeholder="Rs."></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtMedAllowance" Display="Dynamic" ValidationGroup="group2" ErrorMessage="Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <div class="col text-right">
                        <label class="col-form-label" style="color: rgb(76,113,221);">Leave Deduction :&nbsp;</label>
                    </div>
                    <div class="col">
                        <asp:Label ID="lblLeaveDeduction" runat="server" class="col-form-label" Style="color: red"></asp:Label>
                    </div>
                    <div class="col text-right">
                        <label class="col-form-label" style="color: rgb(76,113,221);">Washing Allowance :&nbsp;</label>
                    </div>
                    <div class="col">
                        <asp:TextBox ID="txtWashAllowance" runat="server" TextMode="Number" Style="width: 100px;" placeholder="Rs."></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvWashAllowance" Display="Dynamic" ValidationGroup="group2" runat="server" ControlToValidate="txtWashAllowance" ErrorMessage="Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <div class="col text-right">
                    </div>
                    <div class="col"></div>
                    <div class="col text-right" style="color: rgb(17,17,18);">
                        <asp:Button ID="btnGenerateSal" runat="server" OnClick="btnGenerateSal_Click" ValidationGroup="group2" class="btn btn-success text-right" style="margin-top: 20px; margin-bottom: 20px;" Text="Generate Salary" />
                    </div>
                    <div class="col"></div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
