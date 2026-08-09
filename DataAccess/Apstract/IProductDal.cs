using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Apstract
{
    //isimlendirme acıklaması :
    //I = interface
    //product = ürün 
    //Dal = data access layer
    //javacılar buna dao = data access object te diyebiliyor 

    public interface IProductDal :IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    
    }
}
