using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace InvoiceCloudTechChallenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");

            for (int i = 0; i < 5; i++)
            {
                driver.FindElement(By.XPath("//button[contains(text(), 'Add Element')]")).Click();
            }

            try
            {
                List<IWebElement> e = new List<IWebElement>();
                e.AddRange(driver.FindElements(By.XPath("//button[contains(text(), 'Delete')]")));
                Assert.IsTrue(driver.FindElement(By.XPath("//button[contains(text(),'Delete')]")).Displayed);
                Debug.WriteLine("Assertion Passed. A total of " + e.Count + " elements were found.");

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
