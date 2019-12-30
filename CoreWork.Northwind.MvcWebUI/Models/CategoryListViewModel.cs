using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWork.Northwind.Entities.Concrete;

namespace CoreWork.Northwind.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get;  set; }
        public int CurrentCategory { get; internal set; }
    }
}
