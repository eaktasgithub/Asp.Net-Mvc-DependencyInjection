using DependencyInjection.DTO;
using DependencyInjection.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace DependencyInjection.Models.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        /*
         Soyut sınıfın somut sınıfa implemantasyonu
        */
        public string Add(Category category)
        {
            return "Add Category Successful";
        }
    }
}