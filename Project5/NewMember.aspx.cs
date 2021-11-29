using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using PassEncrypt;

namespace Project5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MemberSignupSubmitButton_Click(object sender, EventArgs e)
        {
            string username = MemberSignupUsernameTextBox.Text;
            string password = MemberSignupPasswordTextBox.Text;

            if (username.Length < 2)
            {
                MemberSignupErrorMessage.Text = "Error, username has to be at least 1 character long!";
                return;
            }
            else if (password.Length < 4)
            {
                MemberSignupErrorMessage.Text = "Error, password has to be at least 4 character long!";
                return;
            }

            CreateNewMember(username, password);

            HttpCookie myCookies = new HttpCookie("MemberLoginCookies");
            myCookies["MemberUsername"] =username;
            myCookies["MemberPassword"] = password;
            myCookies.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Add(myCookies);

            Response.Redirect("Member.aspx");
        }
        protected void CreateNewMember(string username, string password)
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            XDocument xDocument = XDocument.Load("XML/Member.xml");
            XElement root = xDocument.Element("Root");
            IEnumerable<XElement> rows = root.Descendants("Member");

            //encrypt the password before adding to the xml document 
            string newPass = encrypt.encryptPass(password);
            string newUsername = encrypt.encryptPass(username);
            XElement firstRow = rows.First();
            firstRow.AddBeforeSelf(
               new XElement("Member",
               new XElement("Username", newUsername),
               new XElement("Password", newPass)));
            xDocument.Save("XML/Member.xml");
        }

    }
}
