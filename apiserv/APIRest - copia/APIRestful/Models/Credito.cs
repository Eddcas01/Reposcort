using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIRestful.Models
{
    public class Credito
    {

        [Key]
        public string COLNUMDOCUMEN { get; set; }   
       
        [Required]
        public int COLDIASMORAK { get; set; }

        [Required]
        public int COLCODCLIENTE { get; set; }
    }
}
