<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="Departments.aspx.cs" Inherits="SE_Project.Admin.Departments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <asp:Literal ID="ltError" runat="server" Visible="false"></asp:Literal>
        <h2 class="text-center text-dark mb-4"><strong>Departments</strong></h2>
        <div>
            <a class="btn btn-success btn-block icon-button" role="button" href="DepRegisteration.aspx" style="width: 150px; margin: 10px; padding-left: 12px; margin-left: 0px;"><i class="fa fa-plus"></i><span>Add New</span></a>
        </div>
        <div class="card shadow">
            <div class="card-header py-3">
                <p class="text-primary m-0 font-weight-bold">Department Info</p>
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
                            <asp:GridView ID="GridView1" runat="server" OnPageIndexChanging = "OnPaging" class="table dataTable my-0" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="dep_id" OnRowDataBound="GridView1_RowDataBound" CellPadding="4" ForeColor="#333333">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Department Id">
                                        <ItemTemplate>
                                            <asp:Label ID="lblId" runat="server" Text='<%# Eval("dep_id") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Department Name">
                                        <ItemTemplate>
                                            <asp:Label ID="lblName" runat="server" Text='<%# Eval("dep_name") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Total Employees">
                                        <ItemTemplate>
                                            <asp:Label ID="lbltotalEmp" runat="server" Text='<%# Eval("total_emp") %>'></asp:Label>
                                           
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" ID="linkButton" OnClientClick="return Confim();" Text="Delete" ForeColor="Red" OnClick="linkButton_Click"></asp:LinkButton>
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
