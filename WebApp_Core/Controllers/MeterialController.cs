using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_Core.Services;

namespace WebApp_Core.Controllers
{
    [Route("api/product")]
    public class MeterialController : Controller
    {
        [HttpGet("{productId}/materials")]
        public IActionResult GetMeterials(int? productId)
        {
            var product = ProductService.Current.Products.SingleOrDefault(x => x.Id == productId);

            if(product == null)
            {
                return NotFound();
            }
            return Ok(product.Materials);
        }

        [HttpGet("{productId}/materials/{id}")]
        public IActionResult GetMeterial(int ?productId, int? id)
        {
            var product = ProductService.Current.Products.SingleOrDefault(x => x.Id == productId);
            if(product == null)
            {
                return NotFound();
            }

            var material = product.Materials.SingleOrDefault(x => x.Id == id);
            if (material == null)
            {
                return NotFound();
            }
            return Ok(material);
        }
    }
}
