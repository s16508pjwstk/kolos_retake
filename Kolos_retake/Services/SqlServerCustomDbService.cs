using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_retake.Services
{
    public class SqlServerCustomDbService : ICustomDbService
    {
        private readonly CustomDbContext _dbContext;

        public SqlServerCustomDbService(CustomDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
