using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Xml;
using HashingDLL;
using System.Data.SqlClient;
using System.Web.Security;
using Proj5Part2.ServiceReference1;

namespace Proj5Part2
{
    public partial class MemberLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myCookieId"];
            if ((myCookies == null) || (myCookies["Name"] == ""))
            {
                lblText.Text = "Welcome, new user";
            }
            else
            {
                lblText.Text = "Welcome, " + myCookies["Name"];
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (RememberMe.Checked == true)
            {
                HttpCookie myCookies = new HttpCookie("myCookieId");
                myCookies["Name"] = TextBox1.Text;
                myCookies.Expires = DateTime.Now.AddMonths(1);
                Response.Cookies.Add(myCookies);
                lblText.Text = "Welcome, " + myCookies["Name"];
            }

        }
        
        protected bool myAuthentication(String username, String password)
        {
            String TestPassword = EncryptDecrypt.encryptString(password, "pass");
            string fLocation = Path.Combine(Request.PhysicalApplicationPath, "Members.xml");
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
                    
                    if (username == xmlUsername && TestPassword == xmlPassword)
                    {
                        return true;
                    }
                }
                this.Label1.Text = "Node not found!";
                return false;
                FS.Close();
            }
            this.Label1.Text = "FILE NOT FOUND";
            return false;
        }

        protected void LoginFunc(Object sender, EventArgs e)
        {       
                if (RememberMe.Checked == true)
                {
                    HttpCookie myCookies = new HttpCookie("myCookieId");
                    myCookies["Name"] = TextBox1.Text;
                    myCookies.Expires = DateTime.Now.AddMonths(1);
                    Response.Cookies.Add(myCookies);
                    lblText.Text = "Welcome, " + myCookies["Name"];
                }
                if (myAuthentication(this.TextBox1.Text, this.TextBox2.Text))
                {
                    //FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, RememberMe.Checked);
                    Response.Redirect("Member/Member.aspx");
                }
                else
                {
                    Label1.Text = "Invalid login";
                }           
        }
    }
}