using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_retake.Models
{
    public class Artist
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdArtist { get; set; }
        public int IdArtMovement { get; set; }
        public int IdCityOfBirth { get; set; }

        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string NickName { get; set; } // nullable

        public DateTime DateOfBirth { get; set; }

        

        public virtual City City { get; set; }
        public virtual ICollection<ArtMovement> ArtMovements { get; set; }
        public virtual ICollection<Painting> CreatedPaintings { get; set; }
        // public virtual ICollection<Painting> CoCreatedPaintings { get; set; }



        //[MaxLength(100)]
        //[ForeignKey("Subject")]
    }
}
