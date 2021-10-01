using CleanArchitectureCQRS.Domain.Entities;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.Interfaces
{
    public interface ICountryRepository: IRepository
    {
        public IEnumerable<Country> GetAll();
    }
}
