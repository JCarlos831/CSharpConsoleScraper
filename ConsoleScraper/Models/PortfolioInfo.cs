using System;
using System.Collections.Generic;

namespace ConsoleScraper.Models
{
    public class PortfolioInfo
    {
        public DateTime DatePulled { get; set; }
    
        public decimal CurrentPortfolioValue { get; set; }
    
        public decimal DayGain { get; set; }
    
        public decimal DayGainPercentage { get; set; }
    
        public decimal TotalGain { get; set; }
    
        public decimal TotalGainPercentage { get; set; }
        
        public virtual List<StockInfo> StockInfo { get; set; }

    }
}