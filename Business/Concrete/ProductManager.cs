using Business.Apstract;
using DataAccess.Apstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {

        //kural neydi bir iş sınıfı asla new lemez iyi bir kullanım değil ilerde 
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // iş kodları varsa
            return _productDal.GetAll();

        }
    }
}
