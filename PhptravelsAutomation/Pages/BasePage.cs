using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PhptravelsAutomation.Pages
{
    public abstract class BasePage
    {
        //HEADER
        [FindsBy(How = How.XPath, Using = "(//li[@id='li_myaccount'])[2]")]
        public IWebElement AccountDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='ink animate']/../..//a[contains(@href, 'login')]")]
        public IWebElement LoginLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='ink animate']/../..//a[contains(@href, 'register')]")]
        public IWebElement SignUpLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='ink animate']/../..//a[contains(text(), 'Account')]")]
        public IWebElement AccountLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='ink animate']/../..//a[contains(@href, 'logout')]")]
        public IWebElement LogoutLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href$='blog']")]
        public IWebElement Blog { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href$='offers']")]
        public IWebElement Offers { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href$='hotels']")]
        public IWebElement Hotels { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href$='flights']")]
        public IWebElement Flights { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href$='tours']")]
        public IWebElement Tours { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href$='cars']")]
        public IWebElement Cars { get; set; }
    }
}
