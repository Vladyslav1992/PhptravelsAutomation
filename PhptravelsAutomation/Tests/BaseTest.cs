using System;
using System.Threading;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PhptravelsAutomation.Context;
using PhptravelsAutomation.Helpers;
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
            DriverContext.Driver.Navigate().GoToUrl(ConfigurationHelper.GetHomeUrl());
            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void LoginWithValidCredentials()
        {
            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();
            AccountPage accountPage = new AccountPage();
            AccountPage.MyProfile myProfile = new AccountPage.MyProfile();

            homePage.AccountDropDown.Click();
            homePage.LoginLink.Click();
            loginPage.Login("user@phptravels.com", "demouser");
            accountPage.MyProfileTab.Click();
            var firstName = myProfile.FirstName.GetAttribute("value");
            firstName.Should().BeEquivalentTo("JOhny");
        }

        [OneTimeTearDown]
        public void Clearup()
        {
           DriverContext.Driver.Quit();
        }
    }
}
