using System;
using System.Threading;

using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace CIMB_Test_Auto.HelperClass
{
    class ElementsHelper
    {
        public static string TestCaseName = "null";
        public static string CurrentURL = "null";
        public static string lastScreenshotPath = "null";
        public static int GetNumberOfElement(string xpath)
        {
            Console.WriteLine();
            Console.WriteLine("~~");
            Console.WriteLine("GetNumberOfElement");
            Console.WriteLine("xpath: "+ xpath);
            int elemCount = HelperClass.DriverEngine.driver.FindElements(By.XPath(xpath)).Count;
            Console.WriteLine("~~");
            Console.WriteLine();
            return elemCount;
        }

        public static void ClickIfExist(string xpath)
        {
            Console.WriteLine();
            Console.WriteLine("~~");
            Console.WriteLine("ClickIfExist");
            Console.WriteLine("xpath: " + xpath);
            Thread.Sleep(3000);
            int elemCount = HelperClass.DriverEngine.driver.FindElements(By.XPath(xpath)).Count;
            if (elemCount > 0)
            {
                WebDriverWait wait = new WebDriverWait(HelperClass.DriverEngine.driver, TimeSpan.FromSeconds(15));
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpath)));
                HelperClass.DriverEngine.driver.FindElement(By.XPath(xpath)).Click();

            }
            Console.WriteLine("~~");
            Console.WriteLine();
        }
        public static void ClickElement(string xpath)
        {
            Console.WriteLine();
            Console.WriteLine("~~");
            Console.WriteLine("ClickElement");
            Console.WriteLine("xpath: " + xpath);
            WebDriverWait wait = new WebDriverWait(HelperClass.DriverEngine.driver, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpath)));
            HelperClass.DriverEngine.driver.FindElement(By.XPath(xpath)).Click();
            Console.WriteLine("~~");
            Console.WriteLine();

        }
        public static void VerifyElementIsDisplayed(string xpath)
        {
            Console.WriteLine();
            Console.WriteLine("~~");
            Console.WriteLine("VerifyElementIsDisplayed");
            Console.WriteLine("xpath: " + xpath);
            WebDriverWait wait = new WebDriverWait(HelperClass.DriverEngine.driver, TimeSpan.FromSeconds(15));
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            Console.WriteLine("~~");
            Console.WriteLine();

        }

        public static void ClearInput(string xpath)
        {
            Console.WriteLine();
            Console.WriteLine("~~");
            Console.WriteLine("ClearInput");
            Console.WriteLine("xpath: " + xpath);
            WebDriverWait wait = new WebDriverWait(HelperClass.DriverEngine.driver, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpath)));
            HelperClass.DriverEngine.driver.FindElement(By.XPath(xpath)).Clear();
            Console.WriteLine("~~");
            Console.WriteLine();

        }
        public static void EnterSearchInput(string xpath, string input)
        {
            Console.WriteLine();
            Console.WriteLine("~~");
            Console.WriteLine("EnterSearchInput");
            Console.WriteLine("xpath: " + xpath);
            Console.WriteLine("input: " + input);
            WebDriverWait wait = new WebDriverWait(HelperClass.DriverEngine.driver, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpath)));
            HelperClass.DriverEngine.driver.FindElement(By.XPath(xpath)).SendKeys(input);
            Console.WriteLine("~~");
            Console.WriteLine();

        }

        public static void Screenshot()
        {
            Console.WriteLine();
            Console.WriteLine("~~");
            Console.WriteLine("Screenshot");
            DateTime currentDateTime = DateTime.Now;
            Thread.Sleep(1500);
            string curDateTime = currentDateTime.ToString("ddMMyy_HHmmss");

            var screenshot = ((ITakesScreenshot)HelperClass.DriverEngine.driver).GetScreenshot();
            string screenshotSavedPath = HelperClass.DriverEngine.downloadFolderPath + @"\screenshots_CIMB\" + curDateTime + ".png";
            Console.WriteLine("Screenshot filename: "+screenshotSavedPath);
            lastScreenshotPath = screenshotSavedPath;
            screenshot.SaveAsFile(screenshotSavedPath, ScreenshotImageFormat.Png);
            Thread.Sleep(1500);
            Console.WriteLine("~~");
            Console.WriteLine();
        }
        public static void GetCurrentURL()
        {
            Console.WriteLine();
            Console.WriteLine("~~");
            Console.WriteLine("GetCurrentURL");
            CurrentURL = HelperClass.DriverEngine.driver.Url;

            Console.WriteLine("CurrentURL: "+ CurrentURL);
            Console.WriteLine("~~");
            Console.WriteLine();
        }
    }
}
