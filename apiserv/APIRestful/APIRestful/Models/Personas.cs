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
        public int personaid { get; set; }
        [Required]
        public int CIF { get; set; }
        [Required]
        public string NOMBRES { get; set; }

        [Required]
        public DateTime FECHANAC { get; set; }

        [Required]
        public string EMAIL { get; set; }
        [Required]
        public int NOCEL { get; set; }
        [Required]
        public int NOTEL { get; set; }
        [Required] 
        public int EST { get; set; }





    }
}
