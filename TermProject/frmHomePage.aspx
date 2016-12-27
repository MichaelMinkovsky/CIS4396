<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmHomePage.aspx.cs" Inherits="TermProject.frmHomePage"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fondue</title>
    <link rel="shortcut icon" type="image/png" href="pics/Logo.jpg" />
    <script src="js/jquery-2.1.4.min.js"></script>
    <script src="js/bootstrap.js"></script>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/HomePage.css" rel="stylesheet" />
</head>

<body id="bdBody" runat="server">
    <form id="form1" runat="server">
        <nav class="navbar navbar-inverse">
            <div class="container-fluid">
                <div class="navbar-header">
                    <a class="navbar-brand" href="#">
                        <img src="pics/Logo.jpg" class="picsize" /></a>
                </div>
                <ul class="nav navbar-nav">
                    <li class="active"><a href="#">Fondue Home</a></li>
                </ul>
                <div class="col-sm-3 col-md-3">
                    <div class="navbar-form" role="search">
                        <div class="input-group">
                            <asp:TextBox ID="txtSearch" runat="server" class="form-control" placeholder="Search name/username" ToolTip="Search by name or username" name="srch-term"></asp:TextBox>
                            <div class="input-group-btn">
                                <asp:ImageButton ID="ImbSubmit" runat="server" Width="34px" Height="34px" OnClick="btnSearch_Click" ImageUrl="http://www.officialpsds.com/images/thumbs/Magnifying-Glass-psd55274.png" BackColor="White" />
                            </div>
                        </div>
                    </div>
                </div>
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="#"><span id="txtUsername" runat="server" class="glyphicon glyphicon-user"></span></a></li>
                    <li>
                        <asp:LinkButton ID="btnPersonalInfo" runat="server" Text=" Personal Information" OnClick="btnPersonalInform" class="glyphicon glyphicon-info-sign" /></li>
                    <li>
                        <asp:LinkButton ID="btnSettings" runat="server" Text=" Settings" OnClick="btnSettings_Click" class="glyphicon glyphicon-cog" /></li>
                    <li>
                        <asp:LinkButton ID="btnSignOut" runat="server" Text=" Sign out" OnClick="btnSignOut_Click" class="glyphicon glyphicon-cog" /></li>
                </ul>
            </div>
        </nav>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <div class="col-md-12">
            <%--Pictures and other stuff--%>
            <div class="col-md-3">
                <div class="col-md-12">
                    <asp:ImageButton ID="ImgUrl" runat="server" Height="167px" ImageUrl="~/pics/blank_picture.jpg" OnClick="ImgUrl_Click" />
                </div>
                <br />
                <br />
                <br />
                <div class="col-md-12">
                    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#JobModal">Your Jobs</button>
                </div>

                <div class="col-md-12 panel-body">
                    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#Education">Your Education</button>
                </div>

                <div class="col-md-12">
                    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#About">Your Education</button>
                </div>

                <div class="col-md-12 panel-body row">
                    <div class="col-md-12">
                        <asp:Button ID="btnAdvancedSearch" runat="server" Text="Advanced Search" CssClass="btn btn-success" OnClick="btnAdvancedSearch_Click" />
                    </div>

                    <div class="input-group col-md-12 panel-body">
                        <asp:TextBox ID="txtAdvancedSearch" runat="server" class="form-control row" placeholder="Search by hobby" ToolTip="Search by hobby"></asp:TextBox>
                        <asp:HiddenField ID="HFfield" runat="server" />
                        <div class="input-group-btn col-md-12">
                            <asp:ImageButton ID="IBadvanced" runat="server" Width="34px" Height="34px" ImageUrl="http://www.officialpsds.com/images/thumbs/Magnifying-Glass-psd55274.png" BackColor="White" OnClick="IBadvanced_Click" />
                        </div>
                    </div>
                    <div class="col-md-12">
                        <asp:ImageButton ID="IBSeeNewsFeed" runat="server" ImageUrl="~/pics/newsFeedReady.png" ToolTip="press to see news feeds" Width="150px" OnClick="IBSeeNewsFeed_Click" />
                    </div>
                    <div class="col-md-12">
                        <asp:Button ID="btnRequests" runat="server" Text="See Friend Requests" CssClass="btn btn-success" OnClick="btnRequests_Click" />
                    </div>


                </div>
            </div>


            <%--News Feed--%>
            <div class="col-md-6">
                <div class="col-md-12">
                    <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>
                </div>

                <div class="col-md-12">
                    <asp:TextBox ID="txtInput" runat="server" placeholder="Add your news feed" ToolTip="Add your news feed" Width="550px" Height="100px"></asp:TextBox>
                    <asp:Button ID="btnSubmitNewsFeed" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="btnSubmitNewsFeed_Click" />
                    <asp:TextBox ID="txtVideoUrl" runat="server" placeholder="Place your Video URL here" ToolTip="Video URL HERE" Width="550px" Height="100px"></asp:TextBox>
                </div>

                <div class="col-md-12">
                    <asp:GridView ID="gvAdvancedSearch" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="AboutMe" HeaderText="About" />
                            <asp:BoundField DataField="FavoriteQoutes" HeaderText="FavoriteQuotes" />
                            <asp:BoundField DataField="Hobbies" HeaderText="Hobby" />
                            <asp:BoundField DataField="Username" HeaderText="Username" />
                        </Columns>
                    </asp:GridView>
                </div>
                <div class="col-md-12">
                    <asp:GridView ID="gvSearch" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvSearch_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                            <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                            <asp:BoundField DataField="Username" HeaderText="Username" />
                            <asp:BoundField DataField="AboutMe" HeaderText="About" />
                            <asp:CommandField ButtonType="Button" SelectText="Send Friend Request" ShowSelectButton="True" ControlStyle-CssClass="btn btn-success" />
                        </Columns>
                    </asp:GridView>
                </div>

                <div class="col-md-12">
                    <asp:GridView ID="gvNewsFeed" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="UserName" HeaderText="Username" />
                            <asp:BoundField DataField="NewsFeed" HeaderText="Newsfeed" />
                            <asp:TemplateField HeaderText="Video URL" ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton_Click" CausesValidation="false" CommandName="" Text='<%# Eval("VideoURL") %>'></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>

                <div class="col-md-12">
                    <asp:GridView ID="gvFriendRequest" runat="server" AutoGenerateColumns="False" OnRowCommand="gvFriendRequst_RowCommand" DataKeyNames="RequestID, friendUsername">
                        <Columns>
                            <asp:BoundField DataField="RequestID" HeaderText="RequestID" Visible="false" SortExpression="ReruestID" />
                            <asp:ImageField DataImageUrlField="CurrentPicture">
                            </asp:ImageField>
                            <asp:BoundField DataField="friendUsername" HeaderText="Username" SortExpression="friendUsername" />
                            <asp:BoundField DataField="requestStatus" HeaderText="Status" />
                            <asp:ButtonField ButtonType="Button" Text="Accept" ControlStyle-CssClass="btn btn-success" CommandName="Accept">
                                <ControlStyle CssClass="btn btn-success"></ControlStyle>
                            </asp:ButtonField>
                            <asp:ButtonField ButtonType="Button" Text="Reject" ControlStyle-CssClass="btn btn-primary" CommandName="Reject">
                                <ControlStyle CssClass="btn btn-primary"></ControlStyle>
                            </asp:ButtonField>
                        </Columns>
                    </asp:GridView>
                </div>



            </div>
            <%--Buddy List--%>
            <%--AjaxFrameworkMode is here --%>
            <div class="col-md-3">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="True">
                        <ContentTemplate>
                <div class="col-md-12">
                            <asp:Timer ID="Timer1" runat="server" Interval="60000" OnTick="Timer1_Tick"></asp:Timer>
                            <asp:GridView ID="gvBuddyList" runat="server" AutoGenerateColumns="False" DataKeyNames="FriendID_FK,BuddyUserName" OnSelectedIndexChanged="gvBuddyList_SelectedIndexChanged">
                                <Columns>
                                    <asp:BoundField DataField="FriendID_FK" HeaderText="User ID" Visible="false" SortExpression="FriendID_FK" />
                                    <asp:ImageField DataImageUrlField="CurrentPicture" ControlStyle-Width="50px" ControlStyle-Height="50px">
                                        <ControlStyle Height="50px" Width="50px"></ControlStyle>
                                    </asp:ImageField>
                                    <asp:BoundField DataField="BuddyUserName" HeaderText="Usernames" SortExpression="BuddyUserName" />
                                    <asp:BoundField DataField="OnlineStatus" HeaderText="Status" />
                                    <asp:CommandField ButtonType="Button" SelectText="Chat" ShowSelectButton="True" ControlStyle-CssClass="btn btn-primary" />
                                </Columns>
                            </asp:GridView>

                            </div>

                            <div class="col-md-12">
                                <asp:HiddenField ID="HF" runat="server" Value="false"/>
                                <asp:GridView ID="gvMesseger" runat="server" AutoGenerateColumns="False" DataKeyNames="messageID" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                                    <Columns>
                                        <asp:BoundField DataField="messageID" HeaderText="Messege ID" SortExpression="messageID" Visible="false" />
                                        <asp:BoundField DataField="MessageSend" HeaderText="Send" />
                                        <asp:BoundField DataField="MessageRecieved" HeaderText="Received" />
                                    </Columns>
                                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                                    <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                                    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#594B9C" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#33276A" />
                                </asp:GridView>
                            </div>
                            <div class="col-md-12">
                                <div class="col-md-12">
                                    <asp:TextBox ID="txtMessage" runat="server" placeholder="Enter your message" ToolTip="Enter your message" Height="100px" Width="245px"></asp:TextBox>
                                </div>
                                <div class="col-md-12">
                                    <asp:Button ID="btnSendMessage" runat="server" Text="Chat" CssClass="btn btn-primary" OnClick="btnSendMessage_Click" />
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>


            </div>
            <%-- Modal Job--%>
            <div class="modal fade" id="JobModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                            <h4 class="modal-title" id="myModalLabel">Your Jobs</h4>
                        </div>
                        <div class="modal-body">
                            <asp:GridView ID="gvJobs" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                                <Columns>
                                    <asp:BoundField DataField="CompanyName" HeaderText="Company Name" HeaderStyle-Width="110px" />
                                    <asp:BoundField DataField="Position" HeaderText="Position" HeaderStyle-Width="110px" />
                                    <asp:BoundField DataField="CityName" HeaderText="City" HeaderStyle-Width="110px" />
                                    <asp:BoundField DataField="Description" HeaderText="Description" HeaderStyle-Width="110px" />
                                </Columns>
                                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" CssClass="text-center" />
                                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#33276A" />
                            </asp:GridView>
                        </div>

                    </div>
                </div>
            </div>

            <%-- Modal Education--%>
            <div class="modal fade" id="Education" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                            <h4 class="modal-title" id="H1">Your Jobs</h4>
                        </div>
                        <div class="modal-body">
                            <asp:GridView ID="gvEducation" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                                <Columns>
                                    <asp:BoundField DataField="SchoolName" HeaderText="School Name" HeaderStyle-Width="110px" />
                                    <asp:BoundField DataField="DateStart" HeaderText="Start Date" HeaderStyle-Width="110px" DataFormatString="{0:M/d/yyyy}" />
                                    <asp:BoundField DataField="DateEnd" HeaderText="Graduate Date" HeaderStyle-Width="110px" DataFormatString="{0:M/d/yyyy}" />
                                    <asp:BoundField DataField="SchoolDescription" HeaderText="Description" HeaderStyle-Width="110px" />
                                    <asp:BoundField DataField="Major" HeaderText="Major" HeaderStyle-Width="110px" />
                                </Columns>
                                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" CssClass="text-center" />
                                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#33276A" />
                            </asp:GridView>
                        </div>

                    </div>
                </div>
            </div>

            <%-- Modal About--%>
            <div class="modal fade" id="About" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                            <h4 class="modal-title" id="H2">Your Jobs</h4>
                        </div>
                        <div class="modal-body">
                            <asp:GridView ID="gvAbout" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                                <Columns>
                                    <asp:BoundField DataField="AboutMe" HeaderText="About" HeaderStyle-Width="110px" ItemStyle-Wrap="true" />
                                    <asp:BoundField DataField="FavoriteQoutes" HeaderText="Favorite Quotes" HeaderStyle-Width="110px" />
                                    <asp:BoundField DataField="Hobbies" HeaderText="Hobbies" HeaderStyle-Width="110px" />
                                </Columns>
                                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" CssClass="text-center" />
                                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#33276A" />
                            </asp:GridView>
                        </div>

                    </div>
                </div>
            </div>
    </form>
</body>
</html>
