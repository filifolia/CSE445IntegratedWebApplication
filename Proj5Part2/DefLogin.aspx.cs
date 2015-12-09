using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proj5Part2
{
    public partial class DefLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Manages the return URLs of multiple pages.
            if (!String.IsNullOrEmpty(Request.QueryString["ReturnUrl"]))
            {
                if (Request.QueryString["ReturnUrl"].Contains("Staff"))
                {
                    Response.Redirect("StaffLogin.aspx");

                }
                else
                {
                    Response.Redirect("MemberLogin.aspx");
                }
            }
        }
    }
}