using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWork.Northwind.Entities.Concrete;

namespace CoreWork.Northwind.MvcWebUI.Models
{
    public class ProductAddViewModel
    {
        public ProductAddViewModel()
        {
            Categories = new List<Category>();
        }
        public Product Product { get;  set; }
        public List<Category> Categories { get;  set; }
    }
}
