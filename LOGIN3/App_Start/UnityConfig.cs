using LOGIN3.BR;
using LOGIN3.SERVICE;
using LOGIN3.SERVICE.Iservices;
using System.Runtime.InteropServices;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

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
            container.RegisterType<ISTATESERVICE, Stateservice>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}