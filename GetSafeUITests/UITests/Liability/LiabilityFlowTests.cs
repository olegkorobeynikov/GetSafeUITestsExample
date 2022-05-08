using FluentAssertions;
using GetSafeUITests.Infrastructure;
using GetSafeUITests.Pages.Liability;
using NUnit.Framework;

namespace GetSafeUITests.UITests.Liability
{
    [TestFixture]
    public class LiabilityFlowTests : TestBase
    {
        [Test]
        public void Should_calculate_correct_sum_when_passed_liability_flow_and_add_family_coverage_and_comfort_plan()
        {
            Driver.Navigate().GoToUrl(LiabilityPage.Url);
            var liabilityPage = new LiabilityPage(Driver);
            liabilityPage.Spinner.WaitWhileLoading();
            liabilityPage.NoButton.Click();

            var familyPage = new FamilyPage(Driver);
            familyPage.OnlyMeButton.Click();

            var zipCodePage = new ZipCodePage(Driver);
            var validZipCode = "14467";
            zipCodePage.ZipCodeInput.SendKeys(validZipCode);
            zipCodePage.Footer.ContinueButton.Click();

            var deductiblesPage = new DeductiblesPage(Driver);
            deductiblesPage.Excess0Button.Click();

            var prevOwnedPage = new PrevOwnedPage(Driver);
            prevOwnedPage.NoButton.Click();

            var dronePage = new DronePage(Driver);
            dronePage.NoButton.Click();

            var quoteStepPage = new QuoteStepPage(Driver);
            quoteStepPage.ComfortPlanButton.Click();
            quoteStepPage.FamilyCoverageToggle.Click();

            var expectedPrice = "€3.40";
            quoteStepPage.QuoteHeaderPrice.Text.Should().Be(expectedPrice);
        }
    }
}