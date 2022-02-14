using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apicore.model
{
    public class CIFGENERALES
    {


        [Key]
        public int CIFCODCLIENTE { get; set; }
        [Required]
        public string CIFNOMBRECLIE { get; set; }


        [Required]
        public string CIFINTERNET { get; set; }
        [Required]
        public string CIFFECNACIMIE { get; set; }
        [Required]
        public int CIFCELTELEFONO { get; set; }
        [Required]
        public int CIFFIJTELEFONO { get; set; }
        [Required]
        public string CIFDOCIDENT06 { get; set; }
       
    }
}
