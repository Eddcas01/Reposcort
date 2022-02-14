using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace APIRestful.Models
{
    public class COLDOCUMENTO
    {

        [Key]
        public string COLNUMDOCUMEN { get; set; }

        [Required]
        public int COLDIASMORAK { get; set; }

        [Required]
        public int COLCODCLIENTE { get; set; }



    }
}
