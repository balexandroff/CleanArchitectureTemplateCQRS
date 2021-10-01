using CleanArchitectureCQRS.Application.ViewModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Interfaces
{
    public interface IInvestmentService: IService
    {
        public Task<IEnumerable<InvestmentViewModel>> GetAllAsync(CancellationToken cancellationToken);
    }
}
