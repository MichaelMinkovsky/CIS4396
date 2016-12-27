<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProfileInfo.aspx.cs" Inherits="TermProject.frmProfileInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fondue</title>
    <link rel="shortcut icon" type="image/png" href="pics/Logo.jpg" />
    <script src="js/jquery-2.1.4.min.js"></script>
    <script src="js/bootstrap.js"></script>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/UserInfo.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">

        <div class="col-md-12">
            <div class="col-md-8">
                <div class="col-md-12">
                    <h1>
                        <asp:Label ID="lblTitle" runat="server" Text="Profile Info"></asp:Label>&nbsp;2</h1>
                </div>
                <div class="col-md-12">

                    <div class="col-md-12">
                        <button type="button" class="btn btn-success" data-toggle="modal" data-target="#myModal">
                            Add Jobs</button>
                    </div>
                    <div class="col-md-12">
                        <br />
                        <asp:Label ID="lblJobName" runat="server" Text="Jobs"></asp:Label>
                        <div class="panel panel-default"></div>
                    </div>

                    <div class="col-md-12 row">
                        <div class="col-md-5">
                            <button type="button" class="btn btn-success" data-toggle="modal" data-target="#School">
                                Add Education
                            </button>
                        </div>
                        <div class="col-md-5">
                            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <br />
                        <asp:Label ID="lblEducation" runat="server" Text="Education"></asp:Label>
                        <div class="panel panel-default"></div>
                    </div>

                    <div class="col-md-12">
                        <button type="button" class="btn btn-success" data-toggle="modal" data-target="#AboutME">
                            About MYSELF
                        </button>
                    </div>
                    <div class="col-md-12">
                        <br />
                        <asp:Label ID="lblAboutMe" runat="server" Text="About Me"></asp:Label>
                        <div class="panel panel-default"></div>
                    </div>

                    <div class="col-md-5 text-center">
                        <asp:FileUpload ID="fileUpload" runat="server" CssClass="form-control" Height="40px" ToolTip="Click to Upload Picture" />
                    </div>

                    <div class="col-md-4 col-md-pull-1">
                        <asp:Button ID="btnUploadPicture" runat="server" Text="Submit" OnClick="btnUpload_Click" CssClass="btn btn-primary" CausesValidation="False" />
                    </div>

                    <div class="col-md-12 panel-body">
                        <asp:Image ID="ImgPic" runat="server" ImageUrl="~/pics/blank_picture.jpg" Width="200px" Height="250px" />
                    </div>

                </div>
            </div>

            <div class="col-md-4 text-center divBackground">
                <asp:Button ID="btnHomePage" runat="server" Text="Home Page"
                    CssClass="btn btn-primary" Style="position: fixed; top: 50%; transform: translate(-50%, -50%)" OnClick="btnHomePage_Click" CausesValidation="False" />
            </div>
        </div>





        <%-- Modal  for Job--%>
        <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="myModalLabel">Add Job</h4>
                    </div>
                    <div class="modal-body">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtBusName" runat="server" ErrorMessage="*Required Field" ForeColor="Red" ValidationGroup="Job"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtBusName" runat="server" placeholder="Company Name" CssClass="form-control" Width="430px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtPosition" runat="server" ErrorMessage="*Required Field" ForeColor="Red" ValidationGroup="Job"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtPosition" runat="server" placeholder="Position" CssClass="form-control" Width="430px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtCity" runat="server" ErrorMessage="*Required Field" ForeColor="Red" ValidationGroup="Job"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtCity" runat="server" placeholder="City" CssClass="form-control" Width="430px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtDescription" runat="server" ErrorMessage="*Required Field" ForeColor="Red" ValidationGroup="Job"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtDescription" runat="server" placeholder="Description" Style="resize: none" CssClass="form-control" TextMode="MultiLine" Width="458px" Height="200px"></asp:TextBox>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="btnSubmit" class="btn btn-primary" runat="server" Text="Submit" OnClick="btnSubmit_Click" ValidationGroup="Job" />
                    </div>
                </div>
            </div>
        </div>

        <%-- Modal for Education--%>
        <div class="modal fade" id="School" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="H1">Add Education</h4>
                    </div>
                    <div class="modal-body">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtSchoolName" runat="server" ErrorMessage="*Required Field" ForeColor="Red" ValidationGroup="Education"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtSchoolName" runat="server" placeholder="School Name" CssClass="form-control" Width="430px"></asp:TextBox>

                        <div class="form col-md-12 row">
                            <div class="form-group col-md-6 row">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="txtTimeStart" runat="server" Type="Date" ErrorMessage="*Required Field" ForeColor="Red" OnServerValidate="valStart_ServerValidate" ValidationGroup="Education"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="txtTimeStart" runat="server" placeholder="Start Time ex:05/12/2016" CssClass="form-control" TextMode="Date" Width="185px"></asp:TextBox>
                            </div>
                            <div class="form-group col-md-5">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ControlToValidate="txtTimeEnd" runat="server" ErrorMessage="*Required Field" ForeColor="Red" OnServerValidate="valEnd_ServerValidate" ValidationGroup="Education"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="txtTimeEnd" runat="server" placeholder="End Time ex:05/12/2016" CssClass="form-control" TextMode="Date" Width="180px"></asp:TextBox>
                            </div>
                        </div>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="txtSchoolDescription" runat="server" ErrorMessage="*Required Field" ForeColor="Red" ValidationGroup="Education"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtSchoolDescription" runat="server" placeholder="School Description" Style="resize: none" CssClass="form-control" TextMode="MultiLine" Width="458px" Height="200px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="txtMajor" runat="server" ErrorMessage="*Required Field" ForeColor="Red" ValidationGroup="Education"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtMajor" runat="server" placeholder="Major" CssClass="form-control" Width="430px"></asp:TextBox>

                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="SchoolSubmit" class="btn btn-primary" runat="server" Text="Submit" OnClick="btnSchoolSubmit_Click" ValidationGroup="Education" />
                    </div>
                </div>
            </div>
        </div>

        <%-- Modal for About Me--%>
        <div class="modal fade" id="AboutME" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="H2">Add Job</h4>
                    </div>
                    <div class="modal-body">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" ControlToValidate="txtAboutME" runat="server" ErrorMessage="*Required Field" ForeColor="Red" ValidationGroup="AboutMe"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtAboutME" runat="server" placeholder="About Me" CssClass="form-control" TextMode="MultiLine" Width="458px" Height="200px" Style="resize: none"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" ControlToValidate="txtFavoriteQuotes" runat="server" ErrorMessage="*Required Field" ForeColor="Red" ValidationGroup="AboutMe"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtFavoriteQuotes" runat="server" placeholder="Favorite Qoutes" CssClass="form-control" TextMode="MultiLine" Width="458px" Height="200px" Style="resize: none"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" ControlToValidate="txtHobbies" runat="server" ErrorMessage="*Required Field" ForeColor="Red" ValidationGroup="AboutMe"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtHobbies" runat="server" placeholder="Enter your Hobbies" CssClass="form-control" TextMode="MultiLine" Width="458px" Height="200px" Style="resize: none"></asp:TextBox>

                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="btnAboutMe" class="btn btn-primary" runat="server" Text="Submit" OnClick="btnAboutSubmit_Click" CausesValidation="true" ValidationGroup="AboutMe" />
                    </div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>



