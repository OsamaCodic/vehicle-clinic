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
                  <table id="example2" class="table table-bordered table-hover">
                    <thead>
                    <tr>
                      <th>Rendering engine</th>
                      <th>Browser</th>
                      <th>Platform(s)</th>
                      <th>Engine version</th>
                      <th>CSS grade</th>
                    </tr>
                    </thead>
                    <tbody>
                    <tr>
                      <td>Trident</td>
                      <td>Internet
                        Explorer 4.0
                      </td>
                      <td>Win 95+</td>
                      <td> 4</td>
                      <td>X</td>
                    </tr>
                    <tr>
                      <td>Trident</td>
                      <td>Internet
                        Explorer 5.0
                      </td>
                      <td>Win 95+</td>
                      <td>5</td>
                      <td>C</td>
                    </tr>
                    </tbody>
                  </table>
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
