using System;

namespace CleanArchitectureCQRS.Application.ViewModels
{
    public class InvestmentViewModel
    {
        public Guid Id { get; set; }

        public Guid StockId { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal PurchasePrice { get; set; }

        public decimal CurrentPrice { get; set; }

        public decimal CurrentPL { get; set; }
    }
}
