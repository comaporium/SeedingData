using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PageBE.DataModel
{
    public class Kurs
    {
        [Key]
        public int kursId { get; set; }
        [Required]
        [StringLength(100)]
        public string NazivKursa { get; set; }
    }
}
