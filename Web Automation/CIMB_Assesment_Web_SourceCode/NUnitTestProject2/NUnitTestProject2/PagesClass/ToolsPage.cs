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
    class ToolsPage
    {
        public static void VerifyToolsPageLoaded()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("####");
                Console.WriteLine("VerifyToolsPageLoaded");
                HelperClass.ElementsHelper.ClickIfExist(ElementContainers.CIMBDealsElements.dealsPopupCloseBtn);

                WebDriverWait wait = new WebDriverWait(HelperClass.DriverEngine.driver, TimeSpan.FromSeconds(15));
                IWebElement dealsHeader = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(ElementContainers.ToolsElements.toolsHeader)));
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
        public static void GoToStudentLoadStandardRepayment()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("####");
                Console.WriteLine("GoToStudentLoadStandardRepayment");
                HelperClass.ElementsHelper.ClickElement(ElementContainers.ToolsElements.eduLoanStandardPaymentLink);
            }
            catch (Exception e)
            {
                HelperClass.ReportHelper.TestFailLog("GoToStudentLoadStandardRepayment", e);
                HelperClass.ElementsHelper.Screenshot();
                Assert.Fail("Error: " + e);
            }
        }
    }
}
