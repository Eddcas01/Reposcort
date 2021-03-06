using APIRestful.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIRestful.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public PersonaController(AplicationDBContext context)
        {
            _context = context;


        }
      
        // GET: api/<PersonaController>
        //sirve para crear la tarea en otro hilo por eso es asincrona
        [HttpGet]
        public async Task<IActionResult>  Get()
        {
            try {

                var datos = await _context.personas.ToListAsync();

                return Ok(datos) ;
}
            catch(Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public Personas Get(int id)
        {

            var datos2 = _context.credito.FirstOrDefault(m=>m.cifgeneral == id && m.dias == 0);

            if (datos2 != null)
            {
                var datos = _context.personas.FirstOrDefault(p => p.CIF == id && p.EST == 1);

                return datos;


            }
            else {
               return null;
            
            }
          

        }



        // POST api/<PersonaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
