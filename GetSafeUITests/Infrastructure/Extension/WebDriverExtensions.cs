using System;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GetSafeUITests.Infrastructure.Extension
{
    public static class WebDriverExtensions
    {
        public static IWebElement TryFindElement(this IWebDriver driver, By by, int timeoutInSeconds = 5)
        {
            if (timeoutInSeconds <= 0) return driver.FindElement(by);

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(drv =>
            {
                {
                    var elem = drv.FindElement(@by);
                    if (!elem.Displayed)
                        return null;

                    return elem;
                }
            });

        }

        public static void IsUrlContain(this IWebDriver driver, string expectedValue, string message = null) =>
            driver.Url.Should().Contain(expectedValue, message);
    }

}