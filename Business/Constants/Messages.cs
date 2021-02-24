using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages //static verilirse newlemek gerekmez.
    {
        public static string ProductAdded = "Ürün eklendi.";  //publicler PascalCase yazılır. ProductAdded
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda...";
        public static string ProductListed = "Ürünler listelendi.";
        public static string UnitPriceInvalid = "Ürün fiyatı geçersiz.";
        public static string ProductCountOfCategoryError="Bir kategoride 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceeded="Kategori limitine (15) ulaşıldı.";
    }
}
