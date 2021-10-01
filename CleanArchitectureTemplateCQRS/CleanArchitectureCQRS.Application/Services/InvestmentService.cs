using AutoMapper;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Application.ViewModels;
using CleanArchitectureCQRS.Domain.Interfaces;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Application.Services
{
    public class InvestmentService: IInvestmentService
    {
        private readonly IMapper _mapper;

        private readonly IInvestmentRepository _investmentRepository;


        public InvestmentService(IInvestmentRepository investmentRepository, IMapper mapper)
        {
            this._investmentRepository = investmentRepository;
            this._mapper = mapper;
        }

        public IEnumerable<InvestmentViewModel> GetAll()
        {
            var allInvestments = this._investmentRepository.GetAll();

            return this._mapper.Map<IEnumerable<InvestmentViewModel>>(allInvestments);
        }
    }
}
