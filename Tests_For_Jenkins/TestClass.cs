
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Assert = NUnit.Framework.Assert;

namespace Tests_For_Jenkins
{
    public class TestClass
    {
        [Test]
        public void Test1()
        {
            //Open Habr Page

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://habr.com/");

            Assert.IsTrue(driver.Url.Contains("habr.com"), "Что-то не так =(");

            driver.Quit();
        }
    }
}
