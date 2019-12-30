using CoreWork.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWork.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
