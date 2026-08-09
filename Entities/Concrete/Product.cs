
using Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //class cıplak kalmasın yav amac her yere product customer vs vs yazmadan tek isim ile IEntity den çağırmak 
    public class Product : IEntity
    {
        

        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        //ürün ismi 
        public string? ProductName    { get; set; }
        //stok adedi
        public short UnitsInStock { get; set; }
        //birim fiyatı
        public decimal UnitPrice { get; set; }



    }
}
