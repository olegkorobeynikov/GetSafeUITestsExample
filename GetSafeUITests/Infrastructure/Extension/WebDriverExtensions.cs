using System;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GetSafeUITests.Infrastructure.Extension
{
    public static class WebDriverExtensions
    {
        public static IWebElement TryFindElement(this IWebDriver driver, By by, int timeoutInSeconds = 10)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv =>
                {
                    {
                        var elem = drv.FindElement(by);
                        if (!elem.Displayed)
                            return null;

                        return elem;
                    }
                });
            }

            return driver.FindElement(by);
        }
        public static void ShouldUrlContain(this IWebDriver driver, string expectedValue, string message = null) =>
            driver.Url.Should().Contain(expectedValue, message);
    }

}