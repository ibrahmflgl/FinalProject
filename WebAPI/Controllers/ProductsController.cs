using Business.Apstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //üsteki yapının adı ATTRIBUTE yani burda demek istediğimiz bu class bir controllerdır oyüzden kendini ona göre yapılandır diyrouz .net e 

    public class ProductsController : ControllerBase
    {
        //loosely coupled gevşek bağlılık demek 
        //naming convertion _ ile isimlerndirme olayı 

        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()

        {
           

            var result = _productService.GetAll();

            return result.Data;

           
        }
      

    }
}
