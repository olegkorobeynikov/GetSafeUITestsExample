using GetSafeUITests.Infrastructure.Browser;
using OpenQA.Selenium;

namespace GetSafeUITests.Pages
{
    public abstract class Page : DriverHelper
    {
        protected Page(IWebDriver driver) : base(driver)
        {
        }
    }
}