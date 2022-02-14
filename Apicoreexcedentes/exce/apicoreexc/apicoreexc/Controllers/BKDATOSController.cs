using apicoreexc.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apicoreexc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BKDATOSController : ControllerBase
    {

        private readonly repositorio reposi;

        public BKDATOSController()
        {

            reposi = new repositorio();

        }
        // GET: api/<BKDATOSController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BKDATOSController>/5
        //[HttpGet("{id}/{cred}")]
        //public COLTRANSAC Get(string id ,string cred)
        //{
        //    return reposi.getporid2(id, cred);
        //}


        [HttpGet("{id}")]
        public COLDOCUMENTO Get(string id)
        {
            return reposi.GETPORID3(id);
        }




        // POST api/<BKDATOSController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BKDATOSController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BKDATOSController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
