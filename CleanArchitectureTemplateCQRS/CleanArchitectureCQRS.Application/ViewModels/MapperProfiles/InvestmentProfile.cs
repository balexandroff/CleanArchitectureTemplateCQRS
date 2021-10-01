using AutoMapper;
using CleanArchitectureCQRS.Domain.Entities;

namespace CleanArchitectureCQRS.Application.ViewModels.MapperProfiles
{
    public class InvestmentProfile : Profile
    {
        public InvestmentProfile()
        {
            CreateMap<Investment, InvestmentViewModel>();
        }
    }
}
