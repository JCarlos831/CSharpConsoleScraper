using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ConsoleScraper
{
    public class MyHoldings
    {
        public MyHoldings()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        
        [FindsBy(How = How.ClassName, Using = "tJDbU")]
        public IWebElement PortfolioTable { get; set; }
    }
}