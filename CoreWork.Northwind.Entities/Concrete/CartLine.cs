using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWork.Northwind.Entities.Concrete
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
