using DependencyInjection.Models.Abstract;
using DependencyInjection.Models.Concrete;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DependencyInjection.Ninject
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        
        /*
         * Inversion of Control (IoC)container ile nesne üretme işlemini bir container nesnesi ile gerçekleştirdik
         */
        private readonly IKernel _kernel;
        public NinjectControllerFactory()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<IProductManager>().To<ProductManager>();
            _kernel.Bind<ICategoryManager>().To<CategoryManager>();
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
           return controllerType == null ? null :(IController)_kernel.Get(controllerType);
        }
    }
    /*
     *  NinjectControllerFactory :IController da yapılabilir.
     *  Biz DefaultControllerFactory içersinde ki virtual olan GetControllerInstance metodunun çalışma şeklini değiştirmeyi  tercih ettik.
     *  Mvc de bir Controller'dan istekte bulunulduğu zaman DefaultControllerFactory çalışır ve 
     * Controllerdan bir nesne üretir ve metodu invoke eder. bu parametresiz controller için geçerlidir.
     * Construct  parametre alan controller için DefaultControllerFactory çalışamaz bizde bu yüzden kendi NinjectControllerFactory controllerımızı yazdık
     */
}