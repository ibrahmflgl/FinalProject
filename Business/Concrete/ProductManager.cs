using Business.Apstract;
using Core.Utilities.Results;
using DataAccess.Apstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAllByCategoryId(int Id)
        {
            return _productDal.GetAll(p=>p.CategoryId == Id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>= min &&  p.UnitPrice<= max);   
        }

        public List<Product> ProductDetails => _productDal.GetAll();

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        public IResult Add(Product product)
        {
            //kurallar kodu da buraya yazıılr okey ise ekleme işlemi başlatılır 
            //burası bizim return ile döndürmediğimiz yer olcak 
            _productDal.Add(product);

            return new Result(true ,"ürün eklendi");
        }

        public Product GetById(int productId)
        {
           return _productDal.Get(p=>p.ProductId == productId);
        }

       
    }
}
       
         
   
