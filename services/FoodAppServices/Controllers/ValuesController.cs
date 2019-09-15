using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodAppRepository.ProductRepository;
using Microsoft.AspNetCore.Mvc;
using FoodAppModels.Models;

namespace FoodAppServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        ProductRepository _productRepository = null;
        public ValuesController()
        {
            _productRepository = new ProductRepository();
        }

        // GET api/values
        [HttpGet]
        //public ActionResult<IEnumerable<string>> GetProduct()
        //{

        //     _productRepository.GetProduct();
        //  //  return new string[] { "abhinav  LLB", "value2" };
        //}
        // GET api/values
        [HttpGet]
        public IActionResult GetProductDetail()
        {
            IEnumerable<Product> products = _productRepository.GetProduct();
            return Ok(products);
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
