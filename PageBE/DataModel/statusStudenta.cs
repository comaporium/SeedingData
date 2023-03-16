using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PageBE.DataModel
{
    public class StatusStudenta
    {
        public StatusStudenta()
        {
            Studentis = new HashSet<Studenti>();
        }

        [Key]
        public int statusId { get; set; }
        [Required][StringLength(10)]
        public string NazivStatusa { get; set; }

        public virtual ICollection<Studenti> Studentis { get; set; }
    }
}
