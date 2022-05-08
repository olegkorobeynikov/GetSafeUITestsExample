using System;
using System.Drawing;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace GetSafeUITests.Infrastructure.Browser
{
    internal class BrowserFactory
    {
        public static WebDriver TryCreateWebDriver(ILog log, WebDriverType webDriverType,
            int countAttempts = 3)
        {
            for (var i = 0; i < countAttempts; i++)
                try
                {
                    return CreateWebDriver(webDriverType);
                }
                catch (InvalidOperationException e) when (e.Message.Contains("session not created exception"))
                {
                    log.Warn($"Error occurred while creating {webDriverType} webDriver, message={e.Message}");
                }

            return null;
        }

        private static WebDriver CreateWebDriver(WebDriverType browserType)
        {
            WebDriver webDriver;
            switch (browserType)
            {
                case WebDriverType.Chrome:
                    webDriver = CreateChromeDriver();
                    break;
                case WebDriverType.FireFox:
                    webDriver = CreateFirefoxWebDriver();
                    break;
                default:
                    throw new Exception($"Browser type {browserType} is not supported. Supported: Chrome or FireFox.");
            }

            webDriver.Manage().Window.Size = new Size { Width = 1144, Height = 768 };
            return webDriver;
        }

        private static WebDriver CreateChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArguments("--no-sandbox", "--start-maximized", "--disable-extensions");

            return new ChromeDriver(
                ChromeDriverService.CreateDefaultService(),
                options,
                TestSettings.BrowserTimeout);
        }

        private static WebDriver CreateFirefoxWebDriver()
        {
            var options = new FirefoxOptions();
            options.AddArguments("--start-maximized", "--disable-extensions");

            return new FirefoxDriver(
                FirefoxDriverService.CreateDefaultService(),
                options,
                TestSettings.BrowserTimeout);
        }
    }
}