using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Linq;

namespace CIMB_Test_Auto.HelperClass
{
    class DriverEngine
    {
        public static WebDriver driver;
        public static string downloadFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

        public static void SetupNewDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        public static void ExitDriver()
        {
            HelperClass.ReportHelper.extent.Flush();
            driver.Quit();
        }

        public static void SwitchToNewTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last()) ;
        }
    }
}
