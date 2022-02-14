<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test_email.aspx.cs" Inherits="vehicle_clinic.test_email" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Click here to send Email</h1>
        <asp:Button Text="Send" ID="sendBtn" OnClick="sendBtn_Click" runat="server" />
    </div>
    </form>
</body>
</html>
