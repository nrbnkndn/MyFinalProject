using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]  // route -> isteği yaparken insanlar bize nasıl ulaşsın? onun tanımı.. burası localhost/api/controller
    [ApiController]   //Attribute c# - javada annotation  ->> attribute nedir? bir class ile ilgili bir imza verme, bir bilgi verme. bu class bir kontrollerdır diye baştan belirtiyoruz.
    public class ProductsController : ControllerBase
    {
        //Loosely coupled -- gevşek bağımlılık. bir bağımlılık var ama soyuta bir bağımlılık var. manager değişse de bizi alakadar etmez.
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _productService.GetAll();
            if(result.Success)
            {
                return Ok(result);  //Get requestlerde 200 ile çalışırız.
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);  //Get requestlerde 200 ile çalışırız.
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
            return BadRequest(result);
        }
    }
}
