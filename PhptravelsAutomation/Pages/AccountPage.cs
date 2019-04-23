using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PhptravelsAutomation.Pages
{
    public class AccountPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "a[href$='bookings']")]
        public IWebDriver BookingsTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href$='profile']")]
        public IWebDriver MyProfileTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href$='wishlist']")]
        public IWebDriver WishListTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href$='newsletter']")]
        public IWebDriver NewsLetterTab { get; set; }

        [FindsBy(How = How.Id, Using = "txt")]
        public IWebDriver CurrentTime { get; set; }

        [FindsBy(How = How.CssSelector, Using = "*[class = 'RTL']")]
        public IWebDriver Greetingtext{ get; set; }

        public class MyProfile
        {
            [FindsBy(How = How.Name, Using = "firstname")]
            public IWebDriver FirstName { get; set; }

            [FindsBy(How = How.Name, Using = "lastname")]
            public IWebDriver LastName { get; set; }

            [FindsBy(How = How.Name, Using = "phone")]
            public IWebDriver Phone { get; set; }

            [FindsBy(How = How.XPath, Using = "//input[@name = 'email' and @type = 'text']")]
            public IWebDriver Email { get; set; }
        }
    }
}
