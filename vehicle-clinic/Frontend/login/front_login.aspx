<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="front_login.aspx.cs" Inherits="vehicle_clinic.Frontend.login.front_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VehicleClinic | Login</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>


    <style>
        .frontbg{
            background: #b3b3b3;
            border-radius: 15px;
            box-shadow: 0px 0px 20px 0px #4d4d4d;
            margin-top:100px;
            padding: 22px;
        }
        .errorText{
            color: red;
            margin-top:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="custom_margin">
        <div class="container">
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4 frontbg">
                    <h2 class="text-center">VehicleClinic Login</h2>
                    <div class="form-group">
                        <label for="email">Email</label>
                        <asp:TextBox ID="email_value" placeholder="Email..." class="form-control" runat="server"/>
                    </div>

                    <div class="form-group">
                        <label for="password">Password</label>
                        <asp:TextBox ID="password_value" placeholder="Password" TextMode="Password" class="form-control" runat="server" />
                    </div>

                    <asp:Button ID="front_loginForm_Btn" Text="Login" runat="server" OnClick="front_loginForm_Btn_Click" class="btn btn-block btn-info"/>
                    <br />
                    <asp:HyperLink NavigateUrl="~/Frontend/login/registerUser.aspx" runat="server">Register here if you're not!</asp:HyperLink>

                    <p runat="server" id="error_message"  class="errorText"></p>
                 </div>
                <div class="col-md-4"></div>
             </div>
        </div>
    </form>
</body>
</html>
