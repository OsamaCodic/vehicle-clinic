<%@ Page Title="" Language="C#" MasterPageFile="~/layouts/app_layout.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="vehicle_clinic.Products.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Products | Index</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--content-header-->
        <section class="content-header">
          <div class="container-fluid">
            <div class="row mb-2">
              <div class="col-sm-6">
                <h1>All Products</h1> 
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
                   <asp:LinkButton id="createProductBtn" PostBackUrl="~/Products/form.aspx" CssClass="btn btn-success btn-sm fa-pull-right" runat="server">Add Product <i class="fa fa-plus" aria-hidden="true"></i></asp:LinkButton>
                </div>
                <!-- /.card-header -->
                <div class="card-body">
                  <asp:GridView ID="productsList_gridview" BorderStyle="None" GridLines="None" HeaderStyle-BackColor="#343a40" HeaderStyle-ForeColor="#c2c7d0" HeaderStyle-BorderColor="Black" runat="server" CssClass="table table-striped table-hover tableScroll" AutoGenerateColumns="false">
                      <Columns>
                        <asp:BoundField DataField="category_title" HeaderText="Category" />
                        <asp:BoundField DataField="brand_title" HeaderText="Brand" />
                        <asp:BoundField DataField="product_name" HeaderText="Product" />
                        <asp:BoundField DataField="product_price" HeaderText="Price" />
                        <asp:BoundField DataField="product_colours" HeaderText="Colours" />
                        <asp:BoundField DataField="product_dimensions" HeaderText="Dimensions" />
                        <asp:BoundField DataField="product_weight" HeaderText="Weight" />
                        <asp:BoundField DataField="release_date" HeaderText="Release Date" />
                        <asp:BoundField DataField="display_order" HeaderText="Display Order" />
                        <asp:TemplateField HeaderText="Images">
                            <ItemTemplate>
                                <asp:Image ImageUrl='<%# "/public/upload_files/" + Eval("file_name")  %>' Height="80px" Width="80px" runat="server"/>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Actions">
                            <ItemTemplate>
                                <asp:HyperLink ID="EditBtn" runat="server" Class="btn btn-outline-info btn-sm" NavigateUrl='<%# "~/Products/form.aspx?product_id=" + Eval("product_id") %>'><i class="nav-icon fas fa-edit"></i></asp:HyperLink>
                                <asp:LinkButton ID="deleteBtn" runat="server" CssClass="btn btn-outline-danger btn-sm" OnClick="deleteBtn_Click" CommandArgument='<%# Eval("product_id") %>' OnClientClick="if (!confirm('Are you sure you want delete?')) return false;" ><i class="fa fa-trash" aria-hidden="true"></i></asp:LinkButton>
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
