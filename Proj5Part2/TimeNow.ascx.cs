using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proj5Part2
{
    public partial class TimeNow : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString();
            lblDate.Text = date;
        }
    }
}