using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //DAL -> data access layer .nettte
    //DAO -> data access object javada
    public interface IProductDal
    {
        //aşağıdakiler default publictir. interface'in kendisi default public değildir.
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);
    }
}
