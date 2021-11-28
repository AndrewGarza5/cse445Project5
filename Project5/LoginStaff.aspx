<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginStaff.aspx.cs" Inherits="Project5.WebForm1" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="invisible-space"></div>
        <div class="login-box">
            <div class="login-words">
                <p style="font-size: 50px">Hello, staff! Log in!</p>
            </div>
            <div class="login-username-area">
                <p>Username:</p>
                <asp:TextBox ID="StaffLoginUsernameTextBox" class="login-input-boxes" runat="server"></asp:TextBox>
            </div>
            <div class="login-password-area">
                <p>Password:</p>
                <asp:TextBox ID="StaffLoginPasswordTextBox" class="login-input-boxes" runat="server"></asp:TextBox>
            </div>
            <div class="login-submit-area">
                 <asp:Button ID="StaffLoginSubmitButton" class="login-submit-button" runat="server" Text="Submit" />
            </div>
        </div>


</asp:Content>


