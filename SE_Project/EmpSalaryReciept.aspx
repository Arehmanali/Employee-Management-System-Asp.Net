﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpSalaryReciept.aspx.cs" Inherits="SE_Project.EmpSalaryReciept" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Salary Reciept</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 458px;
        }

        .auto-style2 {
            height: 42px;
            text-align: center;
        }

        .auto-style3 {
            height: 73px;
        }

        .auto-style4 {
            width: 100%;
        }

        .auto-style5 {
            height: 191px;
        }

        .auto-style6 {
            height: 191px;
            width: 517px;
        }

        .auto-style7 {
            text-align: center;
        }

        .auto-style8 {
            height: 157px;
        }

        .auto-style9 {
            height: 64px;
        }

        .auto-style10 {
            width: 100%;
            height: 123px;
        }

        .auto-style11 {
            width: 337px;
        }

        .auto-style12 {
            width: 100%;
            height: 99px;
        }

        .auto-style13 {
            width: 94%;
        }

        .auto-style14 {
            text-align: right;
            width: 194px;
            height: 38px;
        }

        .auto-style16 {
            height: 38px;
        }

        .auto-style17 {
            width: 194px;
        }

        .auto-style18 {
            width: 345px;
        }

        .auto-style19 {
            text-align: right;
            width: 207px;
            height: 39px;
        }

        .auto-style20 {
            width: 207px;
        }

        .auto-style22 {
            width: 207px;
            height: 26px;
        }

        .auto-style23 {
            height: 26px;
        }

        .auto-style28 {
            height: 39px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="ltError" runat="server" Visible="false"></asp:Label>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Text="Employee Management System"></asp:Label>
            <br />
            <br />
            Your Salary Slip has been generated successfully.<br />
            <br />
            Salary ID:
            <asp:Label ID="lblSalaryId" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnDownload" runat="server" BackColor="#FF9933" Height="31px" Text="Download Invoice" Width="157px" OnClick="btnDownload_Click" />
            <br />
        </div>
        <asp:Panel ID="Panel1" runat="server">
            <table class="auto-style1" border="1">
                <tr>
                    <td class="auto-style2"><strong>Salary Receipt</strong></td>
                </tr>
                <tr>
                    <td class="auto-style3"><strong>Salary ID</strong>:
                        <asp:Label ID="lblSalId" runat="server"></asp:Label>
                        <br />
                        <strong>Date</strong> :
                        <asp:Label ID="lblDate" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <table border="1" class="auto-style4">
                            <tr>
                                <td>

                                </td>
                                <td class="auto-style5"><strong>Employee ID:</strong>
                                    <asp:Label ID="lblEmpId" runat="server"></asp:Label>
                                    <br />
                                    <strong>Employee Name:</strong>
                                    <asp:Label ID="lblEmpName" runat="server"></asp:Label>
                                    <br />
                                    <strong>Employee Department:</strong>
                                    <asp:Label ID="lblEmpDep" runat="server"></asp:Label>
                                    <br />
                                    <strong>Employee Designation:</strong>
                                    <asp:Label ID="lblEmpDesign" runat="server"></asp:Label>
                                    <br />
                                    <strong>Employee Contact:</strong>
                                    <asp:Label ID="lblEmpContact" runat="server"></asp:Label>
                                    <br />
                                    <strong>Employee Email:</strong>
                                    <asp:Label ID="lblEmpEmail" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <table class="auto-style10">
                            <tr>
                                <td class="auto-style11">Salary :<asp:Label ID="lblSalaryAmount" runat="server"></asp:Label>
                                </td>
                                <td>
                                    <table class="auto-style12">
                                        <tr>
                                            <td class="auto-style18">
                                                <table class="auto-style13">
                                                    <tr>
                                                        <td class="auto-style14"><strong>Allowances</strong></td>
                                                        <td class="auto-style16"></td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style17"><strong>Travel :</strong></td>
                                                        <td>
                                                            <asp:Label ID="lblTravelAllowance" runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style17"><strong>Medical :</strong></td>
                                                        <td>
                                                            <asp:Label ID="lblMedAllowance" runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style17"><strong>Washing :</strong></td>
                                                        <td>
                                                            <asp:Label ID="lblWashAllowance" runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style17">-------------------------------</td>
                                                        <td>---------------------</td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style17"><strong>Total :</strong></td>
                                                        <td>
                                                            <asp:Label ID="lblTotalAllowance" runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td>
                                                <table class="auto-style4">
                                                    <tr>
                                                        <td class="auto-style19"><strong>Deductions</strong></td>
                                                        <td class="auto-style28"></td>
                                                    </tr>

                                                    <tr>
                                                        <td class="auto-style22"><strong>Total Leaves :</strong></td>
                                                        <td class="auto-style23">
                                                            <asp:Label ID="lblTotalLeaves" runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style20"><strong>Approved Leaves :</strong></td>
                                                        <td>
                                                            <asp:Label ID="lblApprovedLeave" runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style20"><strong>Leave Deductions :</strong></td>
                                                        <td>
                                                            <asp:Label ID="lblLeaveDeductions" runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style20">----------------------------------</td>
                                                        <td>-------------------------</td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style20"><strong>Total :</strong></td>
                                                        <td>
                                                            <asp:Label ID="lblDeductionTotal" runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7"><strong>Net Pay</strong>:
                        <asp:Label ID="lblNetPay" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Decleration: We declare that there is NO error in this invoice and it is true and accurate.<br />
                        In case if you find any Error or Mistake in this invoice, Please inform <a href="mailto:merehmanali@gmail.com">merehmanali@gmail.com</a><br />
                        <br />
                        THIS IS A COMPUTER GENERATED INVOICE AND DOES NOT REQUIRED SIGNATURE.</td>
                </tr>
            </table>
        </asp:Panel>
    </form>
</body>
</html>
