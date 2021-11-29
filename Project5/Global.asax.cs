using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Project5
{
    public class Global : HttpApplication
    {
        /// <summary>
        /// Checks user cookies to see if they are signed in to any accounts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Session_Start(object sender, EventArgs e)
        {
            HttpCookie cookies = Request.Cookies["StaffLoginCookies"];
            if ((cookies == null) || (cookies["StaffUsername"] == ""))
            {
                System.Diagnostics.Debug.WriteLine("Tdow");
                // Display the fact that the user is signed in as staff, member, or both at top right navbar

                // CAN I USE A USER CONTROL FOR THIS????
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("ll be displayed in output window");
                // Display "You are not signed in as a member or staff"
            }
        }
    }
}