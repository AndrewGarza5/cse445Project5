using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Project5
{
    public partial class WebForm4 : System.Web.UI.Page
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
        }

        protected void CreateNewMember(string username, string password)
        {
            XDocument xDocument = XDocument.Load("../../../Member.xml");
            XElement root = xDocument.Element("Root");
            IEnumerable<XElement> rows = root.Descendants("Member");
            XElement firstRow = rows.First();
            firstRow.AddBeforeSelf(
               new XElement("Member",
               new XElement("Username", username),
               new XElement("Password", password)));
            xDocument.Save("../../../Member.xml");
        }
    }
}