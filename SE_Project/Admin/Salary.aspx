<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="Salary.aspx.cs" Inherits="SE_Project.Admin.Salary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <asp:Literal ID="ltError" runat="server" Visible="false"></asp:Literal>
            <h2 class="text-center text-dark mb-4"><strong>Salary History</strong></h2>
            <div class="card shadow">
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
                            <asp:GridView ID="GridView1" OnPageIndexChanging="OnPaging" runat="server" ShowHeaderWhenEmpty="true" class="table dataTable my-0" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="emp_id" CellPadding="4" ForeColor="#333333" GridLines="Both">
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
                                    <asp:TemplateField HeaderText="Med. Allowance">
                                        <ItemTemplate>
                                            <asp:Label ID="lblMedAllowance" runat="server" Text='<%# Eval("med_allowance") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="T. Allowance">
                                        <ItemTemplate>
                                            <asp:Label ID="lblTravelAllowance" runat="server" Text='<%# Eval("travel_allowance") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Wash Allowance">
                                        <ItemTemplate>
                                            <asp:Label ID="lblWashAllowance" runat="server" Text='<%# Eval("wash_allowance") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Salary">
                                        <ItemTemplate>
                                            <asp:Label ID="lblSalary" runat="server" Text='<%# Eval("sal_amount") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Sal Date">
                                        <ItemTemplate>
                                            <asp:Label ID="lblSalDate" runat="server" Text='<%# Eval("sal_month") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" ID="linkButton" Text="View More" OnClick="linkButton_Click"></asp:LinkButton>
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
