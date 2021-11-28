<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Project5.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

      <div class="home-wrapper" style="left: 0px; top: 0px; width: 832px; height: 557px">
        <div class="staff-description">
            <p style="font-size: 30px;">Enter staff Information below:</p>
        </div>
          <asp:Label ID="Label1" runat="server" style="z-index: 1; position: absolute; top: 65px; left: 63px" Text="Staff Username"></asp:Label>
          <asp:Label ID="Label2" runat="server" style="z-index: 1; position: absolute; top: 132px; left: 68px" Text="Staff Password"></asp:Label>
          <asp:Button ID="SubmitStaff" runat="server" OnClick="SubmitStaff_Click" style="z-index: 1; position: absolute; top: 194px; left: 154px" Text="Submit" />
          <asp:TextBox ID="staffUser" runat="server" style="z-index: 1; position: absolute; top: 65px; left: 203px; width: 159px"></asp:TextBox>
          <asp:TextBox ID="StaffPass" runat="server" style="z-index: 1; position: absolute; top: 130px; left: 207px; width: 152px"></asp:TextBox>

    </div>

</asp:Content>

