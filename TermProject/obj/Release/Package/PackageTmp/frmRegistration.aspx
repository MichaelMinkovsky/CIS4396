<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRegistration.aspx.cs" Inherits="TermProject.frmRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fondue</title>
    <link rel="shortcut icon" type="image/png" href="pics/Logo.jpg" />
    <script src="js/jquery-2.1.4.min.js"></script>
    <script src="js/bootstrap.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/RegistrationPage.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <br />

        <div class="container-fluid col-md-push-1 panel-body col-md-8 ">

            <div class="col-md-12">
                <div class="col-md-8 panel-body">
                    <div class="col-md-12">
                        <asp:Label ID="lblSignUp" runat="server" Text="Sign Up" Font-Size="20px" Font-Bold="true"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="col-md-12">
                <div class="col-md-8">
                    <div class="col-md-12">
                        <asp:Label ID="lblPersonalInfo" runat="server" Text="Personal Information" CssClass="control-label panel panel-primary" Font-Size="20px" Font-Bold="true"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="col-md-12">
                <div class="col-md-4">
                    <div class="col-md-12">
                        <asp:Label ID="lblFname" runat="server" Text="First Name"></asp:Label>
                        <asp:TextBox ID="txtFName" runat="server" placeholder="First Name" CssClass="form-control" MaxLength="23" AutoPostBack="true" OnTextChanged="txtAnswer1_FocusChanged"></asp:TextBox>
                    </div>
                    <div class="col-md-10">
                        <asp:Label ID="lblErrorFName" runat="server" Text=""></asp:Label>
                        <asp:Image ID="imgCheck" runat="server" Height="20px" Width="20px" />
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="col-md-12">
                        <asp:Label ID="lblLName" runat="server" Text="Last Name"></asp:Label>
                        <asp:TextBox ID="txtLName" runat="server" placeholder="Last Name" CssClass="form-control" MaxLength="23" AutoPostBack="true" OnTextChanged="txtAnswer1_FocusChanged"></asp:TextBox>
                    </div>
                    <div class="col-md-10">
                        <asp:Label ID="lblErrorLName" runat="server" Text=""></asp:Label>
                        <asp:Image ID="imgCheck1" runat="server" Height="20px" Width="20px" />
                    </div>
                </div>
            </div>

            <div class="col-md-12 panel-body">
                <div class="col-md-8">
                    <div class="col-md-12">
                        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                        <asp:TextBox ID="txtAddress" runat="server" placeholder="Address" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtAnswer1_FocusChanged"></asp:TextBox>
                    </div>
                    <div class="col-md-10">
                        <asp:Label ID="lblErrorAddress" runat="server" Text=""></asp:Label>
                        <asp:Image ID="imgCheck2" runat="server" Height="20px" Width="20px" />
                    </div>
                </div>

            </div>

            <div class="col-md-12">
                <div class="col-md-4">
                    <div class="col-md-12">
                        <asp:Label ID="lblState" runat="server" Text="State Name"></asp:Label>
                        <asp:DropDownList ID="ddlState" runat="server" CssClass="form-control" AppendDataBoundItems="true"></asp:DropDownList>
                        <asp:Label ID="lblErrorState" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="col-md-12">
                        <asp:Label ID="lblCity" runat="server" Text="City Name"></asp:Label>
                        <asp:TextBox ID="txtCity" runat="server" placeholder="City Name" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtAnswer1_FocusChanged"></asp:TextBox>
                    </div>
                    <div class="col-md-10">
                        <asp:Label ID="lblErrorCity" runat="server" Text=""></asp:Label>
                        <asp:Image ID="imgCheck3" runat="server" Height="20px" Width="20px" />
                    </div>
                </div>
            </div>

            <div class="col-md-12 panel-body">
                <div class="col-md-8">
                    <div class="col-md-12">
                        <asp:Label ID="lblEmail" runat="server" Text="Email Address"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Email Address" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtAnswer1_FocusChanged"></asp:TextBox>
                    </div>
                    <div class="col-md-10">
                        <asp:Label ID="lblErrorEmail" runat="server" Text=""></asp:Label>
                        <asp:Image ID="imgCheck4" runat="server" Height="20px" Width="20px" />
                    </div>
                </div>
            </div>

            <div class="col-md-12">
                <div class="col-md-8 ">
                    <div class="col-md-12">
                        <br />
                        <asp:Label ID="lblSecQuess" runat="server" Text="Security Questions" CssClass="control-label panel panel-primary" Font-Size="20px" Font-Bold="true"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="col-md-12">
                <div class="col-md-8">
                    <div class="col-md-12">
                        <asp:Label ID="lblSecureQuestion1" runat="server" Text="Security Question 1"></asp:Label>
                        <asp:DropDownList ID="ddlSecureQues1" runat="server" CssClass="form-control" AppendDataBoundItems="true"></asp:DropDownList>
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="col-md-8">
                    <div class="col-md-12">
                        <asp:Label ID="lblAnswer1" runat="server" Text="Answer"></asp:Label>
                        <asp:TextBox ID="txtAnswer1" runat="server" placeholder="Answer" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtAnswer1_FocusChanged"></asp:TextBox>
                    </div>
                    <div class="col-md-10">
                        <asp:Label ID="lblErrorAnswer1" runat="server" Text=""></asp:Label>
                        <asp:Image ID="imgCheck5" runat="server" Height="20px" Width="20px" />
                        <br />
                    </div>
                </div>
            </div>

            <div class="col-md-12 panel-body">
                <div class="col-md-8">
                    <div class="col-md-12">
                        <asp:Label ID="lblSecureQuestion2" runat="server" Text="Security Question 2"></asp:Label>
                        <asp:DropDownList ID="ddlSecureQues2" runat="server" CssClass="form-control" AppendDataBoundItems="true"></asp:DropDownList>
                        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="col-md-8">
                    <div class="col-md-12">
                        <asp:Label ID="lblAnswer2" runat="server" Text="Answer"></asp:Label>
                        <asp:TextBox ID="txtAnswer2" runat="server" placeholder="Answer" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtAnswer1_FocusChanged"></asp:TextBox>
                    </div>
                    <div class="col-md-10">
                        <asp:Label ID="lblErrorAnswer2" runat="server" Text=""></asp:Label>
                        <asp:Image ID="imgCheck6" runat="server" Height="20px" Width="20px" />
                    </div>
                </div>
            </div>

            <div class="col-md-12 panel-body">
                <div class="col-md-8">
                    <div class="col-md-12">
                        <asp:Label ID="lblSecureQuestion3" runat="server" Text="Security Question 3"></asp:Label>
                        <asp:DropDownList ID="ddlSecureQues3" runat="server" CssClass="form-control" AppendDataBoundItems="true"></asp:DropDownList>
                        <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="col-md-8">
                    <div class="col-md-12">
                        <asp:Label ID="lblAnswer3" runat="server" Text="Answer"></asp:Label>
                        <asp:TextBox ID="txtAnswer3" runat="server" placeholder="Answer" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtAnswer1_FocusChanged"></asp:TextBox>
                    </div>
                    <div class="col-md-10">
                        <asp:Label ID="lblErrorAnswer3" runat="server" Text=""></asp:Label>
                        <asp:Image ID="imgCheck7" runat="server" Height="20px" Width="20px" />
                    </div>
                </div>
            </div>

            <div class="col-md-12">
                <div class="col-md-8 ">
                    <div class="col-md-12">
                        <br />
                        <asp:Label ID="lblSignIn" runat="server" Text="Sign in information" CssClass="control-label panel panel-primary" Font-Size="20px" Font-Bold="true"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="col-md-12">
                <div class="col-md-4">
                    <div class="col-md-12">
                        <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
                        <asp:TextBox ID="txtUsername" runat="server" placeholder="Username" CssClass="form-control" MaxLength="23" AutoPostBack="true" OnTextChanged="txtAnswer1_FocusChanged"></asp:TextBox>
                    </div>
                    <div class="col-md-10">
                        <asp:Label ID="lblErrorUsername" runat="server" Text=""></asp:Label>
                        <asp:Image ID="imgCheck8" runat="server" Height="20px" Width="20px" />
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="col-md-12">
                        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                        <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" CssClass="form-control" MaxLength="23" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="col-md-10">
                        <asp:Label ID="lblErrorPassword" runat="server" Text=""></asp:Label>
                        <asp:Image ID="imgCheck9" runat="server" Height="20px" Width="20px" />
                    </div>
                </div>
            </div>

            <div class="col-md-12 panel-body">
                <div class="col-md-8">
                    <div class="col-md-12 text-center">
                        <asp:Button ID="btnContinue" runat="server" Text="Continiue" CssClass="btn btn-primary" Width="150px" OnClick="btnContinue_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
