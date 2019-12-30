using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWork.Northwind.Entities.Concrete;

namespace CoreWork.Northwind.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get;  set; }
        public int CurrentPage { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public int PageSize { get; internal set; }
        public int PageCount { get; internal set; }
    }
}
