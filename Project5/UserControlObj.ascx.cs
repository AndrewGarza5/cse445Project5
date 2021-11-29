using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5
{
    public partial class UserControlObj : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookies = Request.Cookies["MemberLoginCookies"];
            if ((cookies == null) || (cookies["MemberUsername"] == ""))
            {
                UserControlMember.Text = "Currently not signed in as a member.";
            }
            else
            {
                UserControlMember.Text = "Welcome, member " + cookies["MemberUserName"] + "! Have a great day!";
            }

            cookies = Request.Cookies["StaffLoginCookies"];
            if ((cookies == null) || (cookies["StaffUsername"] == ""))
            {
                UserControlStaff.Text = "Currently not signed in as staff.";
            }
            else
            {
                UserControlStaff.Text = "Welcome, staff " + cookies["StaffUserName"] + "! Have a great day!";
            }
        }
    }
}