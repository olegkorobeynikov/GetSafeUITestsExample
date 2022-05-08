using OpenQA.Selenium;
using GetSafeUITests.Infrastructure;
using GetSafeUITests.Infrastructure.Extension;
using GetSafeUITests.Pages.Liability.PageFragments;

namespace GetSafeUITests.Pages.Liability
{
    public class FamilyPage : Page
    {
        public static string Url = UrlConstant.Liability.Family;
        private readonly string stepContainerId = "#step_liability_family";

        public FamilyPage(IWebDriver driver) : base(driver)
        {
            Footer = new Footer(driver);
        }

        public Footer Footer { get; }

        public IWebElement OnlyMeButton =>
            Driver.TryFindElement(By.CssSelector($"{stepContainerId} #select-list-button-false"));

        public IWebElement MyFamilyButton =>
            Driver.TryFindElement(By.CssSelector($"{stepContainerId} #select-list-button-true"));
    }
}