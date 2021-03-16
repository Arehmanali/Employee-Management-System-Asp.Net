<%@ Page Title="" Language="C#" MasterPageFile="~/SiteEmp.Master" AutoEventWireup="true" CodeBehind="EmpLeave.aspx.cs" Inherits="SE_Project.EmpLeave" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div class="card shadow"></div>
        <div class="card" style="margin-top: 10px;">
            <div class="card-header">
                <h4 class="text-center"><i class="fa fa-check"></i>&nbsp;Apply for Leave</h4>
            </div>
            <div class="card-body">
                <asp:Literal ID="ltError" runat="server" Visible="false"></asp:Literal>
                <div class="row">
                    <div class="col-lg-7 offset-lg-0">
                        <div class="p-5" style="padding-left: 48px;">
                            <div class="text-center"></div>
                            <div class="user">
                                <h6></h6>
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0" style="padding-right: 50px;">
                                        <h6>Date of Leave</h6>
                                        <asp:TextBox ID="txtLeaveDate" ValidationGroup="group1" TextMode="Date" runat="server" class="border rounded form-control" Style="height: 50px; width: 240px; background-color: rgb(255,255,255); color: rgb(113,109,108)">
                                        </asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLeaveDate" ForeColor="Red" Display="Dynamic" ErrorMessage="Required Field" />
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0" style="padding-right: 50px;">
                                        <h6>Leave Type</h6>
                                        <asp:DropDownList ID="ddlLeaveType" ValidationGroup="group1" runat="server" class="dropdown-toggle border rounded" Style="width: 240px; height: 50px; background-color: rgb(255,255,255); color: rgb(113,109,108); padding-bottom: 6px; margin-bottom: 15px;">
                                            <asp:ListItem Text="Select Leave Type" Value="0"></asp:ListItem>
                                            <asp:ListItem Text="Casual Leave" Value="1"></asp:ListItem>
                                            <asp:ListItem Text="Medical Leave" Value="2"></asp:ListItem>
                                            <asp:ListItem Text="Restricted Leave" Value="3"></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlLeaveType" ForeColor="Red" Display="Dynamic" ErrorMessage="Required Field" />
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0" style="padding-right: 50px;">
                                        <h6>Leave Description</h6>
                                        <asp:TextBox ID="txtDescription" ValidationGroup="group1" runat="server" TextMode="MultiLine" class="border rounded" Style="width: 240px; height: 50px; background-color: rgb(255,255,255); color: rgb(113,109,108); padding-bottom: 6px; margin-bottom: 15px;"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtDescription" ForeColor="Red" Display="Dynamic" ErrorMessage="Required Field" />
                                    </div>
                                </div>
                            </div>
                            <div class="text-center">
                            </div>
                            <asp:Button ID="btnSubmit" ValidationGroup="group1" class="btn btn-success" runat="server" Text="Apply" Style="margin: 0px; margin-right: 20px; width: 100px;" OnClick="btnSubmit_Click" />
                            <asp:Button ID="btnCancel" class="btn btn-primary" runat="server" Text="Cancel" Style="width: 100px; margin-left: 20px;" OnClick="btnCancel_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
