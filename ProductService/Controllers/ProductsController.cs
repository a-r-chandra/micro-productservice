using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Models;
using static Utilities.NetworkUtils;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IHttpContextAccessor _httpContextAccessor;
        public ProductsController(IHttpContextAccessor httpContextAccessor) {
            _httpContextAccessor = httpContextAccessor;
        }
                
        // GET: api/Products
        [HttpGet]
        public Tuple<IEnumerable<Product>,string> Get()
        {
            return new Tuple<IEnumerable<Product>, string>(new Product[] {
                new Product {
                    id = "978-1717075901",
                    title = "Microservices: A Practical Guide",
                    description = "Microservices have many advantages: Efficiently implementing more features, bringing software into production faster, robustness and easy scalability are among them. But implementing a microservices architecture and selecting the necessary technologies are difficult challenges.",
                    price = 36.90,
                    quantity = 65,
                    category = "books"
                }
            }, $"Called from: {GetRequestInfo(_httpContextAccessor)} " +
            $" | Handled by machine: {Environment.MachineName}, IP: [{GetIPs()}], OS: {Environment.OSVersion}");
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
       
    }
}
