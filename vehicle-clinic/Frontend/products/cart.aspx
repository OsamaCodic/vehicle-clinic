<%@ Page Title="" Language="C#" MasterPageFile="~/layouts/frontend_layout.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="vehicle_clinic.Frontend.products.cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="col-md-1"></div>
    <form id="cartForm" runat="server">
        <div>
            <div class="col-md-10">
                <h3>Cart list <asp:HyperLink CssClass="btn btn-warning pull-right" NavigateUrl="~/Frontend/products/index.aspx" runat="server">Continue Shop</asp:HyperLink></h3>
                <br>
                <asp:GridView ID="cartList_gridview" runat="server" BorderStyle="None" GridLines="None" HeaderStyle-BackColor="#343a40" HeaderStyle-ForeColor="#c2c7d0" HeaderStyle-BorderColor="Black" runat="server" CssClass="table table-striped table-hover" AutoGenerateColumns="true">
                </asp:GridView>
            </div>
        </div>
    </form>

    <div class="col-md-1"></div>

</asp:Content>
