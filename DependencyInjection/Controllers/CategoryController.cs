using DependencyInjection.DTO;
using DependencyInjection.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjection.Controllers
{
    public class CategoryController : Controller
    {
        /*
        * Dependency İnjection tasarım deseni uygulanışı
        */
        private readonly ICategoryManager _categoryManager;
        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public ActionResult Add()
        {
            _categoryManager.Add(new Category());
            return View();
        }
    }
}