using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolos_retake.Models;

namespace Kolos_retake.Services
{
    public class SqlServerCustomDbService : ICustomDbService
    {
        private readonly CustomDbContext _dbContext;

        public SqlServerCustomDbService(CustomDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        

        public Artist GetArtist(int IdArtist)
        {
            return _dbContext.Artists
                .Where(a => a.IdArtist == IdArtist)
                .FirstOrDefault();
        }

        public IEnumerable<Artist> GetArtists(string NickName)
        {
            return _dbContext.Artists
                .Where(ffa => ffa.NickName == NickName)
                .Select(ffa => ffa);
        }

        public ArtMovement GetArtMovement(int IdArtMovement)
        {
            return _dbContext.ArtMovements
                .Where(a => a.IdArtMovement == IdArtMovement)
                .FirstOrDefault();
        }

        public IEnumerable<ArtMovement> GetArtMovements(int IdArtist)
        {
            return _dbContext.ArtMovements
                .Where(ffa => ffa.IdMovementFounder == IdArtist)
                .Select(ffa => ffa);
        }

        public City GetCity(int IdCity)
        {
            return _dbContext.Cities
                .Where(a => a.IdCity == IdCity)
                .FirstOrDefault();
        }

        public IEnumerable<Painting> GetPaintings(int IdArtist)
        {
            return _dbContext.Paintings
                .Where(ffa => ffa.IdArtist == IdArtist)
                .OrderByDescending(cp => cp.CreatedAt)
                .Select(ffa => ffa);
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Add<T>(T artist)
        {
            throw new NotImplementedException();
        }
    }
}
