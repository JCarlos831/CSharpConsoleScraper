using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ConsoleScraper
{
    public class YFinanceNavBar
    {
        public YFinanceNavBar()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"Nav-0-DesktopNav\"]/div/div[1]/div/a")]
        public IWebElement FinanceHome { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"Nav-0-DesktopNav\"]/div/div[3]/div/div[1]/ul/li[1]/a")]
        public IWebElement Watchlist { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"Nav-0-DesktopNav\"]/div/div[3]/div/div[1]/ul/li[2]/a")]
        public IWebElement MyPortfolio { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"Nav-0-DesktopNav\"]/div/div[3]/div/div[1]/ul/li[3]/a")]
        public IWebElement MyScreeners { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"Nav-0-DesktopNav\"]/div/div[3]/div/div[1]/ul/li[4]/a")]
        public IWebElement Markets { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"Nav-0-DesktopNav\"]/div/div[3]/div/div[1]/ul/li[5]/a")]
        public IWebElement Industries { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"Nav-0-DesktopNav\"]/div/div[3]/div/div[1]/ul/li[6]/a")]
        public IWebElement PersonalFinance { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"Nav-0-DesktopNav\"]/div/div[3]/div/div[1]/ul/li[7]/a")]
        public IWebElement Tech { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"Nav-0-DesktopNav\"]/div/div[3]/div/div[2]/div/svg")]
        public IWebElement More { get; set; }
    }
}