<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PictureControl.ascx.cs" Inherits="TermProject.PictureControl" %>


<div class="col-md-1">
    <div class="col-md-12 row">
<asp:Image ID="ImgControl" runat="server" Height="142px" Width="162px" CssClass="col-md-1"/>&nbsp&nbsp
        <asp:HiddenField ID="HF" runat="server"  />
        </div>
    <div class="col-md-6 ">
<asp:Button ID="Select" runat="server" Text="Select" CssClass="btn btn-success" OnClick="Select_Click"/> &nbsp&nbsp
        </div>
    <div class="col-md-6 ">
<asp:Button ID="Delete" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="Delete_Click"/>
    </div>
    </div>
