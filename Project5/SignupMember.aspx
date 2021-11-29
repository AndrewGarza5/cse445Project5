﻿<%@ Page Title="Member sign up Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignupMember.aspx.cs" Inherits="Project5.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="invisible-space"></div>
        <div class="login-box">
            <div class="login-words">
                <p style="font-size: 40px">Hello, Member! Sign Up!</p>
                
            </div>
            <div class="login-username-area">
                <p>Username:</p>
                <asp:TextBox ID="MemberSignupUsernameTextBox" class="login-input-boxes" runat="server"></asp:TextBox>
            </div>
            <div class="login-password-area">
                <p>Password: <i>must be more than 4 characters long</i></p>
                <asp:TextBox ID="MemberSignupPasswordTextBox" class="login-input-boxes" runat="server"></asp:TextBox>
            </div>
            <div class="login-submit-area">
                 <asp:Button ID="MemberSignupSubmitButton" class="login-submit-button" runat="server" Text="create account" />
            </div>
        </div>


</asp:Content>


