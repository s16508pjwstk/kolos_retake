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

        public IEnumerable<ArtMovement> GetArtMovements(int IdArtist)
        {
            _dbContext.ArtMovements
                .Where(ffa => ffa.IdMovementFounder == IdArtist)
                .Select(ffa => ffa);
        }

        public IEnumerable<Painting> GetPaintings(int IdArtist)
        {
            return _dbContext.Paintings
                .Where(ffa => ffa.IdArtist == IdArtist)
                .OrderByDescending(cp => cp.CreatedAt)
                .Select(ffa => ffa);
        }
    }
}
