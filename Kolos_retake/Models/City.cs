using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_retake.Models
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCity { get; set; }
        public string Name { get; set; }

        public int Population { get; set; } // nullable ??

        public virtual ICollection<Artist> Artists { get; set; }

    }
}
