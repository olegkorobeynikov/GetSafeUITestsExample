using System;
using GetSafeUITests.Infrastructure.Browser;

namespace GetSafeUITests.Infrastructure
{
    public class TestSettings
    {
        public static readonly WebDriverType WebDriverType = WebDriverType.Chrome;
        public static readonly TimeSpan BrowserTimeout = TimeSpan.FromSeconds(180);
    }
}