using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_retake.Models
{
    public class Painting
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPainting { get; set; }
        public string SurfaceType { get; set; }
        public string PaintingMedia { get; set; }
        public int IdArtist { get; set; }
        public int IdCoAuthor { get; set; }
        public DateTime CreatedAt;

        public virtual Artist Artist { get; set; }
        public virtual Artist CoAuthor { get; set; }
    }
}
