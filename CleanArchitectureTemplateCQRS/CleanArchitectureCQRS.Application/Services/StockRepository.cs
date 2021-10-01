using AutoMapper;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Application.ViewModels;
using CleanArchitectureCQRS.Domain.Interfaces;
using System.Collections.Generic;

namespace CleanArchitecture.Aplication.Services
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

        public IEnumerable<StockViewModel> GetAll()
        {
            var allStocks = this._stockRepository.GetAll();

            return this._mapper.Map<IEnumerable<StockViewModel>>(allStocks);
        }
    }
}
