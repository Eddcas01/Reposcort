using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace apicore.model
{
    public class COLTRANSAC
    {


        [Key]
        public int COLNUMDOCUMEN { get; set; }
        [Required]
        public string COLNUMTRANSAC { get; set; }


        [Required]
        public string COLNUMBOLETA { get; set; }
        [Required]
        public string COLVALINGRE01 { get; set; }
    }


}
