using System.Collections.Generic;
using CoreWork.Northwind.Entities.Concrete;

namespace CoreWork.Northwind.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}