<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="CIS3342Solution.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            <asp:Label ID="lblDisplay" runat="server" style="z-index: 1; left: 447px; top: 103px; position: absolute" Text="lbldisplayhaha"></asp:Label>
        </p>
        <asp:TextBox ID="txtInput" runat="server" style="z-index: 1; left: 407px; top: 142px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="z-index: 1; left: 442px; top: 193px; position: absolute" Text="Button" />
    </form>
</body>
</html>
