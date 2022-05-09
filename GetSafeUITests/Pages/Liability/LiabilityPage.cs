using GetSafeUITests.Controls;
using GetSafeUITests.Infrastructure;
using GetSafeUITests.Infrastructure.Extension;
using GetSafeUITests.Pages.Liability.PageFragments;
using OpenQA.Selenium;

namespace GetSafeUITests.Pages.Liability
{
    public class LiabilityPage : Page
    {
        private const string StepContainerId = "#step_login_is_existing_user";
        public static string Url = UrlConstant.Liability.Main;

        public LiabilityPage(IWebDriver driver) : base(driver)
        {
            Footer = new Footer(driver);
            Spinner = new Spinner(driver, By.ClassName("spinner"));
        }

        public Footer Footer { get; }
        public Spinner Spinner { get; }

        public IWebElement NoButton =>
            Driver.TryFindElement(By.CssSelector($"{StepContainerId} #select-list-button-false"));

        public IWebElement YesButton =>
            Driver.TryFindElement(By.CssSelector($"{StepContainerId} #select-list-button-true"));
    }
}