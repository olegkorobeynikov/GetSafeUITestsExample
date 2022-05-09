using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GetSafeUITests.Controls
{
    public class Spinner
    {
        private readonly By By;
        private readonly IWebDriver Driver;

        public Spinner(IWebDriver driver, By by)
        {
            Driver = driver;
            By = by;
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
                        return !Driver.FindElement(By).Displayed;
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