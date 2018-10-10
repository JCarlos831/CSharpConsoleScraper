using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace ConsoleScraper
{
    public static class NavigateTo
    {
        public static void TestPortfolioMyHoldings()
        {
            YFinanceNavBar yFinanceNavBar = new YFinanceNavBar();
            PortfolioNavBar portfolioNavBar = new PortfolioNavBar();
            MyPortfolios myPortfolios = new MyPortfolios();

            yFinanceNavBar.MyPortfolio.Click();
            Thread.Sleep(3000);

            myPortfolios.CloseBox.Click();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);


            //myPortfolios.CloseBox2.Click();
                        
            myPortfolios.Test.Click();
            Thread.Sleep(1000);
            
            portfolioNavBar.MyHoldings.Click();
            Thread.Sleep(2000);
        }

//        public static void MyHoldingsScreen()
//        {
//            PortfolioNavBar portfolioNavBar = new PortfolioNavBar();
//            portfolioNavBar.MyHoldings.Click();
//            Thread.Sleep(3000);
//        }
        

//        public static void MyWatchlistThroughYFinanceNavBar()
//        {
//            YFinanceNavBar yFinanceNavBar = new YFinanceNavBar();
//            MyPortfolios myPortfolios = new MyPortfolios();
//            
//            yFinanceNavBar.MyPortfolio.Click();
//            Thread.Sleep(500);
//            myPortfolios.MyWatchlist.Click();
//            Thread.Sleep(500);
//        }
        
    }
}