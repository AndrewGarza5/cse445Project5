<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project5._Default" %>
<%@ Register TagPrefix = "cse" TagName="UserControl" src="UserControlObj.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="home-wrapper">
        <cse:UserControl runat="server" />
        <div class="home-description">
            <p style="font-size: 40px;">Welcome!</p>
            <p style="font-size: 17px;">This is our project 5, and here are the details:
                <br /><br />
                <b> GUI Layer </b>
                <br />
                We have the home page, members page, and staff page.
                <br />
                - The home page serves as a navigation page to move around. Click the buttons below or on the navbar to get around.
                <br />
                - The member page houses our services for any members to use
                <br />
                - The staff page is exclusive to staff members and allows them to *************
                <br />


                Before going to staff and member pages, you must sign in as a staff or member.
                <br /><br />

                <b>Local Component Layer</b>
                <br />
                - Global.asax component
                <br />
                - DLL class library component
                <br />
                - Cookie AND SESSION STATE component: Cookies are used to keep you logged in as you navigate all pages. Cookies have a lifespan of 3 minutes before they are
                deleted.
                <br />
                - User control component: The 2 lines at the top saying whether or not you are logged in is a user control component. It
                will always display who you are signed in as (or not signed in) across all pages consistently.
                <br />
                The code for this can be found in the UserControlObj.ascx and UserControlObj.ascx.cs file.
                <br />
                - XML file manipulation component: The login and sign up perform XML manipulation. Everytime you sign up, it encrypts the user information 
                and adds it to the XML file. The login also scans through the XML file for your given credentials.
                <br /><br />

                <b>Remote Service Layer</b>
                <br />
                We used services from project 3.
                <br />
                These services use the Spotify API to get information about specific artists and more. 
                <br />
                - Service 1: You can get all the albums for a given artist
                <br />
                - Service 2: You can get the audio featurs of a given artists top song
                <br />
            </p>
        </div>
        <asp:Button ID="ToMemberButton" class="member-button-area" runat="server" Text="Go to Member Page!" OnClick="ToMemberButton_Click" />
        <asp:Button ID="ToStaffButton" class="staff-button-area" runat="server" Text="Go to Staff Page!" />

    </div>

</asp:Content>
