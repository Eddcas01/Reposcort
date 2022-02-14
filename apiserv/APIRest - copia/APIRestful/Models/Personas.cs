using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIRestful.Models
{
    public class Personas
    {

        // 
        [Key]
        public int CIFCODCLIENTE { get; set; }
        [Required]
        public string CIFNOMBRECLIE { get; set; }
    

        [Required]
        public string CIFINTERNET { get; set; }

        [Required]
        public int CIFCELTELEFONO { get; set; }
        [Required]
        public int CIFFIJTELEFONO { get; set; }
        [Required]
        public string CIFDOCIDENT06 { get; set; }
        [Required] 
        public string CIFSTATUS { get; set; }





    }
}
