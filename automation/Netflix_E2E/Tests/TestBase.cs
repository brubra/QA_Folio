using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Netflix_E2E.Tests
{
    [TestFixture]
    public class TestBase
    {
        protected IWebDriver driver;

        [SetUp]
        public void CreateDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void QuitDriver()
        {
            if (driver != null)
                driver.Quit();
        }

    }
}