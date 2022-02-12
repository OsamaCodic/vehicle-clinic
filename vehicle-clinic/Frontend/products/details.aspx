<%@ Page Title="" Language="C#" MasterPageFile="~/layouts/frontend_layout.Master" AutoEventWireup="true" CodeBehind="details.aspx.cs" Inherits="vehicle_clinic.Frontend.buy_product.product_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-1"></div>
    <div class="col-md-10 detailCard">
        <div class="alert alert-success" role="alert">
          <h4 class="alert-heading"><i class="fas fa-check-circle"></i> Success!</h4>
          <p>Product added successfully to your cart!</p>
        </div>

        <form ID="detailsForm" runat="server"> 
            <div class="row">
                <div class="col-md-4" style="padding:22px;">
                    <asp:image id="preview_Image" width="300" runat="server"/>
                </div>
                <div class="col-md-8" style="padding:22px;">

                    <label>Product</label>
                    <div id="name_render" runat="server"></div>
                    <label>Price</label>
                    <div id="price_render" runat="server"></div>

                    <asp:HiddenField id="productID_hiddenField" value='<% Request.QueryString["product_id"] %>' runat="server" />

                    <div class="form-group">
                        <label for="">Quantity</label>
                        <div class="row">
                               <div class="col-md-6">
                                   <asp:TextBox ID="quanty_txtbox" ReadOnly="true" Text="1" class="form-control" runat="server"/>
                               </div>
                                <div class="col-md-3">
                                    <asp:Button Text="+" ID="plusBtn" OnClick="plusBtn_Click" CssClass="btn btn-default btn-block" runat="server" />
                               </div>
                                <div class="col-md-3">
                                    <asp:Button Text="-" ID="minusBtn" OnClick="minusBtn_Click" CssClass="btn btn-default btn-block" runat="server" />
                               </div>
                        </div>    
                    </div>
                    
                    <hr>
                    <asp:HyperLink CssClass="btn btn-info" NavigateUrl="~/Frontend/products/cart.aspx" runat="server">View cart</asp:HyperLink>
                    <%--<asp:HyperLink ID="buyBtn" runat="server" Class="btn btn-success" NavigateUrl='<%# "~/Frontend/products/checkout.aspx?product_id=" + Eval("product_id") %>'>Checkout out</asp:HyperLink>--%>
                    <asp:Button Text="Checkout" UseSubmitBehavior="true" CssClass="btn btn-success" OnClick="checkoutBtn_Click" ID="checkoutBtn" runat="server" />

                    <asp:LinkButton CssClass="btn btn-danger" Text="Continue shop" PostBackUrl="~/Frontend/products/index.aspx" runat="server" />
                </div>
                
            </div>
        </form>
    </div>
    <div class="col-md-1"></div>
</asp:Content>
