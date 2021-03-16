﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="404.aspx.cs" Inherits="SE_Project._404" %>

<!DOCTYPE html>
<html>

<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <title>Page Not Found</title>
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i">
    <link rel="stylesheet" href="assets/fonts/fontawesome-all.min.css">
    <link rel="stylesheet" href="assets/fonts/font-awesome.min.css">
    <link rel="stylesheet" href="assets/fonts/material-icons.min.css">
    <link rel="stylesheet" href="assets/fonts/typicons.min.css">
    <link rel="stylesheet" href="assets/fonts/fontawesome5-overrides.min.css">
    <link rel="stylesheet" href="assets/css/Footer-Basic.css">
    <link rel="stylesheet" href="assets/css/Highlight-Blue.css">
    <link rel="stylesheet" href="assets/css/Icon-Button.css">
    <link rel="stylesheet" href="assets/css/Navigation-with-Button.css">
    <link rel="stylesheet" href="assets/css/Style.css">
</head>

<body id="page-top">
    <div id="wrapper">
        <nav class="navbar navbar-dark align-items-start sidebar sidebar-dark accordion bg-gradient-primary p-0">
            <div class="container-fluid d-flex flex-column p-0">
                <a class="navbar-brand d-flex justify-content-center align-items-center sidebar-brand m-0" href="adminPanel.html">
                    <div class="sidebar-brand-icon rotate-n-15"><i class="fas fa-users"></i></div>
                    <div class="sidebar-brand-text mx-3"><span>EMS</span></div>
                </a>
                <hr class="sidebar-divider my-0">
                <ul class="nav navbar-nav text-light" id="accordionSidebar">
                    <li class="nav-item" role="presentation"><a class="nav-link active" href="AdminPanel.aspx"><i class="fas fa-tachometer-alt"></i><span>Dashboard</span></a></li>
                    <li class="nav-item" role="presentation"><a class="nav-link" href="AdminProfile.aspx"><i class="fas fa-user"></i><span>Profile</span></a></li>
                    <li class="nav-item" role="presentation"></li><a class="nav-link" href="Employee.aspx"><i class="fas fa-users"></i>&nbsp;<span>Employee</span></a></li>
                    <li class="nav-item" role="presentation"><a class="nav-link" href="Departments.aspx"><i class="la la-home"></i><span>Departments</span></a></li>
                    <li class="nav-item" role="presentation">
                        <div class="nav-item dropright" style="margin-left: 0px;margin-bottom: 0px;width: 224px;height: 52px; background-color: #4e73df;">
                            <a class="dropdown-toggle" data-toggle="dropdown" aria-expanded="false" href="AttendanceHistory.aspx" style="color: rgb(208,213,225);margin-left: 0px;">
                                <i class="fas fa-window-maximize" style="margin-left: 15px;"></i>&nbsp;Attendance
                            </a>
                            <div class="dropdown-menu" role="menu">
                                <a class="dropdown-item" role="presentation" href="MarkAttendance.aspx">Mark Attendacne</a>
                                <a class="dropdown-item" role="presentation" href="AttendanceHistory.aspx">Attendance History</a>
                            </div>
                        </div>
                    </li>
                    <li class="nav-item" role="presentation">
                        <div class="nav-item dropright" style="margin-left: 0px;margin-bottom: 0px;width: 224px;height: 52px;">
                            <a class="dropdown-toggle" data-toggle="dropdown" aria-expanded="false" href="Salary.html" style="color: rgb(208,213,225);margin-left: 0px;">
                                <i class="fas fa-window-maximize" style="margin-left: 15px;"></i>&nbsp;Leave Management
                            </a>
                            <div class="dropdown-menu" role="menu">
                                <a class="dropdown-item" role="presentation" href="LeaveRequests.aspx">Leave Requests</a>
                                <a class="dropdown-item" role="presentation" href="PendingLeaves.aspx">Pending Leaves</a>
                                <a class="dropdown-item" role="presentation" href="ApprovedLeaves.aspx">Approved Leaves</a>
                                <a class="dropdown-item" role="presentation" href="RejectedLeaves.aspx">Rejected Leaves</a>
                            </div>
                        </div>
                    </li>
                    <li class="nav-item" role="presentation">
                        <div class="nav-item dropright" style="margin-left: 0px;margin-bottom: 0px;width: 224px;height: 52px;">
                            <a class="dropdown-toggle" data-toggle="dropdown" aria-expanded="false" href="Salary.aspx" style="color: rgb(208,213,225);margin-left: 0px;"><i class="fas fa-window-maximize" style="margin-left: 15px;"></i>&nbsp;Salary Management</a>
                            <div class="dropdown-menu" role="menu">
                                <a class="dropdown-item" role="presentation" href="Salary.aspx">Salary History</a>
                                <a class="dropdown-item" role="presentation" href="GeneratSalary.aspx">Generate Salary</a>
                                <a class="dropdown-item" role="presentation" href="SalaryReport.aspx">Salary Report</a>
                                <a class="dropdown-item" role="presentation" href="YearlySalaryReport.aspx">Year Wise Report</a>
                            </div>
                        </div>
                    </li>
                </ul>
                <div class="text-center d-none d-md-inline"><button class="btn rounded-circle border-0" id="sidebarToggle" type="button"></button></div>
            </div>
        </nav>
        <div class="d-flex flex-column" id="content-wrapper">
            <div id="content">
                <nav class="navbar navbar-light navbar-expand bg-white shadow mb-4 topbar static-top">
                    <div class="container-fluid"><button class="btn btn-link d-md-none rounded-circle mr-3" id="sidebarToggleTop" type="button"><i class="fas fa-bars"></i></button>
                        <form class="form-inline d-none d-sm-inline-block mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search">
                            <div class="input-group"><input class="bg-light form-control border-0 small" type="text" placeholder="Search for ...">
                                <div class="input-group-append"><button class="btn btn-primary py-0" type="button"><i class="fas fa-search"></i></button></div>
                            </div>
                        </form>
                        <ul class="nav navbar-nav flex-nowrap ml-auto">
                            <div class="d-none d-sm-block topbar-divider"></div>
                            <li class="nav-item dropdown no-arrow" role="presentation">
                                <div class="nav-item dropdown no-arrow"><a class="dropdown-toggle nav-link" data-toggle="dropdown" aria-expanded="false" href="#"><span class="d-none d-lg-inline mr-2 text-gray-600 small">Dumy Admin</span><img class="border rounded-circle img-profile" src="assets/img/generaluser.png"></a>
                                    <div
                                        class="dropdown-menu shadow dropdown-menu-right animated--grow-in" role="menu"><a class="dropdown-item" role="presentation" href="#"><i class="fas fa-user fa-sm fa-fw mr-2 text-gray-400"></i>&nbsp;Profile</a><a class="dropdown-item" role="presentation" href="#"><i class="fas fa-cogs fa-sm fa-fw mr-2 text-gray-400"></i>&nbsp;Settings</a>
                                        <a
                                            class="dropdown-item" role="presentation" href="#"><i class="fas fa-list fa-sm fa-fw mr-2 text-gray-400"></i>&nbsp;Activity log</a>
                                            <div class="dropdown-divider"></div><a class="dropdown-item" role="presentation" href="#"><i class="fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400"></i>&nbsp;Logout</a></div>
                    </div>
                    </li>
                    </ul>
            </div>
            </nav>
            <div class="container-fluid">
                <div class="text-center mt-5">
                    <div class="error mx-auto" data-text="404">
                        <p class="m-0">404</p>
                    </div>
                    <p class="text-dark mb-5 lead">Page Not Found</p>
                    <p class="text-black-50 mb-0">It looks like you found a glitch in the matrix...</p><a href="adminPanel.html">← Back to Dashboard</a></div>
            </div>
        </div>
        <footer class="bg-white sticky-footer">
            <div class="container my-auto">
                <div class="text-center my-auto copyright"><span>Copyright © Employee Management System 2020</span></div>
            </div>
        </footer>
    </div><a class="border rounded d-inline scroll-to-top" href="#page-top"><i class="fas fa-angle-up"></i></a></div>
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.4.1/jquery.easing.js"></script>
    <script src="assets/js/theme.js"></script>
</body>

</html>