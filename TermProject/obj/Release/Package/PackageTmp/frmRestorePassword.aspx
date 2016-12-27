<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRestorePassword.aspx.cs" Inherits="TermProject.frmRestorePassword" %>

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

        <div class="form-group col-md-12 panel-body">
            <div class="form-group col-md-7">
                <div class="col-md-12">
                    <asp:Label ID="lblQuestion1" runat="server" Text="Pick your first Question" CssClass="control-label"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:DropDownList ID="ddlQuestion1" runat="server" CssClass="form-control" AppendDataBoundItems="true"></asp:DropDownList>
                </div>
                <br />
            </div>

            <div class="form-group col-md-7">
                <div class="col-md-12">
                    <asp:Label ID="Answer1" runat="server" Text="Write your answer" CssClass="control-label"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtAnswer1" runat="server" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtAnswer1_FocusChanged"></asp:TextBox>
                </div>
                <div class="row col-md-2">
                    <asp:Image ID="imgCheck" runat="server" Height="25px" Width="25px" CssClass="" />
                </div>
            </div>
        </div>


        <div class="form-group col-md-12">
            <div class="form-group col-md-7">
                <div class="col-md-12">
                    <asp:Label ID="lblQuestion2" runat="server" Text="Pick your second Question" CssClass="control-label"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:DropDownList ID="ddlQuestion2" runat="server" CssClass="form-control" AppendDataBoundItems="true"></asp:DropDownList>
                </div>
                <br />
            </div>
            <div class="form-group col-md-7">
                <div class="col-md-12">
                    <asp:Label ID="Answer2" runat="server" Text="Write your answer" CssClass="control-label"></asp:Label>
                </div>

                <div class="col-md-10">
                    <asp:TextBox ID="txtAnswer2" runat="server" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtAnswer2_FocusChanged"></asp:TextBox>
                </div>
                <div class="row col-md-2">
                    <asp:Image ID="imgCheck1" runat="server" Height="25px" Width="25px" CssClass="" />
                </div>
            </div>
        </div>

        <div class="form-group col-md-12 panel-body">
            <div class="form-group col-md-7">
                <div class="col-md-12">
                    <asp:Label ID="lblQuestion3" runat="server" Text="Pick your three Question" CssClass="control-label"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:DropDownList ID="ddlQuestion3" runat="server" CssClass="form-control" AppendDataBoundItems="true"></asp:DropDownList>
                </div>
                <br />
            </div>
            <div class="form-group col-md-7">
                <div class="col-md-12">
                    <asp:Label ID="Answer3" runat="server" Text="Write your answer" CssClass="control-label"></asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox ID="txtAnswer3" runat="server" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtAnswer3_FocusChanged"></asp:TextBox>
                </div>
                <div class="row col-md-2">
                    <asp:Image ID="imgCheck2" runat="server" Height="25px" Width="25px" CssClass="" />
                </div>

                <br />
                <div class="form-group col-md-6 panel-body">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn btn-success" />
                </div>

                <br />
                <br />
                <div class="form-group col-md-12">
            <asp:Label ID="lblRetriveInfo" runat="server" Text="" CssClass="control-label"></asp:Label>
        </div>
            </div>
        </div>
        

    </form>
</body>
</html>
