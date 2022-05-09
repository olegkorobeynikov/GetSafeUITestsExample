using System;
using System.Reflection;
using GetSafeUITests.Infrastructure.Browser;
using log4net;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace GetSafeUITests.Infrastructure
{
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    public class TestBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod()?.DeclaringType);
        internal IWebDriver Driver;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
        }

        [SetUp]
        public void SetUp()
        {
            Driver = BrowserFactory.TryCreateWebDriver(Log);
            AcceptCookie();
        }

        private void AcceptCookie()
        {
            Driver.Navigate().GoToUrl(UrlConstant.StartHelloGetSafe);
            Driver.Manage().Cookies.AddCookie(new Cookie("OptanonAlertBoxClosed", domain: ".hellogetsafe.com",
                value: DateTime.Now.AddHours(-1).ToLongDateString(), path: "/", expiry: DateTime.Now.AddDays(1)));
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                SaveScreenShot();
                var logStr =
                    $"Test {TestContext.CurrentContext.Test.Name} Failed, because: {TestContext.CurrentContext.Result.Message}";
                Log.Warn(logStr);
            }

            Driver.Dispose();
        }

        private void SaveScreenShot()
        {
            var ss = (ITakesScreenshot)Driver;
            var image = ss.GetScreenshot();
            var testName = TestContext.CurrentContext.Test.FullName;
            try
            {
                ScreenShotHelper.SaveScreenShot(testName, image);
            }
            catch (Exception e)
            {
                Log.Warn($"Does not save screenShot because: {e}");
            }
        }
    }
}