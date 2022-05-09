using GetSafeUITests.Infrastructure;
using GetSafeUITests.Infrastructure.Extension;
using GetSafeUITests.Pages.Liability.PageFragments;
using OpenQA.Selenium;

namespace GetSafeUITests.Pages.Liability
{
    public class FamilyPage : Page
    {
        private const string StepContainerId = "#step_liability_family";
        public static string Url = UrlConstant.Liability.Family;

        public FamilyPage(IWebDriver driver) : base(driver)
        {
            Footer = new Footer(driver);
        }

        public Footer Footer { get; }

        public IWebElement OnlyMeButton =>
            Driver.TryFindElement(By.CssSelector($"{StepContainerId} #select-list-button-false"));

        public IWebElement MyFamilyButton =>
            Driver.TryFindElement(By.CssSelector($"{StepContainerId} #select-list-button-true"));
    }
}