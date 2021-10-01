using CleanArchitectureCQRS.Application.ViewModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Interfaces
{
    public interface ICountryService: IService
    {
        public Task<IEnumerable<CountryViewModel>> GetAllAsync(CancellationToken cancellationToken);
    }
}
