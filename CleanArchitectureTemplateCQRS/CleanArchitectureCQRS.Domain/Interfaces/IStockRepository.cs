using CleanArchitectureCQRS.Domain.Entities;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.Interfaces
{
    public interface IStockRepository: IRepository
    {
        public IEnumerable<Stock> GetAll();
    }
}
