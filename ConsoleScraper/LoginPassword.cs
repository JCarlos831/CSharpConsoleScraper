using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ConsoleScraper
{
    public class LoginPassword
    {
        public LoginPassword()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        
        [FindsBy(How = How.Id, Using = "login-passwd")]
        public IWebElement Password { get; set; }
    }
}