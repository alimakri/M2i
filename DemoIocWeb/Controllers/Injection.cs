using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoIocWeb.Controllers
{
    public class NinjectIoc : IDependencyResolver
    {
        public IKernel kernel;
        public NinjectIoc()
        {
            kernel = new StandardKernel();
            kernel.Bind<IVehicule>().To<Auto>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }

    public class Autoroute
    {
        public Autoroute(IVehicule v)
        {
            V = v;
        }
        public IVehicule V;
    }
    public interface IVehicule
    {
        string Roule();
    }
    public class Auto : IVehicule
    {
        public string Roule()
        {
            return "L'auto roule";
        }
    }
    public class Velo : IVehicule
    {
        public string Roule()
        {
            return "Le vélo roule";
        }
    }
}