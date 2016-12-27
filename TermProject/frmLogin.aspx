<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="TermProject.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fondue</title>
    <link rel="shortcut icon" type="image/png" href="pics/Logo.jpg" />
    <script src="js/jquery-2.1.4.min.js"></script>
    <script src="js/bootstrap.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/custom.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="centered divLoginBackground col-md-3">
            
                <div class="col-md-12 text-center">
                    <asp:Label ID="lblTitle" runat="server" Text="Let's Meet At The Fondue!" CssClass="panel-body"></asp:Label>
                </div>
                <div class="col-md-12">
                    <div class="col-md-1 col-md-pull-3">
                        <img src="pics/Logo.png" class="picsize" />
                    </div>
                    <div class="col-md-2">
                        <div class="form-group form-inline text-center">

                            <asp:Label ID="lblUsername" runat="server" Text="Username" CssClass="control-label" Font-Bold="true"></asp:Label>&nbsp
                        <asp:TextBox ID="txtUserName" runat="server" placeholder="Username" ToolTip="Enter your Username" CssClass="form-control" Width="220px"></asp:TextBox>
                        </div>
                        <div class="form-group form-inline text-center">

                            <asp:Label ID="lblPassword" runat="server" Text="Password" CssClass="control-label" Font-Bold="true"></asp:Label>&nbsp
                        <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" ToolTip="Enter password" CssClass="form-control" Width="220px" TextMode="Password"></asp:TextBox>

                        </div>
                    </div>
                </div>
                <div class="form-group text-center">
                    <asp:Label ID="lblError" runat="server" Text="error" CssClass="control-label" Font-Size="11px"></asp:Label>
                </div>

                <div class="form-group text-center col-md-12">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-success" OnClick="btnLogin_Click" />
                </div>

                <div class="form-group text-center col-md-12">
                    <asp:Button ID="btnRegister" runat="server" Text="Sign up" CssClass="btn btn-primary" Width="200px" OnClick="btnRegister_Click" />
                </div>

                <div class="col-md-12 text-center">
                    <asp:LinkButton ID="LinkForgatPassword" runat="server" Text="Forgot your password or locked out?" OnClick="LinkForgatPassword_Click"></asp:LinkButton>
                </div>
            
        </div>
    </form>
</body>
</html>
