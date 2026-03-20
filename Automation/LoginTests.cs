using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SauceDemoAutomation
{
    public class LoginTests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        [Test]
        public void SuccessfulLoginTest()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

        [TearDown]
        public void Close() => driver.Quit();
    }
}
