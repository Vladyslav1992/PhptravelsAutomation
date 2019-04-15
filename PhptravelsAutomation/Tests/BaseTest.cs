using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

        [OneTimeTearDown]
        public void Clearup()
        {
            Driver.Quit();
        }
    }
}
