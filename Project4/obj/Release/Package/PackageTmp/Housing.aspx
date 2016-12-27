<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Housing.aspx.cs" Inherits="Project4.Housing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblEnterId" runat="server" Style="z-index: 1; left: 10px; top: 126px; position: absolute" Text="Enter you Realtor ID"></asp:Label>
        <asp:TextBox ID="txtID" runat="server" Style="z-index: 1; left: 253px; top: 120px; position: absolute"></asp:TextBox>
        <asp:GridView ID="gvHouses" runat="server" AutoGenerateColumns="False" OnRowDeleting="gvHouses_RowDeleting" OnRowEditing="gvHouses_RowEditing" OnRowCancelingEdit="gvHouses_RowCancelingEdit"
            OnRowUpdating="gvHouses_RowUpdating" DataKeyNames ="Id"
            Style="height: 180px; width: 1182px; z-index: 1; left: 17px; top: 319px; position: absolute" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Listing ID" SortExpression="Id"/>
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="City" HeaderText="City" />
                <asp:BoundField DataField="State" HeaderText="State" />
                <asp:BoundField DataField="ListingPrice" HeaderText="Listing Price" />
                <asp:BoundField DataField="SquareFootage" HeaderText="Square Footage" />
                <asp:BoundField DataField="Availability" HeaderText="Availability" />
                <asp:BoundField DataField="NumBedrooms" HeaderText="# of Bedrooms" />
                <asp:BoundField DataField="NumBathrooms" HeaderText="# of Bathrooms" />
                <asp:BoundField DataField="Type" HeaderText="House Type" />
                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Style="z-index: 1; left: 11px; top: 178px; position: absolute" Text="Submit" />
        </p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Style="z-index: 1; left: 10px; top: 47px; position: absolute" Text="Philly Housing Inc."></asp:Label>
        <p>
            <asp:Button ID="btnFindYourHome" runat="server"  Style="z-index: 1; left: 19px; top: 665px; position: absolute" Text="Find Your Home" OnClick="btnFindYourHome_Click" />
        </p>
        <asp:Label ID="lblErrorDisplay" runat="server" style="z-index: 1; left: 12px; top: 252px; position: absolute"></asp:Label>
        <asp:Label ID="lblRealtorIDTip" runat="server" style="z-index: 1; left: 503px; top: 121px; position: absolute" Text="(Enter any values between 1 and 6 for this field)"></asp:Label>
    </form>
</body>
</html>
