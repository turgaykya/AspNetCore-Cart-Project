using CoreWork.Core.Data;
using CoreWork.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWork.Northwind.Data.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
