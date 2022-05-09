using GetSafeUITests.Infrastructure;
using GetSafeUITests.Infrastructure.Extension;
using GetSafeUITests.Pages.Liability.PageFragments;
using OpenQA.Selenium;

namespace GetSafeUITests.Pages.Liability
{
    public class DeductiblesPage : Page
    {
        private const string StepContainerId = "#step_liability_deductibles";
        public static string Url = UrlConstant.Liability.Deductibles;

        public DeductiblesPage(IWebDriver driver) : base(driver)
        {
            Footer = new Footer(driver);
        }

        public Footer Footer { get; }

        public IWebElement Excess0Button =>
            Driver.TryFindElement(By.CssSelector($"{StepContainerId} #select-list-button-0"));

        public IWebElement Excess150Button =>
            Driver.TryFindElement(By.CssSelector($"{StepContainerId} #select-list-button-150"));

        public IWebElement Excess300Button =>
            Driver.TryFindElement(By.CssSelector($"{StepContainerId} #select-list-button-300"));
    }
}