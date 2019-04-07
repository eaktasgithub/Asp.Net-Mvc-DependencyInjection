using DependencyInjection.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Models.Abstract
{
    /*
     * Soyut sınıf
     */
    public interface IProductManager
    {
        string Add(Product product);
    }
}
