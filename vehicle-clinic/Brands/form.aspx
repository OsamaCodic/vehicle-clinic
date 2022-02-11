<%@ Page Title="" Language="C#" MasterPageFile="~/layouts/app_layout.Master" AutoEventWireup="true" CodeBehind="form.aspx.cs" Inherits="vehicle_clinic.Brands.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <!--content-header-->
        <section class="content-header">
          <div class="container-fluid">
            <div class="row mb-2">
              <div class="col-sm-6">
                <h1>Brand</h1>
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
            <form runat="server" id="brandForm">
                <div class="card-body">

                    <div class="form-group">
                        <label for="">Title <span class="required">*</span></label>
                        <asp:TextBox ID="title_txtbox" placeholder="Enter brand title" class="form-control" runat="server"/>
                        <asp:requiredfieldvalidator id="brand_title_required" runat="Server" errormessage="Brand title is required!" controltovalidate="title_txtbox" display="Dynamic" forecolor="Red" />
                    </div>

                    <div class="form-group">
                        <label for="description_txtbox">Description</label>
                        <asp:TextBox ID="description_txtbox" TextMode="MultiLine" MaxLength="190" Height="100" placeholder="Enter brand description" class="form-control" runat="server"/>
                    </div>

                    <div class="form-group">
                        <label for="display_order">Display order <span class="required">*</span></label>
                        <asp:TextBox ID="display_order_txtbox" TextMode="number" placeholder="Enter display order" class="form-control" runat="server"/>
                        <asp:requiredfieldvalidator id="brand_display_order_required" runat="Server" errormessage="Display order is required!" controltovalidate="display_order_txtbox" display="Dynamic" forecolor="Red" />
                    </div>

                    <div class="form-group">
                      <label for="">Brand Logo <span class="required">*</span></label> <br/>
                      <asp:FileUpload ID="brandLogo" runat="server" />
                       <asp:image id="preview_Image" width="200" runat="server" />
                       <br />
                   </div>
                    <div class="required" id="custom_logo_required" runat="server"></div> <br/>

                    <div class="card-footer">
                        <asp:Button ID="submitBtn" OnClick="submitBtn_Click" class="btn btn-primary btn-sm" Text="Save" runat="server" />
                    </div>
                </div>
            </form>
        </div>
    </div>


</asp:Content>
