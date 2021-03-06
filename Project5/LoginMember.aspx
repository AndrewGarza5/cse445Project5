<%@ Page Title="Member login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginMember.aspx.cs" Inherits="Project5.WebForm3" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="invisible-space"></div>
        <div class="member-login-box">
            <div class="login-words">
                <p style="font-size: 40px">Hello, member! Log in!</p>
            </div>
            <div class="login-username-area">
                <p>Username:</p>
                <asp:TextBox ID="MemberLoginUsernameTextBox" class="login-input-boxes" runat="server"></asp:TextBox>
            </div>
            <div class="login-password-area">
                <p>Password:</p>
                <asp:TextBox ID="MemberLoginPasswordTextBox" class="login-input-boxes" runat="server"></asp:TextBox>
            </div>
            <div class="login-submit-area">
                 <asp:Button ID="MemberLoginSubmitButton" class="login-submit-button" runat="server" Text="Submit" OnClick="MemberLoginSubmitButton_Click" />
            </div>
            <div class="no-account">
                <a href="NewMember.aspx">Don't have an account? Create one here!</a>
            </div>
            <asp:Label ID="MemberLoginErrorMessage" runat="server" BorderStyle="None" BorderWidth="0px" Font-Size="20px" ForeColor="Red" Width="251px"></asp:Label>
        </div>


</asp:Content>


