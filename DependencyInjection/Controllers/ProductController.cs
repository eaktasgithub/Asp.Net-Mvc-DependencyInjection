using DependencyInjection.DTO;
using DependencyInjection.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjection.Controllers
{
    public class ProductController : Controller
    {
        /*
         * Dependency İnjection tasarım deseni uygulanışı
         */
        IProductManager _productManager;
        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;
        }
        public ActionResult Index()
        {
            _productManager.Add(new Product());
            return View();
        }
    }
}