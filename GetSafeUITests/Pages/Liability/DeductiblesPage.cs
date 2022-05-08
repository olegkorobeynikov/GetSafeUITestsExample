using OpenQA.Selenium;
using GetSafeUITests.Infrastructure;
using GetSafeUITests.Infrastructure.Extension;
using GetSafeUITests.Pages.Liability.PageFragments;

namespace GetSafeUITests.Pages.Liability
{
    public class DeductiblesPage : Page
    {
        public static string Url = UrlConstant.Liability.Deductibles;
        private readonly string stepContainerId = "#step_liability_deductibles";

        public DeductiblesPage(IWebDriver driver) : base(driver)
        {
            Footer = new Footer(driver);
        }

        public Footer Footer { get; }

        public IWebElement Excess0Button =>
            Driver.TryFindElement(By.CssSelector($"{stepContainerId} #select-list-button-0"));

        public IWebElement Excess150Button =>
            Driver.TryFindElement(By.CssSelector($"{stepContainerId} #select-list-button-150"));

        public IWebElement Excess300Button =>
            Driver.TryFindElement(By.CssSelector($"{stepContainerId} #select-list-button-300"));
    }
}