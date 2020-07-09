using Kolos_retake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_retake.DTO.Response
{
    public class ArtistResponse
    {
        public int IdArtist { get; set; }

        public IEnumerable<Painting> Paintings { get; set; }

        public IEnumerable<ArtMovement> ArtMovements { get; set; }
    }
}
