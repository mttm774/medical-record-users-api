using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using medical_record_users_api.DataModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using medical_record_users_api.Configuration;
using medical_record_users_api.Middleware;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace medical_record_users_api.Controllers
{
    [Route("health")]
    public class HealthCheckController : Controller
    {   
     
        // GET: api/values
        [HttpGet]
        public IActionResult GetHealth()
        {
            TimeSpan uptime = UptimeMiddleware.GetUptime();
            var health = new {
                status = "OK",
                environment = Constants.ENVIRONMENT,
                uptime = uptime.ToString(@"dd\.hh\:mm\:ss") 
            };
            return Ok(health);
        }
    }
}