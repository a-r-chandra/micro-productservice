using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/Products
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return new Product[] {
                new Product {
                    id = "978-1717075901",
                    title = "Microservices: A Practical Guide",
                    description = "Microservices have many advantages: Efficiently implementing more features, bringing software into production faster, robustness and easy scalability are among them. But implementing a microservices architecture and selecting the necessary technologies are difficult challenges.",
                    price = 36.90,
                    quantity = 65,
                    category = "books"
                },
                new Product {
                    id = "978-1788479356",
                    title = "Learning Continuous Integration with Jenkins",
                    description = "This book starts off by explaining the concepts of CI and its significance in the Agile world with a whole chapter dedicated to it. Next, you'll learn to configure and set up Jenkins in many favourite ways. The way the world sees CI/CD is changing, and so is Jenkins.",
                    price = 44.99,
                    quantity = 14,
                    category = "books"
                }
            };
        }

        // GET: api/Products/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(string id)
        {
            return "value";
        }

        // POST: api/Products
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
