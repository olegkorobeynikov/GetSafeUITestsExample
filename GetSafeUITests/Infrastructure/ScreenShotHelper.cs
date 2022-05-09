using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;

namespace GetSafeUITests.Infrastructure
{
    public static class ScreenShotHelper
    {
        private const string PngSuf = ".png";

        public static void SaveScreenShot(string testName, Screenshot image)
        {
            var directory = GetScreenShotsDirectory();
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            var fullname = Path.Combine(directory, GenerateScreenShotName(testName));
            var maxLengthPathWindows = 259;
            if (fullname.Length > maxLengthPathWindows)
                fullname = fullname.Remove(maxLengthPathWindows - PngSuf.Length, fullname.Length - maxLengthPathWindows);
            image.SaveAsFile(fullname);
        }

        private static string GenerateScreenShotName(string testName)
        {
            return $"{DateTime.Now:yyyy.MM.dd-HH.mm.ss}-{testName}-No{Guid.NewGuid().ToString().Substring(0, 3)}{Guid.NewGuid()}{Guid.NewGuid()}{Guid.NewGuid()}{Guid.NewGuid()}{PngSuf}";
        }

        private static string GetScreenShotsDirectory()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            var path = Path.GetDirectoryName(location);
            return Path.Combine(path, "ScreenShots");
        }
    }
}