using OpenQA.Selenium;
using GetSafeUITests.Controls;
using GetSafeUITests.Infrastructure;
using GetSafeUITests.Infrastructure.Extension;
using GetSafeUITests.Pages.Liability.PageFragments;

namespace GetSafeUITests.Pages.Liability
{
    public class LiabilityPage : Page
    {
        public static string Url = UrlConstant.Liability.Main;
        private readonly string stepContainerId = "#step_login_is_existing_user";

        public LiabilityPage(IWebDriver driver) : base(driver)
        {
            Footer = new Footer(driver);
            Spinner = new Spinner(driver, By.ClassName("spinner"));
        }

        public Footer Footer { get; }
        public Spinner Spinner { get; }

        public IWebElement NoButton =>
            Driver.TryFindElement(By.CssSelector($"{stepContainerId} #select-list-button-false"));

        public IWebElement YesButton =>
            Driver.TryFindElement(By.CssSelector($"{stepContainerId} #select-list-button-true"));
    }
}