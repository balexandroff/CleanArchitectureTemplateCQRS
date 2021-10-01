using CleanArchitectureCQRS.Application.ViewModels;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Application.Interfaces
{
    public interface IStockService: IService
    {
        public IEnumerable<StockViewModel> GetAll();
    }
}
