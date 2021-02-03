using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;  //global veri
        public InMemoryProductDal()
        {
            _products = new List<Product> 
            {
                //Oracle,Sql Server, Postgres, MongoDB vb'den geliyormuş gibi verileri simüle ediyoruz.
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5, CategoryId=2, ProductName="Fare", UnitPrice=85, UnitsInStock=1}
                
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // _products.Remove(product);  çalışmaz.. heapte 5te adres var. listede bulunananlar farklı referans numaralarında olduğu için bulamaz. referans tipler bu şekilde silinemez.
            /* 
                        Product productToDelete=null;  // = new Product() dersek boşu boşuna heapte boş bir referans işgal etmiş oluruz.
                       foreach (var p in _products)
                        {
                            if(product.ProductId == p.ProductId)
                            {
                                productToDelete = p;
                            }

                        }
                        */

            //LINQ - Language Integrated Query
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId); //using system.linq singleOrDefault yukarıdaki foreachi yapıyor
            //productToDelete = _products.FirstOrDefault(p=>p.ProductId == product.ProductId); 
            //productToDelete = _products.First(p=>p.ProductId == product.ProductId); 
            
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            
        }
    }
}
