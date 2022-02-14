using apicore.model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apicore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {

        private readonly Repositorio repositorio;

        public DataController() {

            repositorio = new Repositorio();
        
        }
        // GET: api/<DataController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DataController>/5
        [HttpGet("{id}")]
        public CIFGENERALES Get(string id)
        {
            return repositorio.getporid(id);
        }

        // POST api/<DataController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DataController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DataController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
