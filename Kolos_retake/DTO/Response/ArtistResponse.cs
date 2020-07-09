using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_retake.DTO.Response
{
    public class ArtistResponse
    {
        public int IdArtist { get; set; }

        public ICollection<Paintings> Paintings { get; set; }

        public ICollection<ArtMovement> ArtMovements { get; set; }
    }
}
