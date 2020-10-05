using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace IntegracaoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IntegracaoController : ControllerBase
    {
        // GET api/Integracao
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Integracao5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // Post api/Integracao
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // Put api/Integracao
        [HttpPut]
        public void Put(int id, [FromBody] string value)
        {
        }

        // Delete api/Integracao
        [HttpDelete]
        public void Deçete(int id)
        {
        }
    }
}
