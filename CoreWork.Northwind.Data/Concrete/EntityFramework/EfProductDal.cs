using CoreWork.Core.Data.EntityFramework;
using CoreWork.Northwind.Data.Abstract;
using CoreWork.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CoreWork.Northwind.Data.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        
    }

   
}
