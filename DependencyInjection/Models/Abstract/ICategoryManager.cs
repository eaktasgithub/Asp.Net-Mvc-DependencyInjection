using DependencyInjection.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Models.Abstract
{
    /*
     * Soyut sınıf
     */
    public interface ICategoryManager
    {
        string Add(Category category);
    }
}