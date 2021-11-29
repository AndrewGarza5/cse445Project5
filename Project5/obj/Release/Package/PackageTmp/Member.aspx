<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Project5.About" %>
<%@ Register TagPrefix = "cse" TagName="UserControl" src="UserControlObj.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="member-wrapper">
        <cse:UserControl runat="server" />

        <div class="header">
            <h3> <b>Elective Services - Music Information</b></h3>
            <h4>These 4 services give you information about artists using the Spotify API. <br /> 
                For ease of use, we give you 5 default artists to interact with:<br />
               <b>"Justin Bieber", "Kanye West", "Beyonce", "Shakira", and "Lil Nas X".</b>
            </h4>
            <a href="http://webstrar44.fulton.asu.edu/index.html" style="color: white;"> <b>CLICK HERE TO GO BACK TO THE INDEX PAGE</b></a>
        </div>

        <div class="ElectiveServices">

            <div class="ElectService1">
                 <div class="TopHalf">
                    <h4><b>Get All Songs From an Album</b></h4>
                    <h5>Select one of Kanye West's albums to view all of the tracks!</h5>
                    <asp:DropDownList ID="GetSongsDrop" runat="server">
                        <asp:ListItem Value="The Life of Pablo"></asp:ListItem>
                        <asp:ListItem Value="Donda"></asp:ListItem>
                        <asp:ListItem Value="Jesus is King"></asp:ListItem>
                        <asp:ListItem Value="Kids See Ghosts"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="GetSongsButton" runat="server" Text="Button" OnClick="GetSongsButton_Click"/>
                </div>
                <div class="BottomHalf">
                    <asp:Label ID="GetAllSongsLabel" runat="server" Text="Output:" Height="200px" Width="642px"></asp:Label>
                    
                </div>

            </div>

            <div class="ElectService2">
                <div class="TopHalf">
                    <h4><b>Get Audio Features of Artists Top Song</b></h4>
                    <h5>Select 1 of the 5 artists to get the audio features of their top song!</h5>

                     <asp:DropDownList ID="GetAudioFeaturesList" runat="server">
                        <asp:ListItem Value="Justin Bieber"></asp:ListItem>
                        <asp:ListItem Value="Kanye West"></asp:ListItem>
                        <asp:ListItem Value="Shakira"></asp:ListItem>
                        <asp:ListItem Value="Beyonce"></asp:ListItem>
                        <asp:ListItem Value="Lil Nas X"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="GetAudioFeaturesButton" runat="server" Text="Button" OnClick="GetAudioFeaturesButton_Click" />
                </div>
                <div class="BottomHalf">
                    <asp:Label ID="GetAudioFeaturesLabel" runat="server" Text="Output:" Height="200px"></asp:Label>
                </div>      

            </div>
        </div>
    </div>
            
</asp:Content>
