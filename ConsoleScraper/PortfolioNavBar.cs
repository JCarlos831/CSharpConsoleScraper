using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ConsoleScraper
{
    public class PortfolioNavBar
    {
        public PortfolioNavBar()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main\"]/section/section[1]/ul/li[1]/a")]
        public IWebElement Summary { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main\"]/section/section[1]/ul/li[2]/a")]
        public IWebElement MyHoldings { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main\"]/section/section[1]/ul/li[3]/a")]
        public IWebElement Fundamentals { get; set; }
    }
}