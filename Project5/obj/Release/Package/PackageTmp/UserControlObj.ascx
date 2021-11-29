<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlObj.ascx.cs" Inherits="Project5.UserControlObj" %>
<link rel='stylesheet' href='~/content/Site.css'>

<div style="    position: relative;
    padding-top: 25px;
    margin: auto;
    width: 600px;
    height:150px;
    border-bottom: 1px solid black;
    text-align: center;
    font-size: 20px;">
    <asp:Label ID="UserControlMember" runat="server" 
    Text=""></asp:Label>
    <br /><br />
    <asp:Label ID="UserControlStaff" runat="server" 
    Text=""></asp:Label>
</div>
