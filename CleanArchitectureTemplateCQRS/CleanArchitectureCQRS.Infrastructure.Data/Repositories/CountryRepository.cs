using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitectureCQRS.Infrastructure.Data.Repositories
{
    public class CountryRepository: BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(StocksDbContext context) : base(context) { }

        public IEnumerable<Country> GetAll()
        {
            return _context.Countries.ToList();
        }
    }
}
