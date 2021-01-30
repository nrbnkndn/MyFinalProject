using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //public -> bu metota diğer katmanlar da ulaşabilsin diye yazılır.
    //Bir class'ın defaultu internaldır ve bu durumda sadece "Entities" erişebilir.
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
