using PassEncrypt;
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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StaffLoginSubmitButton_Click(object sender, EventArgs e)
        {
            if(CheckIfStaffExists(StaffLoginUsernameTextBox.Text, StaffLoginPasswordTextBox.Text)){
                HttpCookie myCookies = new HttpCookie("StaffLoginCookies");
                myCookies["StaffUsername"] = StaffLoginUsernameTextBox.Text;
                myCookies["StaffPassword"] = StaffLoginPasswordTextBox.Text;
                Response.Cookies.Add(myCookies);

                Response.Redirect("Staff.aspx");
            }
            else
            {
                StaffLoginErrorMessage.Text = "This username or password does not exist.";
            }
        }

        protected bool CheckIfStaffExists(string username, string password)
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            FileStream file = new FileStream(@"XML/Staff.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(file);
            xmlnode = xmldoc.GetElementsByTagName("Staff");
            for (int i = 0; i < xmlnode.Count; i++)
            {

                string compareUsername = decrypt.decryptPass(xmlnode[i].ChildNodes.Item(0).InnerText.Trim());
                string comparePassword = decrypt.decryptPass(xmlnode[i].ChildNodes.Item(1).InnerText.Trim());

                if(username == compareUsername)
                {
                    if(password == comparePassword)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}