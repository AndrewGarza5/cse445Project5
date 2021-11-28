<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project5.WebForm1" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="invisible-space"></div>
        <div class="login-box">
            <div class="login-words">
                Log in!
            </div>
            <div class="login-username-area">
                <p>Username:</p>
                <asp:TextBox ID="UsernameTextBox" class="login-input-boxes" runat="server"></asp:TextBox>
            </div>
            <div class="login-password-area">
                <p>Password:</p>
                <asp:TextBox ID="PasswordTextBox" class="login-input-boxes" runat="server"></asp:TextBox>
            </div>
            <div class="login-submit-area">
                 <asp:Button ID="LoginSubmitButton" class="login-submit-button" runat="server" Text="Submit" />
            </div>
        </div>


</asp:Content>


