using CleanArchitectureCQRS.Application.Common;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Application.Stocks.Queries;
using CleanArchitectureCQRS.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.API.Controllers
{
    //[Authorize]
    public class StocksController : BaseController
    {
        private IStockService _stockService;

        public StocksController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet("getall")]
        public async Task<ActionResult<ServiceResult<IEnumerable<StockViewModel>>>> GetAllStocks(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new GetAllStocksQuery(), cancellationToken));
        }
    }
}
