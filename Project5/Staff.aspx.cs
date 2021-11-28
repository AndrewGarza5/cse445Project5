using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace Project5
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitStaff_Click(object sender, EventArgs e)
        {

            /*//create xml file if there isnt one
            if (!File.Exists("Staff.xml"))
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;
                using (XmlWriter xmlWriter = XmlWriter.Create("Staff.xml", xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Staffs");

                    xmlWriter.WriteStartElement("Staff");
                    xmlWriter.WriteElementString("Username", staffUser.Text);
                    xmlWriter.WriteElementString("Password", staffPass.Text);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }
            //append to the existing xml file
            else
            {
                XDocument xDocument = XDocument.Load("Staff.xml");
                XElement root = xDocument.Element("Staffs");
                IEnumerable<XElement> rows = root.Descendants("Staff");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("Staff",
                   new XElement("Username", staffUser.Text),
                   new XElement("Password", PassUser.Text)));
                xDocument.Save("Staff.xml");
            }*/
        }
    }
}
