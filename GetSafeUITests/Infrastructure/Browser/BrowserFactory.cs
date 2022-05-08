using System;
using System.Drawing;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GetSafeUITests.Infrastructure.Browser
{
    internal static class BrowserFactory
    {
        public static WebDriver TryCreateWebDriver(ILog log)
        {
            try
            {
                return CreateChromeDriver();
            }
            catch (Exception e)
            {
                log.Warn($"Error occurred while creating webDriver, message={e.Message}");
            }

            return null;
        }

        private static WebDriver CreateChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArguments("--start-maximized", "--disable-extensions");
            var webDriver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options);
            webDriver.Manage().Window.Size = new Size { Width = 1280, Height = 768 };
            
            return webDriver;
        }
    }
}