using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ConsoleScraper
{
    public class MyPortfolios
    {
        public MyPortfolios()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main\"]/section/section/div[2]/table/tbody/tr[1]/td[1]/a")]
        public IWebElement Test { get; set; }
                
        [FindsBy(How = How.XPath, Using = "//*[@id=\"fin-tradeit\"]/div[2]/div/div/div[2]/button[2]")]
        public IWebElement CloseBox { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main\"]/section/section/div[2]/table/tbody/tr[2]/td[1]/a")]
        public IWebElement MyWatchlist { get; set; }
    }
}