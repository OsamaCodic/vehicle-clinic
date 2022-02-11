<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="vehicle_clinic.Frontend.products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="productsForm" runat="server">
    <div>
        <asp:Repeater ID="productsRepeater" runat="server">
            <ItemTemplate>
                <table>
                    <tr>
                        <td>
                            <asp:Image ImageUrl='<%# "/public/upload_files/" + Eval("file_name")  %>' Height="80px" Width="80px" runat="server"/>
                        </td>
                        <td>
                            <table>
                                <tr>
                                    <td>
                                        Price
                                    </td>
                                    <td>
                                        <label><%# Eval("product_price") %></label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button Text="Buy" runat="server" CssClass="btn btn-info btn-block" />
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
</body>
</html>
