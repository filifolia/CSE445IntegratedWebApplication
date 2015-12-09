using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Threading;


namespace Proj5Part1
{
    public class Global : HttpApplication
    {

        public static Int32 countNum = 0;

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
        }

        void Session_Start(object sender, EventArgs e){
            Interlocked.Increment(ref countNum);
        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when there is unhandled error occured
            Server.Transfer("Error.aspx");
        }
    }
}