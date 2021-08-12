
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Tests_For_Jenkins
{
    public class TestClass : Hooks
    {
        [Test]
        public void Test1()
        {
            //Open Habr Page

            Driver.Navigate().GoToUrl("http://habr.com/");

            Assert.IsTrue(Driver.Url.Contains("habr.com"), "Что-то не так =(");
        }
    }
}
