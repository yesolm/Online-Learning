using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace OL.IntegrationTests
{
    [TestClass]
    public class IndexPageTests : IDisposable
    {
        private readonly IWebDriver _driver;
        public IndexPageTests()
        {
            var options = new ChromeOptions();
            options.AddArgument("headless");
            _driver = new ChromeDriver(options);
            _driver.Navigate().GoToUrl("https://localhost:7247/");
        }

        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(_driver.Title, "Learn Online");
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}