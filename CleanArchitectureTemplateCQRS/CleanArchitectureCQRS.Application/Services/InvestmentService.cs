using AutoMapper;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Application.ViewModels;
using CleanArchitectureCQRS.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

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

        public async Task<IEnumerable<InvestmentViewModel>> GetAllAsync(CancellationToken cancellationToken)
        {
            var allInvestments = await this._investmentRepository.GetAllAsync(cancellationToken);

            return this._mapper.Map<IEnumerable<InvestmentViewModel>>(allInvestments);
        }
    }
}
