using CleanArchitectureCQRS.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Interfaces
{
    public interface IInvestmentRepository: IRepository
    {
        public Task<IEnumerable<Investment>> GetAllAsync(CancellationToken cancellationToken);
    }
}
