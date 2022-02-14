using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace APIRestful.Models
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
        public int CIFCELTELEFONO { get; set; }
        [Required]
        public int CIFFIJTELEFONO { get; set; }
        [Required]
        public string CIFDOCIDENT06 { get; set; }
        [Required]
        public string CIFSTATUS { get; set; }









    }
}
