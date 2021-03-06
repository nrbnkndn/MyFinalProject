using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //List<Product> GetAll();  //hem başarı hem mesaj hem de veri(list<product>) döndürecek bir şey yazacağız.
        IDataResult<List<Product>> GetAll();  
        //List<Product> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetAllByCategoryId(int id);

        //List<Product> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        //List<ProductDetailDto> GetProductDetails();
        IDataResult<List<ProductDetailDto>> GetProductDetails();

        //Product GetById(int productId);
        IDataResult<Product> GetById(int productId);

        //void Add(Product product);
        IResult Add(Product product); //Artık void olan her yerde IResult kullanacağız. WEbAPI dersi. başarılı ya da başarısız olduğunun dönmesi için void yerine ekledik. void yapsak bir şey dönmeyecek sadece ekleme işlemini yapacak.
        IResult Update(Product product);
        IResult AddTransactionalTest(Product product);
    }
}
