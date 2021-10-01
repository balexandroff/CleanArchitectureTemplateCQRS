using CleanArchitectureCQRS.Application.ViewModels;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Application.Interfaces
{
    public interface IInvestmentService: IService
    {
        public IEnumerable<InvestmentViewModel> GetAll();
    }
}
