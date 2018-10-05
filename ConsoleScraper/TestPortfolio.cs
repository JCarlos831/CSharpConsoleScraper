using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ConsoleScraper
{
    public class TestPortfolio
    {
        public TestPortfolio()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        
        [FindsBy(How = How.ClassName, Using = "_1TagL")]
        public IWebElement PortfolioTable { get; set; }
    }
}