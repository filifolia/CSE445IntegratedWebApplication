using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using HashingDLL;
using System.Data.SqlClient;
using System.Web.Security;

namespace Proj5Part2
{
    public partial class StaffLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        //Authentication method
        protected bool myAuthentication(String username, String password)
        {
            string fLocation = Path.Combine(Request.PhysicalApplicationPath, "Staffs.xml");
            if (File.Exists(fLocation))
            {
                FileStream FS = new FileStream(fLocation, FileMode.Open);
                XmlDocument xd = new XmlDocument();
                xd.Load(FS);
                //XmlNode node = xd;
                XmlNodeList children = xd.SelectNodes("/IDs/ID");
                foreach (XmlNode child in children)
                {
                    string xmlUsername = child["Username"].InnerText;
                    string xmlPassword = child["Password"].InnerText;
                    xmlPassword = EncryptDecrypt.decryptString(xmlPassword, "pass");
                    if (username == xmlUsername && password == xmlPassword)
                    {
                        return true;
                    }
                }
                this.Label2.Text = "Node not found!";
                return false;
            }
            this.Label2.Text = "FILE NOT FOUND;";
            return false;
        }

        protected void LoginFunc(Object sender, EventArgs e)
        {
            if (myAuthentication(TextBox1.Text, TextBox2.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, RememberMe.Checked);
                Response.Redirect("Staffs/Staff.aspx");
            }
            else
            {
                Label1.Text = "Invalid login";
            }
        }
    }
}