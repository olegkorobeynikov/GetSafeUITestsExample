using OpenQA.Selenium;
using GetSafeUITests.Infrastructure;
using GetSafeUITests.Infrastructure.Extension;
using GetSafeUITests.Pages.Liability.PageFragments;

namespace GetSafeUITests.Pages.Liability
{
    public class DronePage : Page
    {
        public static string Url = UrlConstant.Liability.Drone;
        private readonly string stepContainerId = "#step_liability_drone";

        public DronePage(IWebDriver driver) : base(driver)
        {
            Footer = new Footer(driver);
        }

        public Footer Footer { get; }

        public IWebElement NoButton =>
            Driver.TryFindElement(By.CssSelector($"{stepContainerId} #select-list-button-false"));

        public IWebElement YesButton =>
            Driver.TryFindElement(By.CssSelector($"{stepContainerId} #select-list-button-true"));
    }
}