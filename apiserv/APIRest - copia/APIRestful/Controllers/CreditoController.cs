using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIRestful.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditoController : ControllerBase
    {
        private readonly AplicationDBContext _context;
        public CreditoController(AplicationDBContext context)
        {
            _context = context;


        }
        // GET: api/<CreditoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CreditoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CreditoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CreditoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CreditoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
