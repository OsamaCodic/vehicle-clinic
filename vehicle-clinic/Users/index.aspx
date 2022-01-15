<%@ Page Title="" Language="C#" MasterPageFile="~/layouts/app_layout.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="vehicle_clinic.Users.users_index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Users | Index</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--content-header-->
        <section class="content-header">
          <div class="container-fluid">
            <div class="row mb-2">
              <div class="col-sm-6">
                <h1>All Users</h1>
              </div>
            </div>
          </div>
        </section>
    <!--content-header-->
    <form runat="server" id="form">
        <section class="content">
          <div class="row">
            <div class="col-12">
              <div class="card">
                <div class="card-header">
                  <h3 class="card-title">Total records <small>(5)</small></h3>
                   <asp:LinkButton id="createUserBtn" PostBackUrl="~/Users/form.aspx" CssClass="btn btn-success btn-sm fa-pull-right" runat="server">Create <i class="fa fa-plus" aria-hidden="true"></i></asp:LinkButton>
                </div>
                <!-- /.card-header -->
                <div class="card-body">
                  <asp:GridView ID="usersList_gridview" runat="server" CssClass="table table-striped table-hover" AutoGenerateColumns="false">
                      <Columns>
                        <asp:BoundField DataField="first_name" HeaderText="First Name" />
                        <asp:BoundField DataField="second_name" HeaderText="Second Name" />
                        <asp:BoundField DataField="email" HeaderText="Email" />
                        <asp:BoundField DataField="created_at" HeaderText="Created date" />

                        <asp:TemplateField HeaderText="Actions">
                            <ItemTemplate>
                                <asp:LinkButton Text="Edit" ID="editBtn" runat="server" CssClass="btn btn-warning btn-sm" CommandArgument='<%# Eval("user_id") %>' OnClick="editBtn_Click" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                  </asp:GridView>
                </div>
                <!-- /.card-body -->
              </div>
              <!-- /.card -->
            </div>
            <!-- /.col -->
          </div>
          <!-- /.row -->
        </section>
    </form>
</asp:Content>
