using AutoMapper;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Application.ViewModels;
using CleanArchitectureCQRS.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Aplication.Services
{
    public class StockService: IStockService
    {
        private readonly IMapper _mapper;

        private readonly IStockRepository _stockRepository;

        public StockService(IStockRepository stockRepository, IMapper mapper)
        {
            this._stockRepository = stockRepository;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<StockViewModel>> GetAllAsync(CancellationToken cancellationToken)
        {
            var allStocks = await this._stockRepository.GetAllAsync(cancellationToken);

            return this._mapper.Map<IEnumerable<StockViewModel>>(allStocks);
        }
    }
}
