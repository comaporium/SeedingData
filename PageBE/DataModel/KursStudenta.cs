using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PageBE.DataModel
{
    public class KursStudenta
    {
        [Key]
        public int kursStudentaId { get; set; }

        [Required]
        [ForeignKey("Studentis")]
        public int studentId { get; set; }

        [Required]
        [ForeignKey("Kurs")]
        public int kursId { get; set; }

        public virtual Studenti Studentis { get; set; }
        public virtual Kurs Kurs { get; set; }
    }
}
