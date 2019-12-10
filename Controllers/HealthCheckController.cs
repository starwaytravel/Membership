using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Membership.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        // GET: api/HealthCheck
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var name = Dns.GetHostName();
            var ip = Dns.GetHostEntry(name).AddressList
                .FirstOrDefault(x => x.AddressFamily == AddressFamily.InterNetwork);

            return new string[] { "Membership Microservice is running", "API Version 2.1.2", "Container ID: " + name + " and " + "IP Address: " + ip.ToString() };
        }

        // GET: api/HealthCheck/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/HealthCheck
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/HealthCheck/5
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
