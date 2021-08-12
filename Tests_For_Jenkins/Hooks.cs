using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace Tests_For_Jenkins
{
    public class Hooks : BaseTest
    {
        private BrowserType _browserType;

        [SetUp]
        public void InitializeTest()
        {
            var browserType = TestContext.Parameters.Get("Browser", "Firefox");

            _browserType = (BrowserType)Enum.Parse(typeof(BrowserType), browserType);

            ChooseDriverInstance(_browserType);
        }

        private void ChooseDriverInstance(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
            {
                Driver = new ChromeDriver();
            }
            else 
            {
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
                service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                service.HideCommandPromptWindow = true;
                service.SuppressInitialDiagnosticInformation = true;
                Driver = new FirefoxDriver(service);
            }
        }

        [TearDown]
        public void TearDown() 
        {
            Driver.Quit();
        }
    }
}
