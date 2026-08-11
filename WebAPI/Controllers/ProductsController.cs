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




        [HttpGet("getall")]
        public IActionResult GetAll()

        {         
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }




        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }







    }
}
