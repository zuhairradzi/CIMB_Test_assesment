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
    class EduLoanPage
    {
        public static string monthlyInstallCalculated = "null";
        public static string interestRateCalculated = "null";
        public static string totalInterestChargedCalculated = "null";
        public static string totalPaymentAmountCalculated = "null";


        public static void VerifyEduPageCalculatorPageLoaded()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("####");
                Console.WriteLine("VerifyEduPageCalculatorPageLoaded");
            
                WebDriverWait wait = new WebDriverWait(HelperClass.DriverEngine.driver, TimeSpan.FromSeconds(15));
                IWebElement dealsHeader = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(ElementContainers.EduLoanStdCalculatorElements.eduLoanHeader)));
                Console.WriteLine("####");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                HelperClass.ReportHelper.TestFailLog("VerifyEduPageCalculatorPageLoaded", e);
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

        public static void EnterLoanDetailsIntoInput(string loanAmount, string loanTenure)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("####");
                Console.WriteLine("EnterLoanDetailsIntoInput");
                HelperClass.ElementsHelper.ClickElement(ElementContainers.EduLoanStdCalculatorElements.loanAmountInput);
                HelperClass.ElementsHelper.EnterSearchInput(ElementContainers.EduLoanStdCalculatorElements.loanAmountInput, loanAmount);
                HelperClass.ElementsHelper.ClickElement(ElementContainers.EduLoanStdCalculatorElements.loanTenureInput);
                HelperClass.ElementsHelper.EnterSearchInput(ElementContainers.EduLoanStdCalculatorElements.loanTenureInput, loanTenure);
            }
            catch (Exception e)
            {
                HelperClass.ReportHelper.TestFailLog("EnterLoanDetailsIntoInput", e);
                HelperClass.ElementsHelper.Screenshot();
                Assert.Fail("Error: " + e);
            }
        }

        public static void VerifyCalculatedInfoIsDisplayed()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("####");
                Console.WriteLine("VerifyCalculatedInfoIsDisplayed");

                HelperClass.ElementsHelper.VerifyElementIsDisplayed(ElementContainers.EduLoanStdCalculatorElements.monthlyInstallmentDisplayed);
                HelperClass.ElementsHelper.VerifyElementIsDisplayed(ElementContainers.EduLoanStdCalculatorElements.interestRateDisplayed);
                HelperClass.ElementsHelper.VerifyElementIsDisplayed(ElementContainers.EduLoanStdCalculatorElements.totalInterestChargedDisplayed);
                HelperClass.ElementsHelper.VerifyElementIsDisplayed(ElementContainers.EduLoanStdCalculatorElements.totalPaymentAmountDisplayed);

                Console.WriteLine("monthlyInstallCalculated: " + monthlyInstallCalculated);
                Console.WriteLine("interestRateCalculated: " + interestRateCalculated);
                Console.WriteLine("totalInterestChargedCalculated: " + totalInterestChargedCalculated);
                Console.WriteLine("totalPaymentAmountCalculated: " + totalPaymentAmountCalculated);
            }
            catch (Exception e)
            {
                HelperClass.ReportHelper.TestFailLog("GoToStudentLoadStandardRepayment", e);
                HelperClass.ElementsHelper.Screenshot();
                Assert.Fail("Error: " + e);
            }
        }

        public static void GetInfoDisplayedAfterCalculation()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("####");
                Console.WriteLine("GetInfoDisplayedAfterCalculation");

                monthlyInstallCalculated = HelperClass.DriverEngine.driver.FindElement(By.XPath(ElementContainers.EduLoanStdCalculatorElements.monthlyInstallmentDisplayed)).Text;         
                interestRateCalculated = HelperClass.DriverEngine.driver.FindElement(By.XPath(ElementContainers.EduLoanStdCalculatorElements.interestRateDisplayed)).Text;
                totalInterestChargedCalculated = HelperClass.DriverEngine.driver.FindElement(By.XPath(ElementContainers.EduLoanStdCalculatorElements.totalInterestChargedDisplayed)).Text;
                totalPaymentAmountCalculated = HelperClass.DriverEngine.driver.FindElement(By.XPath(ElementContainers.EduLoanStdCalculatorElements.totalPaymentAmountDisplayed)).Text;

                HelperClass.ReportHelper.TestInfoLog("monthlyInstallCalculated: " + monthlyInstallCalculated+"<br>" + "interestRateCalculated: " + interestRateCalculated + "<br>" + "totalInterestChargedCalculated: " + totalInterestChargedCalculated + "<br>" + "totalPaymentAmountCalculated: " + totalPaymentAmountCalculated);
                Console.WriteLine("monthlyInstallCalculated: "+ monthlyInstallCalculated);
                Console.WriteLine("interestRateCalculated: " + interestRateCalculated);
                Console.WriteLine("totalInterestChargedCalculated: " + totalInterestChargedCalculated);
                Console.WriteLine("totalPaymentAmountCalculated: " + totalPaymentAmountCalculated);
            }
            catch (Exception e)
            {
                HelperClass.ReportHelper.TestFailLog("GoToStudentLoadStandardRepayment", e);
                HelperClass.ElementsHelper.Screenshot();
                Assert.Fail("Error: " + e);
            }
        }
        public static void VerifySamplePaymentTableDisplayed()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("####");
                Console.WriteLine("VerifySamplePaymentTableDisplayed");

                HelperClass.ElementsHelper.VerifyElementIsDisplayed(ElementContainers.EduLoanStdCalculatorElements.monthlyInstallmentDisplayed);
                HelperClass.ElementsHelper.VerifyElementIsDisplayed(ElementContainers.EduLoanStdCalculatorElements.interestRateDisplayed);
                HelperClass.ElementsHelper.VerifyElementIsDisplayed(ElementContainers.EduLoanStdCalculatorElements.totalInterestChargedDisplayed);
                HelperClass.ElementsHelper.VerifyElementIsDisplayed(ElementContainers.EduLoanStdCalculatorElements.totalPaymentAmountDisplayed);

                Console.WriteLine("monthlyInstallCalculated: " + monthlyInstallCalculated);
                Console.WriteLine("interestRateCalculated: " + interestRateCalculated);
                Console.WriteLine("totalInterestChargedCalculated: " + totalInterestChargedCalculated);
                Console.WriteLine("totalPaymentAmountCalculated: " + totalPaymentAmountCalculated);
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
