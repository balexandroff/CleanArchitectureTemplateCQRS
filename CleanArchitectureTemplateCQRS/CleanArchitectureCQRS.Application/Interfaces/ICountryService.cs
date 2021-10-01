using CleanArchitectureCQRS.Application.ViewModels;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Application.Interfaces
{
    public interface ICountryService: IService
    {
        public IEnumerable<CountryViewModel> GetAll();
    }
}
