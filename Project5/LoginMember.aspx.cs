using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Project5
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MemberLoginSubmitButton_Click(object sender, EventArgs e)
        {
            if (CheckIfMemberExists(MemberLoginUsernameTextBox.Text, MemberLoginPasswordTextBox.Text))
            {
                HttpCookie myCookies = new HttpCookie("MemberLoginCookies");
                myCookies["MemberUsername"] = MemberLoginUsernameTextBox.Text;
                myCookies["MemberPassword"] = MemberLoginPasswordTextBox.Text;
                myCookies.Expires = DateTime.Now.AddMinutes(3);
                Response.Cookies.Add(myCookies);

                Response.Redirect("Member.aspx");
            }
            else
            {
                MemberLoginErrorMessage.Text = "This username or password does not exist.";
            }
        }

        protected bool CheckIfMemberExists(string username, string password)
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            FileStream file = new FileStream(@"../XML/Member.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(file);
            xmlnode = xmldoc.GetElementsByTagName("Member");
            for (int i = 0; i < xmlnode.Count; i++)
            {

                string compareUsername = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                string comparePassword = xmlnode[i].ChildNodes.Item(1).InnerText.Trim();

                if (username == compareUsername)
                {
                    if (password == comparePassword)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}