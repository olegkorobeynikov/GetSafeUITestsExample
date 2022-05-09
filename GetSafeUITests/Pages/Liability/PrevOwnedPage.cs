using GetSafeUITests.Infrastructure;
using GetSafeUITests.Infrastructure.Extension;
using GetSafeUITests.Pages.Liability.PageFragments;
using OpenQA.Selenium;

namespace GetSafeUITests.Pages.Liability
{
    public class PrevOwnedPage : Page
    {
        private const string StepContainerId = "#step_liability_previously_owned";
        public static string Url = UrlConstant.Liability.PrevOwner;

        public PrevOwnedPage(IWebDriver driver) : base(driver)
        {
            Footer = new Footer(driver);
        }

        public Footer Footer { get; }

        public IWebElement NoButton =>
            Driver.TryFindElement(By.CssSelector($"{StepContainerId} #select-list-button-false"));

        public IWebElement YesButton =>
            Driver.TryFindElement(By.CssSelector($"{StepContainerId} #select-list-button-true"));
    }
}