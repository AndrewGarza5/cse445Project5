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
        void Session_Start(object sender, EventArgs e)
        {

            MessageBox.Show("Have good day. This is the global event.", "Hello from team 44!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}