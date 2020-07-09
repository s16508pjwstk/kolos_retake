using Kolos_retake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_retake.Services
{
    public interface ICustomDbService
    {
        Artist GetArtist(int IdArtist);

        IEnumerable<Painting> GetPaintings(int IdArtist);

        IEnumerable<ArtMovement> GetArtMovements(int IdArtist);

    }
}
