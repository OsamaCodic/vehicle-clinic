<%@ Page Title="" Language="C#" MasterPageFile="~/layouts/app_layout.Master" AutoEventWireup="true" CodeBehind="form.aspx.cs" Inherits="vehicle_clinic.Users.form1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--content-header-->
        <section class="content-header">
          <div class="container-fluid">
            <div class="row mb-2">
              <div class="col-sm-6">
                <h1>User</h1>
              </div>
            </div>
          </div>
        </section>
    <!--content-header-->

    <div class="col-md-12">
        <div runat="server" id="formCard">
            <div class="card-header">
                <h3 class="card-title" id="formTitle" runat="server" ></h3>
            </div>
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

                    <div class="form-group">
                      <label for="sel1">Select Role <span class="required">*</span></label>
                        <asp:DropDownList ID="roleList" runat="server" class="form-control" ValidationGroup="g1">
                            <asp:ListItem Text="--Select--" Value="0" />
                            <asp:ListItem Text="Admin" Value="1" />
                            <asp:ListItem Text="User" Value="2" />
                        </asp:DropDownList>

                        <asp:requiredfieldvalidator id="role_required" runat="Server" errormessage="Please select any role!" controltovalidate="roleList" InitialValue="0" SetFocusOnError="true" display="Dynamic" forecolor="Red" />
                    </div>
                    
                    <div class="form-group">
                        <label for="">Display order <span class="required">*</span></label>
                        <asp:TextBox ID="display_order_txtbox" placeholder="Enter display order" TextMode="Number" class="form-control" runat="server" />
                        <asp:requiredfieldvalidator id="display_order_required" runat="Server" errormessage="Display order is required!" controltovalidate="display_order_txtbox" display="Dynamic" forecolor="Red" />
                    </div>

                    <div class="card-footer">
                        <asp:Button ID="submitBtn" OnClick="submitBtn_Click" class="btn btn-primary btn-sm" Text="Save" runat="server" />
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
