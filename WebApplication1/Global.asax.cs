using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

[assembly: XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]

namespace WebApplication1
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(WebApiApplication));

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            _log.Info($"Application starting up. Culture (on thread) is: {System.Threading.Thread.CurrentThread.CurrentCulture.Name}. DateTime.Now (Local) is {DateTime.Now.ToString()}");

            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

    }
}
