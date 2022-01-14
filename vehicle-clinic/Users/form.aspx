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
            <!-- jquery validation -->
            <div class="card card-primary">
              <div class="card-header">
                <h3 class="card-title">Create new <small>User</small></h3>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
              <form role="form" id="quickForm">
                <div class="card-body">  
                    <div class="form-group">
                        <label for="">First Name</label>
                        <asp:TextBox ID="first_name" placeholder="Enter first name" class="form-control" runat="server"/>
                    </div>

                    <div class="form-group">
                        <label for="">Second Name</label>
                        <asp:TextBox ID="second_name" placeholder="Enter second name" class="form-control" runat="server" />
                    </div>

                    <div class="form-group">
                        <label for="">Email:</label>
                        <asp:TextBox ID="email" placeholder="Enter email" class="form-control" runat="server" />
                    </div>

                    <div class="form-group">
                        <label for="">Password:</label>
                        <asp:TextBox ID="password" placeholder="Enter password" class="form-control" runat="server" />
                    </div>

                    <div class="card-footer">
                      <button type="submit" class="btn btn-primary btn-sm">Create <i class="fa fa-plus" aria-hidden="true"></i></button>
                        
                        <asp:LinkButton id="backBtn" PostBackUrl="~/Users/index.aspx" CssClass="btn btn-secondary btn-sm" runat="server">Back to list <i class="fa fa-chevron-left" aria-hidden="true"></i></asp:LinkButton>
                    </div>
                </div>
              </form>
            </div>
            <!-- /.card -->
            </div>
</asp:Content>
