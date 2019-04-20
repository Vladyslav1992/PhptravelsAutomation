using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PhptravelsAutomation.Pages
{
    class LoginPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Email']")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn-lg")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='alert alert-danger']")]
        public IWebElement ErrorAlert { get; set; }

        public void Login(params string[] credentials)
        {
            EmailField.Clear();
            EmailField.SendKeys(credentials.First());
            PasswordField.Clear();
            PasswordField.SendKeys(credentials.Last());
            LoginButton.Click();
        }
    }
}
