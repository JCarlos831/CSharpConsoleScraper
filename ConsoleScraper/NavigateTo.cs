using System.Threading;

namespace ConsoleScraper
{
    public static class NavigateTo
    {
        public static void TestPortfolioThroughYFinanceNavBar()
        {
            YFinanceNavBar yFinanceNavBar = new YFinanceNavBar();
            MyPortfolios myPortfolios = new MyPortfolios();
            
            yFinanceNavBar.MyPortfolio.Click();
            Thread.Sleep(3000);
            
            myPortfolios.CloseBox.Click();
                        
            myPortfolios.Test.Click();
            Thread.Sleep(1000);
        }

        public static void MyWatchlistThroughYFinanceNavBar()
        {
            YFinanceNavBar yFinanceNavBar = new YFinanceNavBar();
            MyPortfolios myPortfolios = new MyPortfolios();
            
            yFinanceNavBar.MyPortfolio.Click();
            Thread.Sleep(500);
            myPortfolios.MyWatchlist.Click();
            Thread.Sleep(500);
        }
        
    }
}