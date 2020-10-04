using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ApiLoadBalancer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Server : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<Server> _logger;

        public Server(ILogger<Server> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get([FromServices] IConfiguration config)
        {
            var releaseNum = config.GetValue<string>("ReleaseNum");

            return "Servidor: " + Environment.MachineName + " | Release Num.: " + releaseNum;
        }
    }
}
