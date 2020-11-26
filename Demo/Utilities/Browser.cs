using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;

namespace Demo.Utilities
{
    public class Browser
    {
        public static ChromeDriver Driver { get; set; }

        public static ChromeDriver Start()
        {
            var options = new ChromeOptions();
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("incognito");

            Driver = new ChromeDriver(options);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return Driver;
        }

        public static void Stop()
        {
            if (Driver != null)
                Driver.Quit();
        }

        public static void KillChromeProcesses()
        {
            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");
            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }
        }
    }
}
