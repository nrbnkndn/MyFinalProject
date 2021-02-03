using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic constraint 
    //class: referans tip 
    //IEntity: IENtity olabilr veya IENtity implemente olan bir nesne olabilir
    //new(): new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {

        //aşağıdakiler default publictir. interface'in kendisi default public değildir.
        //filter=null ise filtre vermek optional
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
