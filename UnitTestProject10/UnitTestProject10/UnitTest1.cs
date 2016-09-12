using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Threading;

namespace UnitTestProject10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://stackoverflow.com/questions/7347494/selenium-webdriver-geturl-does-not-open-the-url");



            Thread.Sleep(2000);

            driver.Quit();
        }
    }
}
