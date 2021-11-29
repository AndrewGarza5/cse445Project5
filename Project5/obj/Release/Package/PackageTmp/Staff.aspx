<%@ Page Title="Staff page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Project5.Contact" %>
<%@ Register TagPrefix = "cse" TagName="UserControl" src="UserControlObj.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="home-wrapper">
        <cse:UserControl runat="server" />
        <div class="home-description">
            <p style="font-size: 40px;">Hello staff!</p>
            <p style="font-size: 17px;">
                This staff page is only accessible to staff members.
                <br />
                <br />
                If you would like to add new staff members, enter their information below.
                <br />
                <br />
            </p>
            
            <p>New username:</p>
            <asp:TextBox ID="NewStaffUsernameTextBox" runat="server"></asp:TextBox>

            <p>New password:</p>
            <asp:TextBox ID="NewStaffPasswordBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="NewStaffButton" runat="server" Text="Confirm" OnClick="NewStaffButton_Click" />
            <asp:Label ID="StaffSignupErrorMessage" runat="server" BorderStyle="None" BorderWidth="0px" Font-Size="20px" ForeColor="Red" Width="251px"></asp:Label>
        </div>
        </div>
    </div>
        

</asp:Content>
