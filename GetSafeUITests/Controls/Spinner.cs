using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using GetSafeUITests.Infrastructure.Extension;

namespace GetSafeUITests.Controls
{
    public class Spinner
    {
        private readonly IWebDriver Driver;
        private readonly By Selector;

        public Spinner(IWebDriver driver, By by)
        {
            Driver = driver;
            Selector = by;
        }

        public IWebElement Element()
        {
            return Driver.TryFindElement(Selector);
        }

        public void WaitWhileLoading(int timeoutInSeconds = 10)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until(condition =>
                {
                    try
                    {
                        return !Driver.FindElement(Selector).Displayed;
                    }
                    catch (StaleElementReferenceException)
                    {
                        return true;
                    }
                    catch (NoSuchElementException)
                    {
                        return true;
                    }
                });
            }
        }
    }
}