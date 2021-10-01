using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Infrastructure.Data.Repositories
{
    public class InvestmentRepository : BaseRepository<Investment>, IInvestmentRepository
    {
        public InvestmentRepository(StocksDbContext context) : base(context) { }

        public async Task<IEnumerable<Investment>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _context.Investments.ToListAsync(cancellationToken);
        }
    }
}
