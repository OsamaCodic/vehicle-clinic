<%@ Page Title="" Language="C#" MasterPageFile="~/layouts/app_layout.Master" AutoEventWireup="true" CodeBehind="form.aspx.cs" Inherits="vehicle_clinic.Products.form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
     <!--content-header-->
        <section class="content-header">
          <div class="container-fluid">
            <div class="row mb-2">
              <div class="col-sm-6">
                <h1>Product</h1>
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
            <form runat="server" id="productForm">
                <div class="card-body">

                    <asp:FileUpload ID="productImages" runat="server" />
                    
                    <div class="card-footer">
                        <asp:Button ID="submitBtn" OnClick="submitBtn_Click" class="btn btn-primary btn-sm" Text="Save" runat="server" />
                    </div>
                </div>
            </form>
        </div>
    </div>

</asp:Content>
