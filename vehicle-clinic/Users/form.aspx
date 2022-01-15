<%@ Page Title="" Language="C#" MasterPageFile="~/layouts/app_layout.Master" AutoEventWireup="true" CodeBehind="form.aspx.cs" Inherits="vehicle_clinic.Users.form1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>New User</title>
</asp:Content>
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
        <div class="card card-primary">
            <div class="card-header">
                <h3 class="card-title">Create new <small>User</small></h3>
            </div>
            <form runat="server" id="userForm">
                <div class="card-body">  
                    <div class="form-group">
                        <label for="">First Name</label>
                        <asp:TextBox ID="first_name_txtbox" placeholder="Enter first name" class="form-control" runat="server"/>
                    </div>

                    <div class="form-group">
                        <label for="">Second Name</label>
                        <asp:TextBox ID="second_name_txtbox" placeholder="Enter second name" class="form-control" runat="server" />
                    </div>

                    <div class="form-group">
                        <label for="">Email:</label>
                        <asp:TextBox ID="email_txtbox" placeholder="Enter email" class="form-control" runat="server" />
                    </div>

                    <div class="form-group">
                        <label for="">Password:</label>
                        <asp:TextBox ID="password_txtbox" TextMode="Password" placeholder="Enter password" class="form-control" runat="server" />
                    </div>

                    <div class="form-group">
                      <label for="sel1">Select Role:</label>
                        <asp:DropDownList ID="roleList" runat="server" class="form-control" >
                        <asp:ListItem Text="--Select--" Value="null" />
                        <asp:ListItem Text="Admin" Value="1" />
                        <asp:ListItem Text="User" Value="2" />
                      </asp:DropDownList>
                    </div>

                    <div class="form-group">
                        <label for="">Display order:</label>
                        <asp:TextBox ID="display_order_txtbox" placeholder="Enter display order" TextMode="Number" class="form-control" runat="server" />
                    </div>

                    <div class="card-footer">
                        <asp:Button ID="submitBtn" OnClick="submitBtn_Click" class="btn btn-primary btn-sm" Text="Save" runat="server" />
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
