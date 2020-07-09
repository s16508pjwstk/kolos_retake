using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_retake.Models
{
    public class ArtMovement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdArtMovement { get; set; }
        public int? IdNextArtMovement { get; set; }
        public int IdMovementFounder { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
        public DateTime DateFounded { get; set; }


        public virtual ICollection<ArtMovement> ArtMovements { get; set; }

        public virtual Artist Founder { get; set; }

    }
}
