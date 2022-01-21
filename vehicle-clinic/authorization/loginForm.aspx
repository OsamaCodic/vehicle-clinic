<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginForm.aspx.cs" Inherits="vehicle_clinic.authorization.loginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

    <link href="partials/login_page_style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="custom_margin">
        <div class="container">
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4 bg">
                    <h2 class="text-center">Login</h2>
                    <div class="form-group">
                        <label for="email">Email</label>
                        <asp:TextBox ID="email_value" placeholder="Email..." class="form-control" runat="server"/>
                    </div>

                    <div class="form-group">
                        <label for="password">Password</label>
                        <asp:TextBox ID="password_value" placeholder="Password" TextMode="Password" class="form-control" runat="server" />
                    </div>

                    <asp:Button ID="loginForm_Btn" Text="Save" runat="server" OnClick="loginForm_Btn_Click"  class="btn btn-block btn-success"/>
                    
                    <p runat="server" id="error_message" class="errorText"></p>
                 </div>
                <div class="col-md-4"></div>
             </div>
        </div>
    </form>
</body>
</html>
