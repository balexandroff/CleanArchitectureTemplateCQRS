using CleanArchitectureCQRS.Application.ViewModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Interfaces
{
    public interface IStockService: IService
    {
        public Task<IEnumerable<StockViewModel>> GetAllAsync(CancellationToken cancellationToken);
    }
}
