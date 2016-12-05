﻿using $ext_projectname$.Core.Infrastructure;
using Microsoft.Owin;
using Owin;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;

[assembly: OwinStartup(typeof($safeprojectname$.Startup))]
namespace $safeprojectname$
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var container = ConfigureSimpleInjector(app);
            var config = new HttpConfiguration
            {
                DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container)
            };

            ConfigureOAuth(app, container);

            WebApiConfig.Register(config);
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseWebApi(config);

            container.GetInstance<IDatabaseInitializer>().Initialize();
        }
    }
}