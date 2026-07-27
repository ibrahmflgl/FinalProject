
using Entities.Apstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : IEntitiy
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
