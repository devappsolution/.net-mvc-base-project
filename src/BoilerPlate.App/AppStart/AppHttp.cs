using BoilerPlate.App.AppStart.Bundle;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BoilerPlate.App.AppStart
{
    public class AppHttp : HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            MvcHandler.DisableMvcResponseHeader = true;

            BundleTable.Bundles.Add(new StyleBundleConfig());
            BundleTable.Bundles.Add(new ScriptBundleConfig());
            BundleTable.EnableOptimizations = true;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            HttpContext.Current.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS");
            HttpContext.Current.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type,x-requested-with,Authorization,Access-Control-Allow-Origin");
            HttpContext.Current.Response.Headers.Add("Access-Control-Allow-Credentials", "true");
            HttpContext.Current.Response.Headers.Add("Access-Control-Max-Age", "86400");
        } 
    }
}
