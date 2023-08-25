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
    class CIMBDealsPage
    {
        public static void VerifyDealsPageLoaded()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("####");
                Console.WriteLine("VerifyDealsPageLoaded");
                HelperClass.ElementsHelper.ClickIfExist(ElementContainers.CIMBDealsElements.dealsPopupCloseBtn);

                WebDriverWait wait = new WebDriverWait(HelperClass.DriverEngine.driver, TimeSpan.FromSeconds(15));
                IWebElement dealsHeader = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(ElementContainers.CIMBDealsElements.dealsHeader)));
                Console.WriteLine("####");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                HelperClass.ReportHelper.TestFailLog("VerifyDealsPageLoaded", e);
                HelperClass.ElementsHelper.Screenshot();
                Assert.Fail("Error: " + e);
            }
        }
        public static void GoToCIMBDeals()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("####");
                Console.WriteLine("GoToCIMBDeals");
                HelperClass.ElementsHelper.ClickElement(ElementContainers.CIMBDealsElements.viewAllTravelLink);
            }
            catch (Exception e)
            {
                HelperClass.ReportHelper.TestFailLog("GoToCIMBDeals", e);
                HelperClass.ElementsHelper.Screenshot();
                Assert.Fail("Error: " + e);
            }
        }
        public static void VerifyTravelDealsPageLoaded()
        {
            Console.WriteLine();
            Console.WriteLine("####");
            Console.WriteLine("VerifyTravelDealsPageLoaded");
            try
            {
                WebDriverWait wait = new WebDriverWait(HelperClass.DriverEngine.driver, TimeSpan.FromSeconds(15));
            IWebElement dealsHeader = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(ElementContainers.CIMBDealsElements.dealsHeader)));
            IWebElement travelPage = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(ElementContainers.CIMBDealsElements.dealsOption)));
            }
            catch (Exception e)
            {
                HelperClass.ReportHelper.TestFailLog("VerifyTravelDealsPageLoaded", e);
                HelperClass.ElementsHelper.Screenshot();
                Assert.Fail("Error: " + e);

            }
        }

        public static void SearchDeals(string searchInput)
        {
            Console.WriteLine();
            Console.WriteLine("####");
            Console.WriteLine("SearchDeals");
            try
            {
                HelperClass.ElementsHelper.ClearInput(ElementContainers.CIMBDealsElements.searchInput);

                HelperClass.ElementsHelper.EnterSearchInput(ElementContainers.CIMBDealsElements.searchInput, searchInput);
            HelperClass.ElementsHelper.ClickElement(ElementContainers.CIMBDealsElements.searchBtn);
            }
            catch (Exception e)
            {
                HelperClass.ReportHelper.TestFailLog("SearchDeals", e);
                HelperClass.ElementsHelper.Screenshot();
                Assert.Fail("Error: " + e);

            }
            Console.WriteLine("####");
            Console.WriteLine();
        }

        public static void SearchResultLoaded()
        {
            Console.WriteLine();
            Console.WriteLine("####");
            Console.WriteLine("SearchResultLoaded");
            try
            {
                WebDriverWait wait = new WebDriverWait(HelperClass.DriverEngine.driver, TimeSpan.FromSeconds(15));
            IWebElement dealsResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(ElementContainers.CIMBDealsElements.dealsResultLoaded)));
            }
            catch (Exception e)
            {
                HelperClass.ReportHelper.TestFailLog("SearchResultLoaded", e);
                HelperClass.ElementsHelper.Screenshot();
                Assert.Fail("Error: " + e);

            }
            Console.WriteLine("####");
            Console.WriteLine();
        }

        public static void VerifyDealSearchResultDisplayed(string dealName)
        {
            Console.WriteLine();
            Console.WriteLine("####");
            Console.WriteLine("VerifyDealSearchResultDisplayed");
            try
            {
                WebDriverWait wait = new WebDriverWait(HelperClass.DriverEngine.driver, TimeSpan.FromSeconds(5));
                IWebElement dealsResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(ElementContainers.CIMBDealsElements.dealIntendedDisplayed(dealName))));


            }
            catch (Exception e)
            {
                HelperClass.ReportHelper.TestFailLog("VerifyDealSearchResultDisplayed", e);
                HelperClass.ElementsHelper.Screenshot();
                Assert.Fail("Error: " + e);

            }
            Console.WriteLine("####");
            Console.WriteLine();

        }

        public static void VerifyNoDealDisplayed()
        {
            Console.WriteLine();
            Console.WriteLine("####");
            Console.WriteLine("VerifyNoDealDisplayed");
            try
            {
                WebDriverWait wait = new WebDriverWait(HelperClass.DriverEngine.driver, TimeSpan.FromSeconds(5));
                IWebElement noDealsResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(ElementContainers.CIMBDealsElements.noResultReturn)));


            }
            catch (Exception e)
            {
                HelperClass.ReportHelper.TestFailLog("VerifyNoDealDisplayed", e);
                HelperClass.ElementsHelper.Screenshot();
                Assert.Fail("Error: " + e);

            }
            Console.WriteLine("####");
            Console.WriteLine();

        }
    }
}
