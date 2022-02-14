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
        public int idcred { get; set; }
       
        [Required]
        public int dias { get; set; }

        [Required]
        public int cifgeneral { get; set; }
    }
}
