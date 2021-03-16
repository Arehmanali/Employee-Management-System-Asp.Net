<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="YearlySalaryReport.aspx.cs" Inherits="SE_Project.Admin.YearlySalaryReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container-fluid">
        <asp:Literal ID="ltError" runat="server" Visible="false"></asp:Literal>
        <h2 class="text-center text-dark mb-1" style="color: rgb(76,113,221);">Yearly Salary Reports</h2>
        <div style="padding-top: 50px;">
            <div class="row">
                <table>
                    <div class="col-1">
                    </div>
                    <tr>
                        <td>
                            <asp:Label ID="lblYear" runat="server" Text="Year"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtYear" Text="2021" ValidationGroup="group1" runat="server" class="border rounded" Width="150px" Height="38px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="group1" runat="server"
                                ControlToValidate="txtYear" ErrorMessage="!!" ForeColor="Red" Display="Dynamic"
                                SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <div class="col-2"></div>
                        </td>
                        <td>
                            
                        </td>
                        <td>
                            
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
                                <asp:DropDownList ID="ddlDep" AutoPostBack="true" DataValueField="dep_id" DataTextField="dep_name" OnSelectedIndexChanged="ddlDep_SelectedIndexChanged" runat="server" class="dropdown-toggle border rounded" Style="width: 150px; height: 38px; background-color: rgb(255,255,255); color: rgb(113,109,108);">
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
                                <asp:DropDownList ID="ddlEmp" AutoPostBack="true" OnSelectedIndexChanged="ddlEmp_SelectedIndexChanged" DataValueField="emp_id" DataTextField="emp_name" runat="server" class="dropdown-toggle border rounded" Style="width: 150px; height: 38px; background-color: rgb(255,255,255); color: rgb(113,109,108);">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfvEmp" runat="server" ControlToValidate="ddlEmp" ForeColor="Red" Display="Dynamic" ErrorMessage="Required Field" />
                            </div>
                        </td>
                        <td>
                            <div class="col-10"></div>
                        </td>
                        <td>
                          
                        </td>
                    </tr>

                </table>
            </div>
        </div>
        <div class="card shadow" style="margin-top:20px">
                <div class="card-header py-3">
                    <p class="text-primary m-0 font-weight-bold">Salary Report Sheet</p>
                </div>
                <div class="card-body">
                <div class="row">
                    <div class="col">
                        <div class="text-md-right dataTables_filter">
                            <label>
                                <input type="search" class="form-control form-control-sm" placeholder="Search" style="width: 300px;"></label>
                        </div>
                    </div>
                </div>
                <div class="table-responsive table mt-2" aria-describedby="dataTable_info">
                    <table class="table dataTable my-0">

                        <tbody>
                            <asp:GridView ID="GridView1" runat="server" ShowHeaderWhenEmpty="true" class="table dataTable my-0" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="emp_id" CellPadding="4" ForeColor="#333333" GridLines="Both">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Employee Id">
                                        <ItemTemplate>
                                            <asp:Label ID="lblId" runat="server" Text='<%# Eval("emp_id") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Employee Name">
                                        <ItemTemplate>
                                            <asp:Label ID="lblName" runat="server" Text='<%# Eval("emp_name") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Salary">
                                        <ItemTemplate>
                                            <asp:Label ID="lblEmpSalary" runat="server" Text='<%# Eval("emp_salary_amount") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Allowances">
                                        <ItemTemplate>
                                            <asp:Label ID="lblAllowances" runat="server" Text='<%# Eval("total_allowances") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Deductions">
                                        <ItemTemplate>
                                            <asp:Label ID="lblDeduction" runat="server" Text='<%# Eval("sal_deduction") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Net Pay">
                                        <ItemTemplate>
                                            <asp:Label ID="lblNetPay" runat="server" Text='<%# Eval("net_pay") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Salary Date">
                                        <ItemTemplate>
                                            <asp:Label ID="lblSalaryDate" runat="server" Text='<%# Eval("sal_month") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" ID="linkButton" Text="Salary Receipt" ForeColor="Blue" OnClick="linkButton_Click"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>

                                <EditRowStyle BackColor="#2461BF" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EFF3FB" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                <SortedDescendingHeaderStyle BackColor="#4870BE" />

                            </asp:GridView>
                        </tbody>
                    </table>
                </div>
            </div>
            </div>
    </div>
</asp:Content>
