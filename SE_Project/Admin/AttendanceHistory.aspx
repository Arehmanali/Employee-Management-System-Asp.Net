<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="AttendanceHistory.aspx.cs" Inherits="SE_Project.Admin.AttendanceHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <asp:Literal ID="ltError" runat="server" Visible="false"></asp:Literal>
        <h2 class="text-center text-dark mb-4"><strong>Attendance History</strong></h2>
        <div style="padding-top: 0px;">
            <div class="row" style="padding-top: 0px; padding-bottom: 30px;">
                <div class="col-lg-1 offset-lg-1 text-right">
                    <label class="col-form-label" style="color: rgb(73,110,219);"></label>
                </div>
                <div class="form-group row">
                    <div class="col">
                        <h6>Attendance Date</h6>
                        <asp:TextBox ID="txtAttendanceDate" runat="server" AutoPostBack="true" OnTextChanged="txtAttendanceDate_TextChanged" class="border rounded form-control form-control-user" TextMode="Date" Style="width: 240px; height: 38px; background-color: rgb(255,255,255); color: rgb(113,109,108)"></asp:TextBox>

                    </div>
                    <div class="col">
                        <div class="dropdown">
                            <h6>Employee</h6>
                            <asp:DropDownList ID="ddlEmp" runat="server" AutoPostBack="true" DataValueField="emp_id" DataTextField="emp_name" OnSelectedIndexChanged="ddlEmp_SelectedIndexChanged" class="dropdown-toggle border rounded" Style="width: 240px; height: 38px; background-color: rgb(255,255,255); color: rgb(113,109,108)">
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="card shadow">
            <div class="card-header py-3">
                <p class="text-primary m-0 font-weight-bold">Attendance History</p>
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
                            <asp:GridView ID="GridView1" OnRowDataBound="GridView1_RowDataBound" runat="server" ShowHeaderWhenEmpty="true" class="table dataTable my-0" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="emp_id" CellPadding="4" ForeColor="#333333" GridLines="Both">
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
                                    <asp:TemplateField HeaderText="Date">
                                        <ItemTemplate>
                                            <asp:Label ID="lblDate" runat="server" Text='<%# Eval("attend_date") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Day">
                                        <ItemTemplate>
                                            <asp:Label ID="lblDay" runat="server" Text='<%# Eval("attend_day") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Status">
                                        <ItemTemplate>
                                            <asp:Label ID="lblStatus" runat="server" Text='<%# Eval("attend_status") %>'></asp:Label>
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
