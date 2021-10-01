using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitectureCQRS.Infrastructure.Data.Repositories
{
    public class InvestmentRepository : BaseRepository<Investment>, IInvestmentRepository
    {
        public InvestmentRepository(StocksDbContext context) : base(context) { }

        public IEnumerable<Investment> GetAll()
        {
            return _context.Investments.ToList();
        }
    }
}
