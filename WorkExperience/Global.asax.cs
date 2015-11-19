using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using System.Web.SessionState;
using WorkExperience.Models;

namespace WorkExperience
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            // Routing Stuff
            GlobalConfiguration.Configure(WebApiConfig.Register);

            // DI Stuff
            var container = new Container();
            //container.Register<IResumeRepository, ResumeRepository>(Lifestyle.Transient);
            container.Register<IResumeRepository, ResumeMongoRepository>(Lifestyle.Transient);
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container); 
        }

        #region Defaults

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

        }

        #endregion

    }
}