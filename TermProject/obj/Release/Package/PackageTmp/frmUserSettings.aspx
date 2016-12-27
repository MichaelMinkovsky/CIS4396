<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmUserSettings.aspx.cs" Inherits="TermProject.frmUserSettings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" id="htmlStyle" runat="server">
<head runat="server">
    <title>Fondue</title>
    <link rel="shortcut icon" type="image/png" href="pics/Logo.jpg" />
    <script src="js/jquery-2.1.4.min.js"></script>
    <script src="js/bootstrap.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/RegistrationPage.css" rel="stylesheet" />
</head>
<body id="bdBody" runat="server">
    <form id="form1" runat="server">

        <br />
        <br />
        <br />

        <div class="container-fluid col-md-push-1 panel-body col-md-8 ">

            <div class="col-md-12">
                <div class="col-md-8 panel-body">
                    <div class="col-md-12">
                        <asp:Label ID="lblThemes" runat="server" Text="Themes Settings" Font-Size="20px" Font-Bold="true"></asp:Label>
                    </div>
                </div>
            </div>


            <div class="col-md-12">
                <div class="col-md-8">
                    <div class="col-md-12">
                        <asp:Label ID="lblPersonalInfo" runat="server" Text="Font type\background color\font color" CssClass="control-label panel panel-primary" Font-Size="20px" Font-Bold="true"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="col-md-12 panel-body">
                <br />
                <div class="col-md-4">
                    <asp:Label ID="lblFontType" runat="server" Text="Font Type"></asp:Label>
                    <asp:DropDownList ID="ddlFont" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="FontChange_OnSelect">
                        <asp:ListItem Value="Forte">Forte</asp:ListItem>
                        <asp:ListItem Value="Courier">Courier</asp:ListItem>
                        <asp:ListItem Value="Jokerman">Jokerman</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-md-4">
                    <asp:Label ID="lblBackground" runat="server" Text="Background color"></asp:Label>
                    <asp:DropDownList ID="ddlBackground" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="BackgroundChange_OnSelect">
                        <asp:ListItem Value="pink">Pink</asp:ListItem>
                        <asp:ListItem Value="blue">Blue</asp:ListItem>
                        <asp:ListItem Value="black">Black</asp:ListItem>
                        <asp:ListItem Value="white">White</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="col-md-4">
                    <asp:Label ID="lblFontColor" runat="server" Text="Font color"></asp:Label>
                    <asp:DropDownList ID="ddlFontColor" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="FontColorChange_OnSelect">
                        <asp:ListItem Value="Pink">Pink</asp:ListItem>
                        <asp:ListItem Value="Blue">Blue</asp:ListItem>
                        <asp:ListItem Value="Black">Black</asp:ListItem>
                        <asp:ListItem Value="White">White</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-md-12 panel-body">
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" CssClass="btn btn-success" />
                    <br />
                    <asp:Label ID="lblInfo" runat="server" Text="" CssClass=""></asp:Label>
                </div>

                <div class="col-md-12">
                    <asp:Label ID="lblThemeInfo" runat="server" Text="Or choose a theme" CssClass="panel-body" ForeColor="White"></asp:Label>
                </div>

                <div class="col-md-4">
                    <asp:Label ID="lblFullTheme" runat="server" Text="Themes"></asp:Label>
                    <asp:DropDownList ID="ddlFullTheme" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ThemeChange_OnSelect">
                        <asp:ListItem Value="Batman">Batman</asp:ListItem>
                        <asp:ListItem Value="Blue">Blue</asp:ListItem>
                        <asp:ListItem Value="Girlish">I love pink</asp:ListItem>
                        <asp:ListItem Value="Classic">Classic</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="col-md-12 panel-body">
                    <asp:Button ID="btnThemeSave" runat="server" Text="Save" CssClass="btn btn-success" OnClick="btnThemeSave_Click" />
                    <br />
                    <asp:Label ID="lblSelectedTheme" runat="server" Text="" CssClass=""></asp:Label>
                </div>

                <div class="col-md-12">
                    <div class="col-md-8">
                        <div class="col-md-12">
                            <asp:Label ID="lblLoginPref" runat="server" Text="Log in Preference" CssClass="control-label panel panel-primary" Font-Size="20px" Font-Bold="true"></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="col-md-12 panel-body">
                    <div class="col-md-4 row">
                        <asp:RadioButtonList ID="rblLoginPreference" runat="server">
                            <asp:ListItem Value="Auto">Auto Login</asp:ListItem>
                            <asp:ListItem Value="Fast">Fast Login</asp:ListItem>
                            <asp:ListItem Value="None">None</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                </div>
                <div class="col-md-12 panel-body">
                    <asp:Button ID="btnLoginPreference" runat="server" Text="Save" CssClass="btn btn-success" OnClick="btnLoginPreference_Click"  />
                    <br />
                    <asp:Label ID="lblLoginPreference" runat="server" Text="" CssClass=""></asp:Label>
                </div>

                <div class="col-md-12">
                    <div class="col-md-8">
                        <div class="col-md-12">
                            <asp:Label ID="lblPrivacySettings" runat="server" Text="Privacy Settings" CssClass="control-label panel panel-primary" Font-Size="20px" Font-Bold="true"></asp:Label>
                        </div>
                    </div>
                </div>

                <div class="col-md-4">
                    <asp:Label ID="lblChooseLevelOfPrivacy" runat="server" Text="Privacy Setting For Photos"></asp:Label>
                    <br />
                    <asp:DropDownList ID="ddlGlobalPhotoPrivacy" CssClass="form-control" runat="server">
                        <asp:ListItem Value="Public">Public</asp:ListItem>
                        <asp:ListItem Value="OnlyFriends">Friends</asp:ListItem>
                        <asp:ListItem Value="FrendsOfTheFriends">Friends and Friends of the Friends</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="col-md-4">
                    <asp:Label ID="lblProfileInfo" runat="server" Text="Privacy Setting For Profile Information"></asp:Label>
                    <asp:DropDownList ID="ddlProfileInformation" CssClass="form-control" runat="server">
                        <asp:ListItem Value="Public">Public</asp:ListItem>
                        <asp:ListItem Value="OnlyFriends">Friends</asp:ListItem>
                        <asp:ListItem Value="FrendsOfTheFriends">Friends and Friends of the Friends</asp:ListItem>
                    </asp:DropDownList>
                </div>


                <div class="col-md-4">
                    <asp:Label ID="lblPersonal" runat="server" Text="Privacy Setting For Contact Information"></asp:Label>
                    <asp:DropDownList ID="ddlContactInfo" CssClass="form-control" runat="server">
                        <asp:ListItem Value="Public">Public</asp:ListItem>
                        <asp:ListItem Value="OnlyFriends">Friends</asp:ListItem>
                        <asp:ListItem Value="FrendsOfTheFriends">Friends and Friends of the Friends</asp:ListItem>
                    </asp:DropDownList>
                </div>

                  <div class="col-md-12 panel-body">
                    <asp:Button ID="btnSavePrivacy" runat="server" Text="Save" CssClass="btn btn-success" OnClick="btnSavePrivacy_Click" />
                    <br />
                    <asp:Label ID="lblSavePrivasy" runat="server" Text="" CssClass=""></asp:Label>
                </div>

                <div class="col-md-12">
                    <asp:Label ID="lblGlobalprivacy" runat="server" Text="Or choose a global privacy settings" CssClass="panel-body"></asp:Label>
                </div>

                 <div class="col-md-4">
                    <asp:Label ID="lblGlobalPrivacySettings" runat="server" Text="Global Privacy Setting"></asp:Label>
                    <asp:DropDownList ID="ddlGlobalPrivacySettings" CssClass="form-control" runat="server">
                        <asp:ListItem Value="Public">Public</asp:ListItem>
                        <asp:ListItem Value="OnlyFriends">Friends</asp:ListItem>
                        <asp:ListItem Value="FrendsOfTheFriends">Friends and Friends of the Friends</asp:ListItem>
                    </asp:DropDownList>
                </div>

                  <div class="col-md-12 panel-body">
                    <asp:Button ID="btnGlobalSetting" runat="server" Text="Save" CssClass="btn btn-success" OnClick="btnGlobalSetting_Click" />
                    <br />
                    <asp:Label ID="lblGlobalSettingResult" runat="server" Text="" CssClass=""></asp:Label>
                </div>


                <div class="col-md-12 panel-body">
                    <asp:Label ID="lblSkip" runat="server" Text="Configure settings later" CssClass=""></asp:Label>
                    <br />
                    <asp:Button ID="btnSkip" runat="server" Text="Continue" CssClass="btn btn-primary" OnClick="btnSkip_Click" Width="192px" />
                </div>
            </div>

        </div>





    </form>
</body>
</html>
