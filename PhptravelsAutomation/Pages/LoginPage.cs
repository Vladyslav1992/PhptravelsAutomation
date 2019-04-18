using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PhptravelsAutomation.Pages
{
    class LoginPage : BasePage
    {
        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn-lg")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='alert alert-danger']")]
        public IWebElement ErrorAlert { get; set; }
    }
}
