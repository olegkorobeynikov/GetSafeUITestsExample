using GetSafeUITests.Infrastructure;
using GetSafeUITests.Infrastructure.Extension;
using GetSafeUITests.Pages.Liability.PageFragments;
using OpenQA.Selenium;

namespace GetSafeUITests.Pages.Liability
{
    public class ZipCodePage : Page
    {
        public static string Url = UrlConstant.Liability.Zip;
        private readonly string StepContainerId = "#step_liability_zip";

        public ZipCodePage(IWebDriver driver) : base(driver)
        {
            Footer = new Footer(driver);
        }

        public IWebElement ZipCodeInput => Driver.TryFindElement(By.CssSelector($"{StepContainerId} #zip_code"));

        public Footer Footer { get; }
    }
}