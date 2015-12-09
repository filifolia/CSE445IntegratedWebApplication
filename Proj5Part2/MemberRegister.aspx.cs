using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Xml;
using HashingDLL;
using Proj5Part2.ServiceReference1;

namespace Proj5Part2
{
    public partial class MemberRegister : System.Web.UI.Page
    {
        String verifyString;
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceClient client = new ServiceClient();
            verifyString = client.GetVerifierString("5");
            String customUrl = "http://venus.eas.asu.edu/WSRepository/Services/ImageVerifier/Service.svc/GetImage/" + verifyString;
            verify.ImageUrl = customUrl;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Label1.Text = "";
            if (this.TextBox4.Text == verifyString)
            {
                if (this.TextBox1.Text != "" && this.TextBox2.Text != "" && this.TextBox3.Text != "")
                {
                    String username = this.TextBox1.Text;
                    String password = this.TextBox2.Text;
                    String confirm = this.TextBox3.Text;
                    String passEncrypt = EncryptDecrypt.encryptString(password, "pass");
                    if (password.Equals(confirm))
                    {
                        string output = "";
                        XElement root = XElement.Load(Server.MapPath("Members.xml"));
                        IEnumerable<XElement> idList =
                            from el in root.Elements("ID")
                            where (string)el.Element("Username") == username
                            select el;
                        foreach (XElement el in idList)
                        { //Outputs all elements in the found node
                            output = output + el + "\r\n";
                        }
                        if (output == "") //If the node isn't found
                        {
                            XDocument doc = XDocument.Load(Server.MapPath("Members.xml"));
                            XElement root2 = new XElement("ID");
                            root2.Add(new XElement("Username", username));
                            root2.Add(new XElement("Password", passEncrypt));
                            doc.Element("IDs").Add(root2);
                            doc.Save(Server.MapPath("Members.xml"));
                            this.Label1.Text = "Account created, please return to homepage and login from there.";
                        }
                        else
                        {
                            this.Label1.Text = "The account already exist!";
                        }
                    }
                    else
                    {
                        this.Label1.Text = "The password you entered didn't match the confirmed password.";
                    }
                }
                else
                {
                    this.Label1.Text = "One of the fields are empty.";
                }
            }
            else
            {
                Label1.Text = "Image verification is incorrect";
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Default.aspx");
        }
    }
}