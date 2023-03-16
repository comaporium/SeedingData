using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PageBE.DataModel
{
    public class Studenti
    {
        [Key]
        public int studentId { get; set; }

        [Required]
        public int brojIndexa { get; set; }

        [StringLength(20)]
        public string Ime { get; set; }

        [StringLength(20)]
        public string Prezime { get; set; }

        public int Godina { get; set; }
        [Required]
        [ForeignKey("statusStudentas")]
        public int? statusId { get; set; }

        public virtual StatusStudenta StatusStudenta { get; set; }
    }
}
