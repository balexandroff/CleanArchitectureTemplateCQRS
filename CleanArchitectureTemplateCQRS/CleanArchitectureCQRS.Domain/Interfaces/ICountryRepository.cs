using CleanArchitectureCQRS.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Interfaces
{
    public interface ICountryRepository: IRepository
    {
        public Task<IEnumerable<Country>> GetAllAsync(CancellationToken cancellationToken);
    }
}
