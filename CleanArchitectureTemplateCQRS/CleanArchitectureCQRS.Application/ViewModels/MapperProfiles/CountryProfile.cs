using AutoMapper;
using CleanArchitectureCQRS.Domain.Entities;

namespace CleanArchitectureCQRS.Application.ViewModels.MapperProfiles
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryViewModel>();
        }
    }
}
