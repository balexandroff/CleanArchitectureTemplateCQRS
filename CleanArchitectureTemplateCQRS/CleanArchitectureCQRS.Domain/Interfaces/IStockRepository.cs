using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Interfaces
{
    public interface IStockRepository : IRepository
    {
        public Task<IEnumerable<Stock>> GetAllAsync(CancellationToken cancellationToken);
    }
}
