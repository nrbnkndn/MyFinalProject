﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //DAL -> data access layer .nettte
    //DAO -> data access object javada
    public interface IProductDal : IEntityRepository<Product>
    {
        

    }
}
