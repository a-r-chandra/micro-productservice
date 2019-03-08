using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [Route("health_check")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        // GET: api/HealthCheck
        [HttpGet]
        public OkResult Get()
        {
            return Ok();
        }
    }
}