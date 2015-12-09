using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proj5Part1.ServiceReference1;
//using HashingDLL;
using System.Xml;
using System.Xml.Linq;

namespace Proj5Part1
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            TimeControl.Controls.Add(LoadControl("TimeNow.ascx"));

            loadCookies();
        }

        protected void loadCookies()
        {
            //TODO: if cookies already exist, fill in the respective forms 
            HttpCookie _c;

            for (int i = 0; i < Request.Cookies.Count; i++)
            {
                _c = Request.Cookies[i];

                if (String.Compare(_c.Name, "wordFilter_input", false) == 0)
                {
                    if (_c.Value.Length > 0)
                    {
                        TextBox1.Text = _c.Value;
                    }
                    else { TextBox1.Text = ""; }
                }
                else if (String.Compare(_c.Name, "encrypt_input", false) == 0)
                {
                    if (_c.Value.Length > 0)
                    {
                        TextBox2.Text = _c.Value;
                    }
                    else { TextBox2.Text = ""; }
                }
                else if (String.Compare(_c.Name, "decrypt_input", false) == 0)
                {
                    if (_c.Value.Length > 0)
                    {
                        TextBox3.Text = _c.Value;
                    }
                    else { TextBox3.Text = ""; }
                }
                else if (String.Compare(_c.Name, "user_search", false) == 0)
                {
                    if (_c.Value.Length > 0)
                    {
                        TextBox6.Text = _c.Value;
                    }
                    else { TextBox6.Text = ""; }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
            string output = client.WordFilter(this.TextBox1.Text);
            this.Label1.Text = output;
            //new stuff
            Response.Cookies["wordFilter_input"].Value = output;
            Response.Cookies["wordFilter_input"].Expires = DateTime.Now.AddDays(1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Label2.Text = "The number of visits: " + Global.countNum;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int yo;
            string ye = "hi";
            int[] de4 = {1,2};
            for (int i = 0; i < 6; i = i + 3)
            {
                yo = de4[i];
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string temp = "";
            //TODO: uncomment
            //temp = EncryptDecrypt.encryptString(this.TextBox2.Text, "pass").ToString();
            //if (temp.Length < 1)
              //  { return; }
            this.Label3.Text = temp;
            Response.Cookies["encrypt_input"].Value = TextBox2.Text;
            Response.Cookies["encrypt_input"].Expires = DateTime.Now.AddDays(1);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string temp = "";
            //TODO: uncomment
            //temp = EncryptDecrypt.decryptString(this.TextBox3.Text, "pass").ToString();
            this.Label4.Text = temp;
            Response.Cookies["decrypt_input"].Value = TextBox3.Text;
            Response.Cookies["decrypt_input"].Expires = DateTime.Now.AddDays(1);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string output = "";
            XElement root = XElement.Load(Server.MapPath("Members.xml"));
            IEnumerable<XElement> idList =
                from el in root.Elements("ID")
                where (string)el.Element("Username") == this.TextBox6.Text
                select el;
            foreach (XElement el in idList)
            { //Outputs all elements in the found node
                output = output + el + "\r\n";
            }
            if (output == "") //If the node isn't found
            {
                XDocument doc = XDocument.Load(Server.MapPath("Members.xml"));
                XElement root2 = new XElement("ID");
                root2.Add(new XElement("Username", this.TextBox4.Text));
                root2.Add(new XElement("Password", this.TextBox5.Text));
                doc.Element("IDs").Add(root2);
                doc.Save(Server.MapPath("Members.xml"));
                this.Label5.Text = "Account added";
            }
            else
            {
                this.Label5.Text = "The account already exists";
            }
            
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            //Determines if an account already exists or not
            string output = "";
            XElement root = XElement.Load(Server.MapPath("Members.xml"));
            IEnumerable<XElement> idList =
                from el in root.Elements("ID")
                where (string)el.Element("Username") == this.TextBox6.Text
                select el;
            foreach (XElement el in idList)
            { //Outputs all elements in the found node
                output = output + el + "\r\n";
            }
            if (output == "") //If the node isn't found
            {
                this.Label6.Text = "The account does not exist";
            }
            else
            {
                this.Label6.Text = "The account already exists";
            }
            //TODO: touch up
            Response.Cookies["user_search"].Value = TextBox6.Text;
            Response.Cookies["user_search"].Expires = DateTime.Now.AddDays(1);
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            loadCookies();
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Cookies["sample_cookie"].Value = "";
            Response.Cookies["sample_cookie"].Expires = DateTime.Now.AddDays(-1);
        }

        //clears all the saved cookie values
        protected void Button12_Click(object sender, EventArgs e)
        {
            //TODO: if cookies exist, clear the respective values
            HttpCookie _c;

            for (int i = 0; i < Request.Cookies.Count; i++)
            {
                _c = Request.Cookies[i];

                if (String.Compare(_c.Name, "wordFilter_input", false) == 0)
                {
                    _c.Value = "";
                    Response.Cookies["wordFilter_input"].Expires = DateTime.Now.AddDays(-1);
                }
                else if (String.Compare(_c.Name, "encrypt_input", false) == 0)
                {
                    _c.Value = "";
                    Response.Cookies["encrypt_input"].Expires = DateTime.Now.AddDays(-1);
                }
                else if (String.Compare(_c.Name, "decrypt_input", false) == 0)
                {
                    _c.Value = "";
                    Response.Cookies["decrypt_input"].Expires = DateTime.Now.AddDays(-1);
                }
                else if (String.Compare(_c.Name, "user_search", false) == 0)
                {
                    _c.Value = "";
                    Response.Cookies["user_search"].Expires = DateTime.Now.AddDays(-1);
                }
            }
        }
    }
}