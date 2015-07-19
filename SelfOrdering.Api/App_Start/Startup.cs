using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using AutoMapper;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using SelfOrdering.Api;
using SelfOrdering.Api.Mapping;
using SelfOrdering.ApplicationServices.Mapping;

[assembly: OwinStartup(typeof(Startup))]

namespace SelfOrdering.Api
{
    public class Startup
    {   
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            
            app.UseNinjectMiddleware(() => CreateKernel(config)).UseNinjectWebApi(config);

            ConfigureAutoMapper();
            
            ConfigureWebApi(config);
            
            app.UseCors(CorsOptions.AllowAll);
        }

        private StandardKernel CreateKernel(HttpConfiguration config)
        {
            var kernel = new StandardKernel(new NinjectSettings());
            
            kernel.Load("SelfOrdering.Infra.IoC.dll");
            
            GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);

            config.MessageHandlers.Add(kernel.Get(typeof(MessageHandler)) as DelegatingHandler);

            return kernel;
        }

        private void ConfigureWebApi(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.None;
            config.MapHttpAttributeRoutes();
            
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private void ConfigureAutoMapper()
        {
            Mapper.Configuration.AddProfile(new DomainToDTO());
            Mapper.Configuration.AddProfile(new DTOToDomain());
            Mapper.Configuration.AddProfile(new DTOToViewModel());
            Mapper.Configuration.AddProfile(new ViewModelToDTO());
        }
    }

}
