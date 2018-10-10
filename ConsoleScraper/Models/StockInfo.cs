using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleScraper.Models
{
    public class StockInfo
    {
        public string Symbol { get; set; }
        
        [Display(Name = "Last Price")]
        public decimal LastPrice { get; set; }

        public string PriceChange { get; set; }

        [Display(Name = "% Chg")]
        public string PriceChangePercentage { get; set; }

        public decimal Shares { get; set; }

        public decimal CostBasis { get; set; }

        public decimal MarketValue { get; set; }

        public string DayGain { get; set; }
        
        [Display(Name = "Day Gain %")]
        public string DayGainPercentage { get; set; }
        
        public string TotalGain { get; set; }
        
        [Display(Name = "Total Gain %")]
        public string TotalGainPercentage { get; set; }
        
        public string NoOfLots { get; set; }
        
        public string Notes { get; set; }
        
        public DateTime DateInserted { get; set; }
        
        public virtual PortfolioInfo PortfolioInfo { get; set;}
    }
}