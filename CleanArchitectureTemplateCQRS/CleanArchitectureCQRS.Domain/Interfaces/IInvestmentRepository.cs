using CleanArchitectureCQRS.Domain.Entities;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.Interfaces
{
    public interface IInvestmentRepository: IRepository
    {
        public IEnumerable<Investment> GetAll();
    }
}
