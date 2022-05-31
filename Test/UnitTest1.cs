using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {

        IWebDriver driver = new ChromeDriver();


        [TestMethod]
        public void OpenUrl()
        {
            driver.Navigate().GoToUrl("https://tifis.qpharmasit.com");
        }
    }
}
