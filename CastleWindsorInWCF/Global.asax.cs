using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Castle.Windsor;

namespace CastleWindsorInWCF
{
    public class Global : System.Web.HttpApplication
    {
        private static IWindsorContainer container;
        protected void Application_Start(object sender, EventArgs e)
        {
           
            container = new WindsorContainer(new    
Castle.Windsor.Configuration.Interpreters.XmlInterpreter("Castle.config"));
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            if (container != null)
            {
                container.Dispose();
            }
        }
    }
}