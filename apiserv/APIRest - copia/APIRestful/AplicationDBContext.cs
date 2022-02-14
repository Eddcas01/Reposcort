using APIRestful.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIRestful
{
    public class AplicationDBContext : DbContext
    {
        public DbSet<CIFGENERALES> CIFGENERALES { get; set; }

        public DbSet<COLDOCUMENTO> COLDOCUMENTO { get; set; }
        //herencia de clase abstracta con base
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base(options) { 
        
        
        //inyeccion de dependencias o inyeccion de contexto dentro del contenedor de servicios


        
        
        }


         
    }
}
