using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using ConsoleScraper.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleScraper
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            Driver.driver = new ChromeDriver(options);
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.driver.Manage().Window.Maximize();
        }

        public static void FillUsername(string username)
        {
            LoginUserName loginUserName = new LoginUserName();

            loginUserName.UserName.SendKeys(username + Keys.Enter);
        }

        public static void FillPassword(string password)
        {
            Thread.Sleep(1000);

            LoginPassword loginPassword = new LoginPassword();

            loginPassword.Password.SendKeys(password + Keys.Enter);
        }

        public static List<StockInfo> GetStockDataFromTable()
        {
//            TestPortfolio testPortfolio = new TestPortfolio();
            MyHoldings myHoldings = new MyHoldings();

            var portfolioStockData = new List<StockInfo>();

            IList<IWebElement> rows =
                new List<IWebElement>(myHoldings.PortfolioTable.FindElements(By.TagName("tr")));
            var stockData = new List<string>();

            for (int j = 1; j < rows.Count; j++)
            {
//              Get the columns from a particular row
                List<IWebElement> lstTdElem = new List<IWebElement>(rows[j].FindElements(By.TagName("td")));
                if (lstTdElem.Count > 0)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        stockData.Add(lstTdElem[i].Text);
                    }
                }
                else
                {
                    Console.WriteLine("missing data");
                }
                
//                NavigateTo.MyHoldingsScreen();

//                IList<IWebElement> rows1 =
//                    new List<IWebElement>(myHoldings.ContentTable.FindElements(By.TagName("tr")));
//                var portfolioData = new List<string>();
//
//                for (int k = 1; k < rows.Count; j++)
//                {
////              Get the columns from a particular row
//                    List<IWebElement> lstTdElem1 = new List<IWebElement>(rows1[k].FindElements(By.TagName("td")));
//                    if (lstTdElem.Count > 0)
//                    {
//                        for (int l = 0; l < 9; l++)
//                        {
//                            portfolioData.Add(lstTdElem1[l].Text);
//                        }
//
////
//                    }
//                    else
//                    {
//                        Console.WriteLine("missing data");
//                    }

                    var symbolPrice = stockData[0].Split('\n');
                    var price = stockData[1].Split('\n');
                    var DayGain = stockData[5].Split('\n');
                    var TotalGain = stockData[6].Split('\n');
    
                    var symbol = symbolPrice[0];
                    var last_price = symbolPrice[1];
                    var price_change = price[1];
                    var price_change_percentage = price[0];
                    var shares = stockData[2];
                    var cost_basis = stockData[3];
                    var market_value = stockData[4];
                    var day_gain = DayGain[1];
                    var day_gain_percentage = DayGain[0];
                    var total_gain = TotalGain[1];
                    var total_gain_percentage = TotalGain[0];
                    var no_of_lots = stockData[7];
                    var notes = stockData[8];

                    portfolioStockData.Add(new StockInfo()
                        {
                            Symbol = symbol,
                            LastPrice = decimal.Parse(last_price),
                            PriceChange = price_change,
                            PriceChangePercentage = price_change_percentage,
                            Shares = decimal.Parse(shares),
                            CostBasis = decimal.Parse(cost_basis),
                            MarketValue = decimal.Parse(market_value),
                            DayGain = day_gain,
                            DayGainPercentage = day_gain_percentage,
                            TotalGain = total_gain,
                            TotalGainPercentage = total_gain_percentage,
                            NoOfLots = no_of_lots,
                            Notes = notes
                        }
                    );
                
                DataTable portfolioDataTable = new DataTable();


//              Print the data to the console
//              Console.WriteLine(strRowData);
//              Console.WriteLine(lstTdElem[0].Text);
//                    foreach (var variable in portfolioData)
//                    {
//                        Console.WriteLine(variable.ToString());
//                    }


//              Clear stockData
                    stockData.Clear();
                
//              Print empty line
//              Console.WriteLine(strRowData);
                }
            
                Driver.driver.Quit();
            
            return portfolioStockData;
        }
    }
}