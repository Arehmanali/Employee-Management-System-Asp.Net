<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="SE_Project.Admin.AdminPanel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div class="d-sm-flex justify-content-between align-items-center mb-4">
            <asp:Literal ID="ltMessage" runat="server" Visible="false"></asp:Literal>
            <h3 class="text-dark mb-0">Dashboard</h3>
           <%-- <a class="btn btn-primary btn-sm d-none d-sm-inline-block" role="button" href="#"><i class="fas fa-download fa-sm text-white-50"></i>&nbsp;Get Attendance Sheet</a>--%>
        </div>
        <div class="row">
            <div class="col-md-6 col-xl-3 mb-4">
                <div class="card shadow border-left-primary py-2">
                    <div class="card-body">
                        <div class="row align-items-center no-gutters">
                            <div class="col mr-2">
                                <div class="text-uppercase text-primary font-weight-bold text-xs mb-1"><span>Total Employee</span></div>
                                <div>
                                    <span>
                                        <asp:Label ID="lblTotalEmp" runat="server" class="text-dark font-weight-bold h5 mb-0"></asp:Label>
                                    </span>
                                </div>
                            </div>
                            <div class="col-auto"><i class="fas fa-users fa-2x text-gray-300" style="color: rgb(99,120,244); background-color: #4e73df;"></i></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6 col-xl-3 mb-4">
                <div class="card shadow border-left-success py-2">
                    <div class="card-body">
                        <div class="row align-items-center no-gutters">
                            <div class="col mr-2">
                                <div class="text-uppercase text-success font-weight-bold text-xs mb-1"><span>Total Departments</span></div>
                                <div>
                                    <span>
                                        <asp:Label ID="lblTotalDep" runat="server" class="text-dark font-weight-bold h5 mb-0"></asp:Label>
                                    </span>
                                </div>
                            </div>
                            <div class="col-auto"><i class="material-icons fa-2x text-gray-300" style="background-color: #4d72de;">format_list_numbered</i></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6 col-xl-3 mb-4">
                <div class="card shadow border-left-info py-2">
                    <div class="card-body">
                        <div class="row align-items-center no-gutters">
                            <div class="col mr-2">
                                <div class="text-uppercase text-info font-weight-bold text-xs mb-1"><span>Attendence</span></div>
                                <div class="row no-gutters align-items-center">
                                    <div class="col-auto">
                                        <div>
                                            <span>
                                                <asp:Label ID="lblAttendance" runat="server" class="text-dark font-weight-bold h5 mb-0 mr-3"></asp:Label>
                                            </span>

                                        </div>
                                    </div>

                                </div>
                            </div>
                            <div class="col-auto"><i class="fas fa-clipboard-list fa-2x text-gray-300" style="background-color: #4b70dd;"></i></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6 col-xl-3 mb-4">
                <div class="card shadow border-left-warning py-2">
                    <div class="card-body">
                        <div class="row align-items-center no-gutters">
                            <div class="col mr-2">
                                <div class="text-uppercase text-warning font-weight-bold text-xs mb-1"><span>Leave Requests</span></div>
                                <div>
                                    <span>
                                        <asp:Label ID="lblLeaveRequest" runat="server" class="text-dark font-weight-bold h5 mb-0"></asp:Label>
                                    </span>
                                </div>
                            </div>
                            <div class="col-auto"><i class="fas fa-comments fa-2x text-gray-300" style="color: rgb(75,112,220); background-color: #4b70dd;"></i></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="container-fluid">
        <h3 class="text-dark mb-4">Employee</h3>
        <div class="card shadow">
            <div class="card-header py-3">
                <p class="text-primary m-0 font-weight-bold">Employee Info</p>
            </div>
            <div class="card-body">
                <div class="row">
                    <div class="col">
                        <div class="text-md-right dataTables_filter">
                            <label>
                                <asp:TextBox ID="txtSearch" runat="server" OnTextChanged="Search" AutoPostBack="true" Placeholder="Search..." Style="width: 300px"></asp:TextBox>
                            </label>
                        </div>
                    </div>
                </div>
                <div class="table-responsive table mt-2" aria-describedby="dataTable_info">
                    <table class="table dataTable my-0">

                        <tbody>
                            <asp:GridView ID="GridView1" OnPageIndexChanging="OnPaging" ShowHeaderWhenEmpty="true" runat="server" class="table dataTable my-0" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="emp_id" CellPadding="4" ForeColor="#333333" GridLines="Both">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Emp Id">
                                        <ItemTemplate>
                                            <asp:Label ID="lblId" runat="server" Text='<%# Eval("emp_id") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Name">
                                        <ItemTemplate>
                                            <asp:Label ID="lblName" runat="server" Text='<%# Eval("emp_name") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Designation">
                                        <ItemTemplate>
                                            <asp:Label ID="lblDesign" runat="server" Text='<%# Eval("design_name") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Department">
                                        <ItemTemplate>
                                            <asp:Label ID="lblDep" runat="server" Text='<%# Eval("dep_name") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Contact">
                                        <ItemTemplate>
                                            <asp:Label ID="lblContact" runat="server" Text='<%# Eval("emp_contact") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Email">
                                        <ItemTemplate>
                                            <asp:Label ID="lblEmail" runat="server" Text='<%# Eval("emp_email") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" ID="linkButton" Text="View More" ForeColor="Blue" OnClick="linkButton_Click"></asp:LinkButton>
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
