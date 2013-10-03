using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.Core;
using Castle.Windsor;
using Castle.Windsor.Installer;
using MvcApplication1.Installer;

namespace MvcApplication1
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        static IWindsorContainer _container;
        public IWindsorContainer Container
        {
            get { return _container; }
        }
      

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            BundleConfig.RegisterBundles(BundleTable.Bundles);


          //IEnumerable<Type> controllerTypes = from t in Assembly.GetExecutingAssembly().GetTypes()
          //                                      where typeof(IController).IsAssignableFrom(t)
          //                                      select t;
          //  foreach (Type t in controllerTypes)
          //      Console.WriteLine(t.FullName, t, LifestyleType.Transient);

          
            //_container = new WindsorContainer().Install(FromAssembly.InThisApplication());

           // _container = new WindsorContainer();
            
            _container = new WindsorContainer(
                new Castle.Windsor.Configuration.Interpreters.XmlInterpreter("Castle.config")).Install   
                (FromAssembly.This());
            var controllerFactory = new WindsorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);


            //AuthConfig.RegisterAuth();
        }

        protected void Application_End()
        {
            if (_container != null)
            {
                _container.Dispose();
            }
        }
    }
}