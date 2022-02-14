<%@ Page Title="" Language="C#" MasterPageFile="~/layouts/frontend_layout.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="vehicle_clinic.Frontend.products.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-md-4"></div>
        <div class="col-md-4">
            <form id="front_productForm" runat="server">
                <div>
                    <asp:Repeater ID="front_productsRepeater" runat="server">
                        <ItemTemplate>
                            <table class="table table-responsive table-hover">
                                <tr>
                                    <td>
                                        <asp:Image ImageUrl='<%# "/public/upload_files/" + Eval("file_name")  %>' Height="150px" Width="150px" runat="server"/>
                                    </td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td>
                                                    <h4> <%# Eval("brand_name") %></h4>
                                                    <h6> <%# Eval("product_name") %></h6>
                                                    <label class="text-danger font-weight-bold">Rs - <%# Eval("product_price") %></label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <%--<asp:HyperLink ID="buyBtn" runat="server" Class="btn btn-info btn-sm" NavigateUrl='<%# "~/Frontend/products/details.aspx?product_id=" + Eval("product_id") %>'>Buy</asp:HyperLink>--%>
                                                    <asp:LinkButton Text="Buy" ID="BuyProductBtn" Class="btn btn-info btn-sm" OnClick="BuyProductBtn_Click" CommandArgument='<%# Eval("product_id") %>' runat="server" />
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </form>
        </div>
    <div class="col-md-4"></div>
</asp:Content>
