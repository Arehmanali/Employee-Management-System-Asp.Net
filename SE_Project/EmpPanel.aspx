<%@ Page Title="" Language="C#" MasterPageFile="~/SiteEmp.Master" AutoEventWireup="true" CodeBehind="EmpPanel.aspx.cs" Inherits="SE_Project.EmpPanel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div class="align-items-center mb-4" style="text-align:center;">
            <asp:Literal ID="ltMessage" runat="server" Visible="false"></asp:Literal>
            <h3 class="text-dark  mb-0">Dashboard</h3>
            </div>
            <div class="row">
                <div class="col-1">

                </div>
                <div class="col-md-7 col-xl-3 mb-4">
                    <div class="card shadow border-left-primary py-2">
                        <div class="card-body">
                            <div class="row align-items-center no-gutters">
                                <div class="col mr-2">
                                    <div class="text-uppercase text-primary font-weight-bold text-xs mb-1"><span>Total Leaves</span></div>
                                    <div>
                                        <span>
                                            <asp:Label ID="lblTotalLeaves" runat="server" class="text-dark font-weight-bold h4 mb-0"></asp:Label>
                                        </span>
                                    </div>
                                </div>
                                <div class="col-auto"><i class="fa fa-calendar fa-4x text-gray-500"></i></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-6 col-xl-3 mb-4">
                    <div class="card shadow border-left-success py-2">
                        <div class="card-body">
                            <div class="row align-items-center no-gutters">
                                <div class="col mr-2">
                                    <div class="text-uppercase text-success font-weight-bold text-xs mb-1"><span>Approved Leaves</span></div>
                                    <div>
                                        <span>
                                            <asp:Label ID="lblApprovedLeaves" runat="server" class="text-dark font-weight-bold h4 mb-0"></asp:Label>
                                        </span>
                                    </div>
                                </div>
                                <div class="col-auto"><i class="fa fa-calendar-check fa-4x text-gray-500"></i></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-6 col-xl-3 mb-4">
                    <div class="card shadow border-left-info py-2">
                        <div class="card-body">
                            <div class="row align-items-center no-gutters">
                                <div class="col mr-2">
                                    <div class="text-uppercase text-info font-weight-bold text-xs mb-1"><span>Pending Leaves</span></div>
                                    <div class="row no-gutters align-items-center">
                                        <div class="col-auto">
                                            <div>
                                                <span>
                                                    <asp:Label ID="lblPendingLeaves" runat="server" class="text-dark font-weight-bold h4 mb-0 mr-3"></asp:Label>
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-auto"><i class="fas fa-hourglass-half fa-4x text-gray-500"></i></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        <div class="row">
            
        </div>
            <div class="row">
                <div class="col-1"></div>
                <div class="col-md-6 col-xl-3 mb-4">
                    <div class="card shadow border-left-primary py-2">
                        <div class="card-body">
                            <div class="row align-items-center no-gutters">
                                <div class="col mr-2">
                                    <div class="text-uppercase text-primary font-weight-bold text-xs mb-1"><span>Last Salary</span></div>
                                    <div>
                                        <span>
                                            <asp:Label ID="lblLastSalary" runat="server" class="text-dark font-weight-bold h4 mb-0"></asp:Label>
                                        </span>
                                    </div>
                                </div>
                                <div class="col-auto"><i class="fa fa-credit-card-alt fa-4x text-gray-500"></i></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-6 col-xl-3 mb-4">
                    <div class="card shadow border-left-success py-2">
                        <div class="card-body">
                            <div class="row align-items-center no-gutters">
                                <div class="col mr-2">
                                    <div class="text-uppercase text-success font-weight-bold text-xs mb-1"><span>Allowances</span></div>
                                    <div>
                                        <span>
                                            <asp:Label ID="lblAllowances" runat="server" class="text-dark font-weight-bold h4 mb-0"></asp:Label>
                                        </span>
                                    </div>
                                </div>
                                <div class="col-auto"><i class="fa fa-credit-card fa-4x text-gray-500"></i></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-6 col-xl-3 mb-4">
                    <div class="card shadow border-left-info py-2">
                        <div class="card-body">
                            <div class="row align-items-center no-gutters">
                                <div class="col mr-2">
                                    <div class="text-uppercase text-info font-weight-bold text-xs mb-1"><span>Deductions</span></div>
                                    <div class="row no-gutters align-items-center">
                                        <div class="col-auto">
                                            <div>
                                                <span>
                                                    <asp:Label ID="lblDeduction" runat="server" class="text-dark font-weight-bold h4 mb-0 mr-3"></asp:Label>
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-auto"><i class="fas fa-minus-square fa-4x text-gray-500"></i></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
