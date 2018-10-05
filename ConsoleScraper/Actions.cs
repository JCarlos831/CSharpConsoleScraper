using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
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

        public static void GetStockDataFromTable()
        {
            TestPortfolio testPortfolio = new TestPortfolio();
            
            IList<IWebElement> rows = new List<IWebElement>(testPortfolio.PortfolioTable.FindElements(By.TagName("tr")));
            String strRowData = "";
            
            for (int j = 1; j < rows.Count; j++)
            {
                // Get the columns from a particular row
                List<IWebElement> lstTdElem = new List<IWebElement>(rows[j].FindElements(By.TagName("td")));
                if (lstTdElem.Count > 0)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        strRowData = strRowData + lstTdElem[i].Text + ",";
                    }
                }
                else
                {
                    // To print the data into the console and add comma between text
                    Console.WriteLine(rows[0].Text.Replace(" ", ","));
                }

                // Print the data to the console
                // Console.WriteLine(strRowData);
                Console.WriteLine(lstTdElem[0].Text);

                
                // Clear strRowData
                strRowData = String.Empty;
                
                // Print empty line
                Console.WriteLine(strRowData);
            }
            
            Driver.driver.Quit();  
        }
    }
}