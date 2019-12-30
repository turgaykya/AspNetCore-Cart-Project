using CoreWork.Core.Data.EntityFramework;
using CoreWork.Northwind.Data.Abstract;
using CoreWork.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWork.Northwind.Data.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}
