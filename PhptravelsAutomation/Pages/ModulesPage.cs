using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PhptravelsAutomation.Pages
{
    class ModulesPage
    {
        [FindsBy(How = How.CssSelector, Using = "a[href$='.net']")]
        public IWebElement HomePageLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(., 'user') and @class='col-md-8']")]
        public IWebElement UserCredentials { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href$='admin']")]
        public IWebElement AdminPageLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(., 'admin') and @class='col-md-8']")]
        public IWebElement AdminCredentials { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href$='.supplier']")]
        public IWebElement SupplierPageLink { get; set; }

        [FindsBy(How = How.XPath, Using = "div[contains(., 'supplier') and @class='col-md-8']")]
        public IWebElement SupplierCredentials { get; set; }
    }
}
