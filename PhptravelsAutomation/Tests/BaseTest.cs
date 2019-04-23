using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PhptravelsAutomation.Context;
using PhptravelsAutomation.Pages;

namespace PhptravelsAutomation.Tests
{
    [TestFixture]
    public class BaseTest
    {

        [OneTimeSetUp]
        public void GeneralSetUp()
        {
            DriverContext.Driver = new ChromeDriver();
            DriverContext.Driver.Navigate().GoToUrl("https://www.phptravels.net/m-hotels");
            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void LoginWithValidCredentials()
        {
            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homePage.AccountDropDown.Click();
            homePage.LoginLink.Click();
            loginPage.Login("user@phptravels.com", "demouser");
        }

        [OneTimeTearDown]
        public void Clearup()
        {
           DriverContext.Driver.Quit();
        }
    }
}
