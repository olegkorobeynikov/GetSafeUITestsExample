using GetSafeUITests.Infrastructure;
using GetSafeUITests.Infrastructure.Extension;
using OpenQA.Selenium;

namespace GetSafeUITests.Pages.Liability
{
    public class QuoteStepPage : Page
    {
        public static string Url = UrlConstant.Liability.QuoteStep;

        public QuoteStepPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement QuoteHeaderPrice => Driver.TryFindElement(By.CssSelector("#QuoteHeaderPrice"));

        public IWebElement ComfortPlanButton =>
            Driver.TryFindElement(By.CssSelector("#radio-cardset-button-liability_v1_1_getsafe_de_comfort_plan"));

        public IWebElement DronOptionsToggle => Driver.TryFindElement(
            By.CssSelector("#products-liability_v1_getsafe_de-configuration_parameters-drones_coverage-Switch"));

        public IWebElement FamilyCoverageToggle => Driver.TryFindElement(
            By.CssSelector("#products-liability_v1_getsafe_de-configuration_parameters-family_coverage-Switch"));
    }
}