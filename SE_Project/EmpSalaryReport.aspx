<%@ Page Title="" Language="C#" MasterPageFile="~/SiteEmp.Master" AutoEventWireup="true" CodeBehind="EmpSalaryReport.aspx.cs" Inherits="SE_Project.EmpSalaryReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <asp:Literal ID="ltError" runat="server" Visible="false"></asp:Literal>
        <h2 class="text-center text-dark mb-1" style="color: rgb(76,113,221);">Salary Report</h2>
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
                            <asp:Label ID="lblMonth" runat="server" Text="Month"></asp:Label>
                        </td>
                        <td>
                            <div class="dropdown">
                                <asp:DropDownList ID="ddlMonth" AutoPostBack="true" OnSelectedIndexChanged="ddlMonth_SelectedIndexChanged" runat="server" ValidationGroup="group1" class="dropdown-toggle border rounded" Style="background-color: rgb(255,255,255); color: rgb(137,139,153); width: 150px; height: 38px">
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
                    </tr>

                </table>
            </div>
        </div>
        <div class="card shadow" style="margin-top: 20px">
            <div class="card-header py-3">
                <p class="text-primary m-0 font-weight-bold">Salary Report Sheet</p>
            </div>
            <div class="card-body">
                <div class="row">
                    <div class="col">
                        <div class="text-md-right dataTables_filter">
                            <label>
                                 <asp:TextBox ID="txtSearch" runat="server" OnTextChanged="Search" AutoPostBack="true" Placeholder="Search..." style="width:300px"></asp:TextBox>
 
                            </label>
                        </div>
                    </div>
                </div>
                <div class="table-responsive table mt-2" aria-describedby="dataTable_info">
                    <table class="table dataTable my-0">

                        <tbody>
                            <asp:GridView ID="GridView1" OnPageIndexChanging="OnPaging" runat="server" ShowHeaderWhenEmpty="true" class="table dataTable my-0" AllowPaging="True" AutoGenerateColumns="False"  CellPadding="4" ForeColor="#333333" GridLines="Both">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>

                                    <asp:TemplateField HeaderText="Salary">
                                        <ItemTemplate>
                                            <asp:Label ID="lblEmpSalary" runat="server" Text='<%# Eval("sal_amount") %>'></asp:Label>

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
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" ID="linkButton" Text="Salary Receipt" ForeColor="Red" OnClick="linkButton_Click"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <%--<asp:CommandField HeaderText="Salary Reciept" ControlStyle-CssClass="btn btn-primary" ShowSelectButton="True">
                                        <ControlStyle CssClass="btn btn-primary"></ControlStyle>
                                    </asp:CommandField>--%>
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
