using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Windows.Forms;

namespace Project5
{
    public class Global : HttpApplication
    {
        /// <summary>
        /// Checks user cookies to see if they are signed in to any accounts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Session_End(object sender, EventArgs e)
        {
            HttpCookie cookiesStaff = Request.Cookies["StaffLoginCookies"];
            cookiesStaff["StaffUsername"] = "";
            cookiesStaff["StaffPassword"] = "";

            HttpCookie cookiesMember = Request.Cookies["MemberLoginCookies"];
            cookiesMember["MemberUsername"] = "";
            cookiesMember["MemberPassword"] = "";
        }
    }
}