<%@ Page Title="" Language="C#" MasterPageFile="~/layouts/app_layout.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="vehicle_clinic.Categories.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Categories | Index</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--content-header-->
        <section class="content-header">
          <div class="container-fluid">
            <div class="row mb-2">
              <div class="col-sm-6">
                <h1>All Categories</h1> 
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
                  <h3 class="card-title">Total records <small id="totalRows" runat="server"></small></h3>
                   <asp:LinkButton id="createCategoryBtn" PostBackUrl="~/Categories/form.aspx" CssClass="btn btn-success btn-sm fa-pull-right" runat="server">Create <i class="fa fa-plus" aria-hidden="true"></i></asp:LinkButton>
                </div>
                <!-- /.card-header -->
                <div class="card-body">

                  <div id="alertMessage" class="alert alert-success" role="alert" style="display:none">
                      <h5 class="alert-heading"><i class="fa fa-check-circle" aria-hidden="true"></i> Successfully!</h5>
                      <p>New record created successfully.</p>
                  </div>

                  <asp:GridView ID="categoriesList_gridview" BorderStyle="None" GridLines="None" HeaderStyle-BackColor="#343a40" HeaderStyle-ForeColor="#c2c7d0" HeaderStyle-BorderColor="Black" runat="server" CssClass="table table-striped table-hover" AutoGenerateColumns="false">
                      <Columns>
                        <asp:BoundField DataField="category_title" HeaderText="Title" />
                        <asp:BoundField DataField="category_description" HeaderText="Description" />
                        <asp:BoundField DataField="display_order" HeaderText="Display order" />
                        <asp:BoundField DataField="created_at" ItemStyle-CssClass="text-success text-bold" HeaderText="Created at" />
                        <asp:BoundField DataField="updated_at" ItemStyle-CssClass="text-success text-bold" HeaderText="Updated at" />

                        <asp:TemplateField HeaderText="Actions">
                            <ItemTemplate>
                                <asp:HyperLink ID="EditBtn" runat="server" Class="btn btn-outline-info btn-sm" NavigateUrl='<%# "~/Categories/form.aspx?category_id=" + Eval("category_id") %>'><i class="nav-icon fas fa-edit"></i></asp:HyperLink>
                                <asp:LinkButton ID="deleteBtn" runat="server" CssClass="btn btn-outline-danger btn-sm" OnClick="deleteBtn_Click" CommandArgument='<%# Eval("category_id") %>' OnClientClick="if (!confirm('Are you sure you want delete?')) return false;" ><i class="fa fa-trash" aria-hidden="true"></i></asp:LinkButton>
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
