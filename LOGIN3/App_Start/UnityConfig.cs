using LOGIN3.SERVICE;
using LOGIN3.SERVICE.Iservices;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace LOGIN3
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ILOGINSERVICE, LOGINService>();
            container.RegisterType<IREGISTRATIONSERVICE, LOGINService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}