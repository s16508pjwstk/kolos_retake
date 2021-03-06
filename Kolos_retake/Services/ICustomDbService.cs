﻿using Kolos_retake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_retake.Services
{
    public interface ICustomDbService
    {
        Artist GetArtist(int IdArtist);

        IEnumerable<Artist> GetArtists(string NickName);

        City GetCity(int IdCity);

        ArtMovement GetArtMovement(int IdArtMovement);

        IEnumerable<Painting> GetPaintings(int IdArtist);

        IEnumerable<ArtMovement> GetArtMovements(int IdArtist);
        void Add<T>(T artist);
        void SaveChanges();
    }
}
