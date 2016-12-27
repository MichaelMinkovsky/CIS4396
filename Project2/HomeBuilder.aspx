<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeBuilder.aspx.cs" Inherits="Project2.HomeBuilder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Builder System</title>
</head>
<body style="top: 0px; left: 0px; position: absolute; height: 1539px; width: 1995px">
    <h2>Home Builder System</h2>
    <h4>By Joel Manatharayil</h4>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 174px; top: 199px; position: absolute; width: 311px"></asp:TextBox>
        <asp:Label ID="lblName" runat="server" Text="Name" style="top: 199px; left: 3px; position: absolute; height: 27px; width: 57px"></asp:Label>    
        <asp:Label ID="lblAddress" runat="server" Text="Address" style="top: 245px; left: 3px; position: absolute; height: 27px; width: 78px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 174px; top: 245px; position: absolute; width: 526px"></asp:TextBox>
        <asp:TextBox ID="txtNum" runat="server" style="z-index: 1; left: 174px; top: 294px; position: absolute; width: 311px"></asp:TextBox>
        <asp:Label ID="lblPhoneNumber" runat="server" style="top: 294px; left: 3px; position: absolute; height: 27px; width: 145px" Text="Phone Number"></asp:Label>

        <p>
            &nbsp;</p>
        <asp:GridView ID="gvBedroom" runat="server" style="z-index: 1; left: 3px; top: 855px; position: absolute; height: 180px; width: 439px" AutoGenerateColumns="False" CellPadding="3" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px">
            <AlternatingRowStyle BackColor="Gainsboro" />
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Bedroom_Upgrade" HeaderText="Upgrade To" />
                <asp:BoundField DataField="Bedroom_Price" HeaderText="Price" />
                <asp:BoundField DataField="RoomName" HeaderText="Room Name" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:GridView ID="gvRooms" runat="server" style="z-index: 1; left: 3px; top: 431px; position: absolute; height: 309px; width: 856px" AutoGenerateColumns="False" CellPadding="3" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="RoomDescription" HeaderText="Room Description" />
                <asp:BoundField DataField="PricePerSqFt" HeaderText="Price (Sq.Ft)" />
                <asp:TemplateField HeaderText="Length">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" > </asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Width">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" > </asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:GridView ID="gvKitchen" runat="server" style="z-index: 1; left: 550px; top: 855px; position: absolute; height: 180px; width: 439px" AutoGenerateColumns="False" CellPadding="3" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px">
            <AlternatingRowStyle BackColor="Gainsboro" />
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Kitchen_Upgrade" HeaderText="Upgrade To" />
                <asp:BoundField DataField="Kitchen_Price" HeaderText="Price" />
                <asp:BoundField DataField="RoomName" HeaderText="Room Name" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:Label ID="lblRoomDisplay" runat="server" style="z-index: 1; left: 3px; top: 399px; position: absolute; height: 31px" Text="Select Rooms"></asp:Label>
        <asp:Label ID="lblKitchenUpgrade" runat="server" style="z-index: 1; left: 551px; top: 825px; position: absolute" Text="Select Upgrades for Kitchen"></asp:Label>
        <asp:GridView ID="gvBathroom" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" style="z-index: 1; left: 1105px; top: 855px; position: absolute; height: 180px; width: 430px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Bathroom_Upgrade" HeaderText="Upgrade to" />
                <asp:BoundField DataField="Bathroom_Price" HeaderText="Price" />
                <asp:BoundField DataField="RoomName" HeaderText="Room Name" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:Label ID="lblBathroomUpgrade" runat="server" style="z-index: 1; left: 1106px; top: 825px; position: absolute" Text="Select Upgrades for Bathroom"></asp:Label>
        <asp:Button ID="btnSubmit" runat="server" style="z-index: 1; left: 3px; top: 1123px; position: absolute" Text="Submit" OnClick="btnSubmit_Click" />
        <asp:GridView ID="gvLivingRoom" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" style="z-index: 1; left: 1113px; top: 484px; position: absolute; height: 180px; width: 421px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="LivingRoom_Upgrade" HeaderText="Upgrade To" />
                <asp:BoundField DataField="LivingRoom_Price" HeaderText="Price" />
                <asp:BoundField DataField="RoomName" HeaderText="Room Name" SortExpression="RoomName" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <p>
            <asp:Label ID="lblLivingRoomUpgrade" runat="server" style="z-index: 1; left: 1116px; top: 452px; position: absolute" Text="Select Upgrades for Living Room"></asp:Label>
        </p>
        <asp:Label ID="lblBedroomUpgrade" runat="server" style="z-index: 1; left: 5px; top: 825px; position: absolute" Text="Select Upgrades for Bedroom"></asp:Label>
        <asp:GridView ID="gvOutput" runat="server" ShowFooter="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" style="z-index: 1; left: 766px; top: 135px; position: absolute; height: 180px; width: 289px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField= "RoomDescription" HeaderText="Room Description" FooterText="Grand Total: " />
                <asp:BoundField DataField= "Price" HeaderText="Price" />
                <asp:BoundField DataField= "UpgradesCost" HeaderText="Upgrade Cost" />
                <asp:BoundField DataField= "TotalCost" HeaderText="Total Cost" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:Label ID="lblOutputName" runat="server" style="z-index: 1; left: 7px; top: 142px; position: absolute"></asp:Label>
        <asp:Label ID="lblErrorDisplay" runat="server" style="z-index: 1; left: 4px; top: 353px; position: absolute"></asp:Label>
        <asp:Label ID="lblOutputAddress" runat="server" style="z-index: 1; left: 6px; top: 180px; position: absolute"></asp:Label>
        <p>
            <asp:Label ID="lblOutputPhoneNumber" runat="server" style="z-index: 1; left: 5px; top: 221px; position: absolute"></asp:Label>
        </p>
        <asp:Label ID="lblOutputMessage" runat="server" style="z-index: 1; left: 8px; top: 109px; position: absolute"></asp:Label>
    </form>
</body>
</html>
