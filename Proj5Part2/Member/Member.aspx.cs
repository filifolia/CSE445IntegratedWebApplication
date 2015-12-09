using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proj5Part2.ServiceReference2;
using System.Data.SqlClient;
using System.Web.Security;

namespace Proj5Part2.Member
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
            this.Label1.Text = client.WordFilter(this.TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
	        Server.Transfer("~/Default.aspx");

        }
    }
}