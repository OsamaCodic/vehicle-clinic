<%@ Page Title="" Language="C#" MasterPageFile="~/layouts/app_layout.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="vehicle_clinic.dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>VehicleClinic | Dashboard</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <!--content-header-->
        <section class="content-header">
          <div class="container-fluid">
            <div class="row mb-2">
              <div class="col-sm-11">
                <h1>Dashboard</h1>
              </div>
              <div class="col-sm-1">
                <form id="logoutForm" runat="server">
                    <asp:Button Text="Logout" CssClass="btn btn-danger btn-sm" ID="logoutBtn" runat="server" OnClick="logoutBtn_Click"/>
                </form>
              </div>
            </div>
          </div>
        </section>
    <!--content-header--> 

    <div class="row">
          <div class="col-lg-3 col-6">
            <!-- small box -->
            <div class="small-box bg-warning">
              <div class="inner">
                <h3 id="total_user_box" runat="server"></h3>
                <p>Total users</p>
              </div>
              <div class="icon">
                <i class="ion ion-person-add"></i>
              </div>
              <a href="Users/index.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>

          <div class="col-lg-3 col-6">
            <!-- small box -->
            <div class="small-box bg-info">
              <div class="inner">
                <h3 id="total_categories_box" runat="server"></h3>

                <p>Total Categories</p>
              </div>
              <div class="icon">
                <i class="fas fa-th"></i>
              </div>
              <a href="Categories/index.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>

            <div class="col-lg-3 col-6">
                <!-- small box -->
                <div class="small-box bg-secondary">
                  <div class="inner">
                    <h3 id="total_brands_box" runat="server"></h3>

                    <p>Total Brands</p>
                  </div>
                  <div class="icon">
                    <i class="ion ion-bag"></i>
                  </div>
                  <a href="Brands/index.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></a>
                </div>
              </div>

          <div class="col-lg-3 col-6">
            <div class="small-box bg-success">
              <div class="inner">
                <h3 id="total_products_box" runat="server"></h3>
                <p>Total products</p>
              </div>
              <div class="icon">
                  <i class="fas fa-barcode"></i>
              </div>
              <a href="Products/index.aspx" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>

        </div>
</asp:Content>
