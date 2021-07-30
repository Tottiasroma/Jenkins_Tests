using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests_For_Jenkins
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
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
