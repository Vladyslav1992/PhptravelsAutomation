using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PhptravelsAutomation.Pages
{
    public class AccountPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "a[href$='bookings']")]
        public IWebElement BookingsTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href$='profile']")]
        public IWebElement MyProfileTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href$='wishlist']")]
        public IWebElement WishListTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href$='newsletter']")]
        public IWebElement NewsLetterTab { get; set; }

        [FindsBy(How = How.Id, Using = "txt")]
        public IWebElement CurrentTime { get; set; }

        [FindsBy(How = How.CssSelector, Using = "*[class = 'RTL']")]
        public IWebElement Greetingtext { get; set; }

        public class MyProfile : AccountPage
        {
            [FindsBy(How = How.Name, Using = "firstname")]
            public IWebElement FirstName { get; set; }

            [FindsBy(How = How.Name, Using = "lastname")]
            public IWebElement LastName { get; set; }

            [FindsBy(How = How.Name, Using = "phone")]
            public IWebElement Phone { get; set; }

            [FindsBy(How = How.XPath, Using = "//input[@name = 'email' and @type = 'text']")]
            public IWebElement Email { get; set; }
        }
    }
}
