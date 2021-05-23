using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace signal_hour
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected  void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteTable.Routes.Clear();
         
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
             
        
        
        }
    }
}
