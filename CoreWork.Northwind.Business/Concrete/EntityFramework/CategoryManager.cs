using CoreWork.Northwind.Business.Abstract;
using CoreWork.Northwind.Data.Abstract;
using CoreWork.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWork.Northwind.Business.Concrete.EntityFramework
{
    public class CategoryManager : ICategoryService
    {

        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
