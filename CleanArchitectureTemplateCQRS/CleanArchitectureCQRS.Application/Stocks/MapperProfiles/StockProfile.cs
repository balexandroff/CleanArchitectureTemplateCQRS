using AutoMapper;
using CleanArchitectureCQRS.Domain.Entities;

namespace CleanArchitectureCQRS.Application.ViewModels.MapperProfiles
{
    public class StockProfile : Profile
    {
        public StockProfile()
        {
            CreateMap<Stock, StockViewModel>();
                //.ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country));
        }
    }
}
