using CoreWork.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWork.Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetByCategory(int categoryId);

        void Add(Product product);

        void Update(Product product);

        void Delete(int ProductId);
        Product GetById(int productId);
    }
}
