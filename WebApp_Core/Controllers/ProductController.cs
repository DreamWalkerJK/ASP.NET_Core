using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_Core.Models;
using WebApp_Core.Services;

namespace WebApp_Core.Controllers
{
    [Route("api/product")]
    public class ProductController : Controller
    {
        [HttpGet("all")]
        public IActionResult GetProducts()
        {
            return Ok(ProductService.Current.Products);
        }

        [Route("{id}")]
        public IActionResult GetProduct(int? id)
        {
            var product = ProductService.Current.Products.SingleOrDefault(x => x.Id == id);

            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
