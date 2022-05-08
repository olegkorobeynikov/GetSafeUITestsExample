using OpenQA.Selenium;

namespace GetSafeUITests.Infrastructure.Browser
{
    public class DriverHelper
    {
        protected readonly IWebDriver Driver;

        protected DriverHelper(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}