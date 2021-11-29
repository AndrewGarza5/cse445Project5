using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void NavbarHomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void NavbarMemberButton_Click(object sender, EventArgs e)
        {
            HttpCookie cookies = Request.Cookies["MemberLoginCookies"];
            if ((cookies == null) || (cookies["MemberUsername"] == ""))
            {
                Response.Redirect("LoginMember.aspx");
            }
            else
            {
                Response.Redirect("Member.aspx");
            }
        }

        protected void NavbarStaffButton_Click(object sender, EventArgs e)
        {
            HttpCookie cookies = Request.Cookies["StaffLoginCookies"];
            if((cookies == null) || (cookies["StaffUsername"] == ""))
            {
                Response.Redirect("LoginStaff.aspx");
            }
            else
            {
                Response.Redirect("Staff.aspx");
            }
            
        }

    }
}