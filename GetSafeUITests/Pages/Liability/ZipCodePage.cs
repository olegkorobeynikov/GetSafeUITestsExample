using OpenQA.Selenium;
using GetSafeUITests.Infrastructure;
using GetSafeUITests.Infrastructure.Extension;
using GetSafeUITests.Pages.Liability.PageFragments;

namespace GetSafeUITests.Pages.Liability
{
    public class ZipCodePage : Page
    {
        public static string Url = UrlConstant.Liability.Zip;
        public ZipCodePage(IWebDriver driver) : base(driver)
        {
            Footer = new Footer(driver);
        }

        private string stepContainerId = "#step_liability_zip";

        public IWebElement ZipCodeInput => Driver.TryFindElement(By.CssSelector($"{stepContainerId} #zip_code"));

        public Footer Footer { get; }
    }
}