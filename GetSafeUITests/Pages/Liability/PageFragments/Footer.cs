using OpenQA.Selenium;
using GetSafeUITests.Infrastructure.Extension;

namespace GetSafeUITests.Pages.Liability.PageFragments
{
    public class Footer
    {
        private readonly IWebDriver Driver;

        public Footer(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement ContinueButton =>
            Driver.TryFindElement(By.CssSelector("Button[data-test-id='proceed_button']"));

        public IWebElement BackButton =>
            Driver.TryFindElement(By.CssSelector("Button[data-test-id='stepback_button']"));
    }
}