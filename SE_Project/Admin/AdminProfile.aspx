<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="AdminProfile.aspx.cs" Inherits="SE_Project.Admin.AdminProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Literal ID="ltError" runat="server" Visible="false"></asp:Literal>
    <div class="container-fluid">
        <h3 class="text-dark mb-4">Profile</h3>
        <div class="row mb-3">
            <div class="col">
                <div class="card shadow mb-3">
                    <div class="card-header py-3">
                        <p class="text-primary m-0 font-weight-bold">Admin Info</p>
                    </div>
                    <div class="card-body">

                        <div class="form-row">
                            <div class="col">
                                <div class="form-group">
                                    <label for="username"><strong>Username</strong></label>
                                    <asp:TextBox ID="txtUsername" ValidationGroup="group1" runat="server" class="form-control"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="revUsername" runat="server" ControlToValidate="txtUsername" ForeColor="Red" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" Display="Dynamic" ErrorMessage="Invalid username" />
                                    <asp:RequiredFieldValidator ID="rfvName" ValidationGroup="group1" runat="server" ControlToValidate="txtUsername" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                        
                                </div>
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <label for="CNIC"><strong>CNIC</strong></label>
                                    <asp:TextBox ID="txtCNIC" ValidationGroup="group1" runat="server" class="form-control" TextMode="Phone"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCNIC" ForeColor="Red" ValidationExpression="^[0-9]{13}$" Display="Dynamic" ErrorMessage="Invalid CNIC" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="group1" runat="server" ControlToValidate="txtCNIC" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                        
                                </div>
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="col">
                                <div class="form-group">
                                    <label for="first_name"><strong>First Name</strong></label>
                                    <asp:TextBox ID="txtFirstName" ValidationGroup="group1" runat="server" class="form-control"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="revFirstName" runat="server" ControlToValidate="txtFirstName" ForeColor="Red" ValidationExpression="^[^\W\d_]+$" Display="Dynamic" ErrorMessage="Must Contain Alphabets" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatr2" ValidationGroup="group1" runat="server" ControlToValidate="txtFirstName" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                        
                                </div>
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <label for="last_name"><strong>Last Name</strong></label>
                                    <asp:TextBox ID="txtLastName" ValidationGroup="group1" runat="server" class="form-control"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="revLastName" runat="server" ControlToValidate="txtLastName" ForeColor="Red" ValidationExpression="^[^\W\d_]+$" Display="Dynamic" ErrorMessage="Must Contain Alphabets" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="group1" runat="server" ControlToValidate="txtLastName" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                        
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="card shadow">
                    <div class="card-header py-3">
                        <p class="text-primary m-0 font-weight-bold">Contact Info</p>
                    </div>
                    <div class="card-body">

                        <div class="form-row">
                            <div class="col">
                                <div class="form-group">
                                    <label for="address"><strong>Address</strong></label>
                                    <asp:TextBox ID="txtAddress" ValidationGroup="group1" runat="server" TextMode="MultiLine" class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="group1" runat="server" ControlToValidate="txtAddress" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                        
                                </div>
                            </div>
                            <div class="col">
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="col">
                                <div class="form-group">
                                    <label for="city"><strong>City</strong></label>
                                    <asp:TextBox ID="txtCity" ValidationGroup="group1" runat="server" class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="group1" runat="server" ControlToValidate="txtCity" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                        
                                </div>
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <label for="country"><strong>Country</strong></label>
                                    <asp:TextBox ID="txtCountry" ValidationGroup="group1" runat="server" class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="group1" runat="server" ControlToValidate="txtCountry" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                        
                                </div>
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="col">
                                <div class="form-group">
                                    <label for="contact"><strong>Contact</strong></label>
                                    <asp:TextBox ID="txtContact" ValidationGroup="group" runat="server" class="form-control" TextMode="Phone"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtContact" ForeColor="Red" ValidationExpression="^[0-9]{10}$" Display="Dynamic" ErrorMessage="Invalid Contact" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ValidationGroup="group1" runat="server" ControlToValidate="txtContact" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                        
                                </div>
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <label for="password"><strong>Password</strong></label>
                                    <asp:TextBox ID="txtPassword" ValidationGroup="group1" runat="server" class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ValidationGroup="group1" runat="server" ControlToValidate="txtPassword" ForeColor="Red" Display = "Dynamic" ErrorMessage = "Required Field" />
                                        
                                </div>
                            </div>
                        </div>
                        <hr />

                        <div class="form-row ">
                            <div class="form-group">
                                <asp:Button ID="btnUpdate" ValidationGroup="group1" runat="server" class="btn btn-primary btn-sm text-center" Text="Save Settings" OnClick="btnUpdate_Click" />
                            </div>
                        </div>


                    </div>
            </div>
        </div>
        <div class="col-5 col-lg-4">
            <div class="card mb-3">
                <div class="card-body text-center shadow">
                    <asp:Image ID="imgAdmin" runat="server" class="rounded-circle mb-3 mt-4" Width="160" Height="160" Style="width: 150px; height: 150px;" />

                    <div class="mb-3">
                        <table>
                            <tr>
                                <td>
                                    <asp:Button ID="btnSaveImage" runat="server" Text="Save" OnClick="btnSaveImage_Click" />
                                </td>
                                <td>
                                    <asp:FileUpload ID="FileUpload1" runat="server" Text="Brows Image"></asp:FileUpload>
                                </td>
                            </tr>
                        </table>

                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
               
</asp:Content>
