using Entities.Concrete;
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

    public interface IProductDal
    {
        List<Product> GetAll();
        // bunu yazınca normalde product altı cizili geliyor hata diyor ampüle tıklayıp add reference dicez 

        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId);

    }
}
