<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Project4.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="gvHouses" runat="server" AutoGenerateColumns="False" 
            
            Style="height: 180px; width: 1182px; z-index: 1; left: 17px; top: 424px; position: absolute" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gvHouses_SelectedIndexChanged" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Listing ID" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="City" HeaderText="City" />
                <asp:BoundField DataField="State" HeaderText="State" />
                <asp:BoundField DataField="ListingPrice" HeaderText="Listing Price" />
                <asp:BoundField DataField="SquareFootage" HeaderText="Square Footage" />
                <asp:BoundField DataField="Availability" HeaderText="Availability" />
                <asp:BoundField DataField="NumBedrooms" HeaderText="# of Bedrooms" />
                <asp:BoundField DataField="NumBathrooms" HeaderText="# of Bathrooms" />
                <asp:BoundField DataField="Type" HeaderText="House Type" />
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
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
        <asp:Label ID="lblFindYourNewHome" runat="server" style="z-index: 1; left: 10px; top: 50px; position: absolute" Text="Find Your New Home!"></asp:Label>
        <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 19px; top: 138px; position: absolute; right: 1853px" Text="City"></asp:Label>
        <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 172px; top: 139px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblState" runat="server" style="z-index: 1; left: 22px; top: 197px; position: absolute; right: 1850px; height: 27px" Text="State"></asp:Label>
            <asp:TextBox ID="txtState" runat="server" style="z-index: 1; left: 171px; top: 196px; position: absolute; right: 1554px"></asp:TextBox>
            <asp:Label ID="lblBudget" runat="server" style="z-index: 1; left: 21px; top: 254px; position: absolute; right: 1851px; height: 27px" Text="Budget"></asp:Label>
            <asp:TextBox ID="txtBudget" runat="server" style="z-index: 1; left: 171px; top: 251px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtSize" runat="server" style="z-index: 1; left: 915px; top: 189px; position: absolute; right: 810px"></asp:TextBox>
            <asp:Label ID="lblSize" runat="server" style="z-index: 1; left: 721px; top: 193px; position: absolute; height: 27px" Text="Size (sq.ft)"></asp:Label>
            <asp:Label ID="lblType" runat="server" style="z-index: 1; left: 722px; top: 253px; position: absolute; right: 1039px; height: 27px" Text="Home Type"></asp:Label>
        </p>
        <asp:DropDownList ID="ddlHomeType" runat="server" style="z-index: 1; left: 916px; top: 249px; position: absolute; width: 184px;">
            <asp:ListItem Value="single family">single family</asp:ListItem>
            <asp:ListItem>condo</asp:ListItem>
            <asp:ListItem>town house</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnSearch2" runat="server" style="z-index: 1; left: 723px; top: 304px; position: absolute" Text="Search" OnClick="btnSearch2_Click" />
        <p>
            <asp:Label ID="lblBudget2" runat="server" style="z-index: 1; left: 722px; top: 135px; position: absolute; height: 27px" Text="Budget"></asp:Label>
            <asp:TextBox ID="txtBudget2" runat="server" style="z-index: 1; left: 914px; top: 130px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblOR" runat="server" style="z-index: 1; left: 519px; top: 193px; position: absolute; right: 1353px; height: 26px" Text="OR"></asp:Label>
        <asp:Button ID="btnSearch1" runat="server" style="z-index: 1; left: 21px; top: 304px; position: absolute" Text="Search" OnClick="btnSearch1_Click" />
        </p>
        <asp:Label ID="lblErrorDisplay" runat="server" style="z-index: 1; left: 21px; top: 371px; position: absolute"></asp:Label>
        <asp:Label ID="lblAppointment" runat="server" style="z-index: 1; left: 22px; top: 734px; position: absolute" Text="Appointment"></asp:Label>
        <p>
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 22px; top: 784px; position: absolute" Text="Name :"></asp:Label>
            <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 24px; top: 837px; position: absolute" Text="Date :"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblTime" runat="server" style="z-index: 1; left: 25px; top: 898px; position: absolute" Text="Time :"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 159px; top: 781px; position: absolute; right: 1768px"></asp:TextBox>
            <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 159px; top: 834px; position: absolute; right: 1768px"></asp:TextBox>
            <asp:TextBox ID="txtTime" runat="server" style="z-index: 1; left: 160px; top: 892px; position: absolute; right: 1767px"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" style="z-index: 1; left: 26px; top: 959px; position: absolute" Text="Submit" OnClick="btnSubmit_Click" />
        </p>
        <asp:GridView ID="gvAppointments" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" style="z-index: 1; left: 21px; top: 781px; position: absolute; height: 180px; width: 289px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="RequestID" HeaderText="Request ID" />
                <asp:BoundField DataField="RequestPersonName" HeaderText="Name" />
                <asp:BoundField DataField="Date" HeaderText="Date" DataFormatString="{0:M/d/yyyy}"/>
                <asp:BoundField DataField="Time" HeaderText="Time" />
                <asp:BoundField DataField="Address" HeaderText="House Address" />
                <asp:BoundField DataField="City" HeaderText="City" />
                <asp:BoundField DataField="State" HeaderText="State" />
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
        <asp:Label ID="lblAppointments" runat="server" style="z-index: 1; left: 22px; top: 735px; position: absolute" Text="Appointments"></asp:Label>
    </form>
</body>
</html>
