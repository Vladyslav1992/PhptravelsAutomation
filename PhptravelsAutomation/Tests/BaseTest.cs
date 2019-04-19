using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PhptravelsAutomation.Pages;

namespace PhptravelsAutomation.Tests
{
    class BaseTest
    {
        public IWebDriver Driver { get; set; } = new ChromeDriver();

        [OneTimeSetUp]
        public void GeneralSetUp()
        {
            Driver.Navigate().GoToUrl("https://www.phptravels.net/account/");
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void LoginWithValidCredentials()
        {
            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homePage.LoginLink.Click();
            loginPage.Login("user@phptravels.com", "demouser");
        }

        [OneTimeTearDown]
        public void Clearup()
        {
            Driver.Quit();
        }
    }
}
