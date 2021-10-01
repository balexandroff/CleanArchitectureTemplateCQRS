using AutoMapper;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Application.ViewModels;
using CleanArchitectureCQRS.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.Services
{
    public class CountryService: ICountryService
    {
        private readonly IMapper _mapper;

        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository, IMapper mapper)
        {
            this._countryRepository = countryRepository;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<CountryViewModel>> GetAllAsync(CancellationToken cancellationToken)
        {
            var allCountries = await this._countryRepository.GetAllAsync(cancellationToken);

            return this._mapper.Map<IEnumerable<CountryViewModel>>(allCountries);
        }
    }
}
