<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project5._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="home-wrapper">
        <div class="home-description">
            <p style="font-size: 40px;">Welcome!</p>
            <p style="font-size: 20px;">sdkjfhd skjdsdfssasdfdasahf daskjfh dsakg dslak;gj adslk;gj asdkl;gh adskjgh ASU websites use cookies to enhance user experience, analyze site usage, and assist with outreach and enrollment. By continuing to use this site, you are giving us your consent to do this. Learn more about cookies on ASU websites in our Privacy Statement. </p>
        </div>
        <asp:Button ID="ToMemberButton" class="member-button-area" runat="server" Text="Go to Member Page!" />
        <asp:Button ID="ToStaffButton" class="staff-button-area" runat="server" Text="Go to Staff Page!" />

    </div>

</asp:Content>
