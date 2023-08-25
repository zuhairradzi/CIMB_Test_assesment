using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace CIMB_Test_Auto.PagesClass
{
    class HomepageAction
    {
        public static void HomepageLoaded()
        {
            Console.WriteLine();
            Console.WriteLine("####");
            Console.WriteLine("HomepageLoaded");
            try
            {
                WebDriverWait wait = new WebDriverWait(HelperClass.DriverEngine.driver, TimeSpan.FromSeconds(15));
            IWebElement burgerMenuClickable = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(ElementContainers.HomepageElements.homepageElemLoaded)));
            HelperClass.ElementsHelper.ClickIfExist(ElementContainers.HomepageElements.closePopup);
            }
            catch (Exception e)
            {
                HelperClass.ReportHelper.TestFailLog("homepageLoaded", e);
                HelperClass.ElementsHelper.Screenshot();
                Assert.Fail("Error: " + e);
            }
            Console.WriteLine("####");
            Console.WriteLine();
        }
        public static void ClickBurgerMenu()
        {
            Console.WriteLine();
            Console.WriteLine("####");
            Console.WriteLine("ClickBurgerMenu");
            try
            {
                HelperClass.ElementsHelper.ClickIfExist(ElementContainers.HomepageElements.burgerMenu);
            }
            catch (Exception e)
            {
                HelperClass.ReportHelper.TestFailLog("ClickBurgerMenu", e);
                HelperClass.ElementsHelper.Screenshot();
                Assert.Fail("Error: " + e);
            }
            Console.WriteLine("####");
            Console.WriteLine();
        }

        public static void GoToCIMBDeals()
        {
            Console.WriteLine();
            Console.WriteLine("####");
            Console.WriteLine("GoToCIMBDeals");
            try
            {
                HelperClass.ElementsHelper.ClickElement(ElementContainers.HomepageElements.CIMBDealsOption);
            }
            catch (Exception e)
            {
                HelperClass.ReportHelper.TestFailLog("GoToCIMBDeals", e);
                HelperClass.ElementsHelper.Screenshot();
                Assert.Fail("Error: " + e);
            }
            Console.WriteLine("####");
            Console.WriteLine();
        }


        public static void GoToToolsPage()
        {
            Console.WriteLine();
            Console.WriteLine("####");
            Console.WriteLine("GoToToolsPage");
            try
            {
                HelperClass.ElementsHelper.ClickElement(ElementContainers.HomepageElements.toolsOption);
            }
            catch (Exception e)
            {
                HelperClass.ReportHelper.TestFailLog("GoToToolsPage", e);
                HelperClass.ElementsHelper.Screenshot();
                Assert.Fail("Error: " + e);
            }
            Console.WriteLine("####");
            Console.WriteLine();
        }
    }
}
