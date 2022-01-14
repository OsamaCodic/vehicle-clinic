<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form.aspx.cs" Inherits="vehicle_clinic.Users.form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create User</title>
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    <style>
        .alertBox{
            background: #d1f9e4;
            padding: 10px;
            border-radius: 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>New User</h2>
            <div class="form-group">
                <label for="">First Name</label>
                <asp:TextBox ID="first_name" placeholder="Enter first name" class="form-control" runat="server"/>
            </div>

            <div class="form-group">
                <label for="">Second Name</label>
                <asp:TextBox ID="second_name" placeholder="Enter second name" class="form-control" runat="server" />
            </div>

            <div class="form-group">
                <label for="">Email:</label>
                <asp:TextBox ID="email" placeholder="Enter email" class="form-control" runat="server" />
            </div>

            <div class="form-group">
                <label for="">Password:</label>
                <asp:TextBox ID="password" placeholder="Enter password" class="form-control" runat="server" />
            </div>

            <asp:Button ID="save_user_Btn" Text="Save" runat="server" OnClick="save_user_Btn_Click" class="btn btn-primary"/>
            <asp:HyperLink ID="back_link" runat="server" NavigateUrl="~/Users/index.aspx" Text="Back to list" />
            <br><br>
           
            <!--  <p class="text-success alertBox" runat="server" id="alertbox"><b> New user created successfully! <b></p> -->
        </div>
    </form>

</body>
</html>
