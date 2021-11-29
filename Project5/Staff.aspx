<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Project5.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

      <div class="home-wrapper" style="left: 0px; top: 0px; width: 832px; height: 557px">
        <div class="staff-description">
            <p style="font-size: 30px;">Welcome Staff Member!</p>
        </div>
          <asp:Label ID="Label1" runat="server" style="z-index: 1; position: absolute; top: 314px; left: 24px" Text="Staff Username"></asp:Label>
          <asp:Label ID="Label2" runat="server" style="z-index: 1; position: absolute; top: 368px; left: 21px" Text="Staff Password"></asp:Label>
          <asp:Button ID="SubmitStaff" runat="server" OnClick="SubmitStaff_Click" style="z-index: 1; position: absolute; top: 424px; left: 101px" Text="Add Staff" />
          <asp:TextBox ID="staffUser" runat="server" style="z-index: 1; position: absolute; top: 314px; left: 156px; width: 159px; margin-top: 0;"></asp:TextBox>
          <asp:TextBox ID="StaffPass" runat="server" style="z-index: 1; position: absolute; top: 368px; left: 152px; width: 162px"></asp:TextBox>

          <asp:Label ID="Label3" runat="server" style="z-index: 1; position: absolute; top: 41px; left: 13px; width: 511px; height: 27px" Text="This page is to add new staff members and to see those who are already added"></asp:Label>
               </div>
    <html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="form1" runat="server">
    <div>
    </div>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" 
        DataFile="https://www.public.asu.edu/~rmschnab/Staffs.xml" 
        XPath="/WWW/*"></asp:XmlDataSource>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="XmlDataSource1">
    </asp:GridView>
   <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1">
    </asp:TreeView>
    </form>
</body>
</html>

</asp:Content>


