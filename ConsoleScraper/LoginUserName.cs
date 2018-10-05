using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ConsoleScraper
{
    public class LoginUserName
    {
        public LoginUserName()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        
        [FindsBy(How = How.Id, Using = "login-username")]
        public IWebElement UserName { get; set; }
    }
}