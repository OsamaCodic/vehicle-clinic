<%@ Page Title="" Language="C#" MasterPageFile="~/layouts/frontend_layout.Master" AutoEventWireup="true" CodeBehind="registerUser.aspx.cs" Inherits="vehicle_clinic.Frontend.login.registerUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" id="userForm">
                <div class="card-body">

                    <div runat="server" id="errorMessage" class="errClass"></div>

                    <div class="form-group">
                        <label for="">First Name <span class="required">*</span></label>
                        <asp:TextBox ID="first_name_txtbox" placeholder="Enter first name" class="form-control" runat="server"/>
                        <asp:requiredfieldvalidator id="first_name_required" runat="Server" errormessage="First name is required!" controltovalidate="first_name_txtbox" display="Dynamic" forecolor="Red" />
                    </div>

                    <div class="form-group"> 
                        <label for="">Second Name <span class="required">*</span></label>
                        <asp:TextBox ID="second_name_txtbox" placeholder="Enter second name" class="form-control" runat="server" />
                        <asp:requiredfieldvalidator id="last_name_required" runat="Server" errormessage="Last name is required!" controltovalidate="second_name_txtbox" display="Dynamic" forecolor="Red" />
                    </div>

                    <div class="form-group">
                        <label for="">Email <span class="required">*</span></label>
                        <asp:TextBox ID="email_txtbox" placeholder="Enter email" class="form-control" runat="server" />
                        <asp:requiredfieldvalidator id="email_required" runat="Server" errormessage="Email is required!" controltovalidate="email_txtbox" display="Dynamic" forecolor="Red" />
                    </div>

                    <div class="form-group">
                        <label for="">Password <span class="required">*</span></label>
                        <asp:TextBox ID="password_txtbox" TextMode="Password" placeholder="Enter password" class="form-control" runat="server" />
                        <asp:requiredfieldvalidator id="password_required" runat="Server" errormessage="Password is required!" controltovalidate="password_txtbox" display="Dynamic" forecolor="Red" />
                    </div>

                    <div class="form-group">
                        <label for="">Confirm Password <span class="required">*</span></label>
                        <asp:TextBox ID="confirm_password_txtbox" TextMode="Password" placeholder="Confirm password" class="form-control" runat="server" />
                        <asp:requiredfieldvalidator id="confirm_password_required" runat="Server" errormessage="Please Confirm your password!" controltovalidate="confirm_password_txtbox" display="Dynamic" forecolor="Red" />
                        <asp:CompareValidator
				            ID="ComparePassword"
				            runat="server" 				
				            Text="Password doesn't match!"
                            forecolor="Red"
				            errormessage="Password doesn't match!"
				            ControlToValidate="confirm_password_txtbox"
				            ControlToCompare="password_txtbox"
				            Display="Dynamic"   
				            Operator="Equal"
				            Type="Integer">
			            </asp:CompareValidator>
                    </div>

                    <div class="card-footer">
                        <asp:Button ID="submitBtn" OnClick="submitBtn_Click" class="btn btn-primary btn-sm" Text="Register" runat="server" />
                    </div>
                </div>
            </form>
</asp:Content>
