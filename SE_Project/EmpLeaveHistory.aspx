<%@ Page Title="" Language="C#" MasterPageFile="~/SiteEmp.Master" AutoEventWireup="true" CodeBehind="EmpLeaveHistory.aspx.cs" Inherits="SE_Project.EmpLeaveHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <asp:Literal ID="ltError" runat="server" Visible="false"></asp:Literal>
            <h2 class="text-center text-dark mb-4"><strong>Leave History</strong></h2>
            <div class="card shadow">
                <div class="card-header py-3">
                    <p class="text-primary m-0 font-weight-bold">Leave History Sheet</p>
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
                            <asp:GridView ID="GridView1" OnPageIndexChanging="OnPaging" runat="server" OnRowDataBound="GridView1_RowDataBound" ShowHeaderWhenEmpty="true" class="table dataTable my-0" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="Both">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Leave Type">
                                        <ItemTemplate>
                                            <asp:Label ID="lblLeave" runat="server" Text='<%# Eval("leave_type") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Date">
                                        <ItemTemplate>
                                            <asp:Label ID="lblDate" runat="server" Text='<%# Eval("leave_date") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Description">
                                        <ItemTemplate>
                                            <asp:Label ID="lblDescription" runat="server" Text='<%# Eval("emp_remark") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Admin Remark">
                                        <ItemTemplate>
                                            <asp:Label ID="lblAdminRemark" runat="server" Text='<%# Eval("admin_remark") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Status">
                                        <ItemTemplate>
                                            <asp:Label ID="lblStatus" runat="server" Text='<%# Eval("leave_status") %>'></asp:Label>
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
