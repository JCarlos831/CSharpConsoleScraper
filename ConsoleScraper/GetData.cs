using System;
using System.Threading;

namespace ConsoleScraper
{
    public static class GetData
    {
        public static void Scrape()
        {
            Actions.InitializeDriver();
            
            Actions.FillUsername(Config.Credentials.Valid.Username);
            Thread.Sleep(500);
            
            Actions.FillPassword(Config.Credentials.Valid.Password);
            Thread.Sleep(500);
            
            NavigateTo.TestPortfolioMyHoldings();
            Thread.Sleep(3000);
            
//            NavigateTo.MyHoldingsScreen();
//            Thread.Sleep(3000);
            
            Actions.GetStockDataFromTable();            
        }
    }
}