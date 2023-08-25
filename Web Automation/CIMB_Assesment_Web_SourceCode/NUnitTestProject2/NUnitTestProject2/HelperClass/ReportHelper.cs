using System;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace CIMB_Test_Auto.HelperClass
{
    class ReportHelper
    {
        public static ExtentTest test;
        public static ExtentReports extent;
        public static ExtentV3HtmlReporter reporter;
        public static string reportFullPath = "null";
        public static string testStepResult = "PASS";

        public static void InitializedReport(string testCaseName)
        {
            Console.WriteLine();
            Console.WriteLine("~~");
            Console.WriteLine("InitializedReport");
            Console.WriteLine("testCaseName: " + testCaseName);
            try
            {
                reportFullPath = HelperClass.DriverEngine.downloadFolderPath + @"\Test_Reports\" + testCaseName + "_Report.html";
                Console.WriteLine("reportFullPath: " + reportFullPath);
                extent = new ExtentReports();
                test = null;
                reporter = new ExtentV3HtmlReporter(reportFullPath);

                reporter.Config.DocumentTitle = testCaseName + "_Report";
                reporter.Config.ReportName = testCaseName;
                reporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

                extent.AttachReporter(reporter);
                extent.AddSystemInfo("Application Under Test", "CIMB");
            }
            catch (Exception e)
            {
                Assert.Fail("Error: " + e);
            }

            Console.WriteLine("~~");
            Console.WriteLine();
        }

        public static void TestStepCreation(string stepName)
        {
            Console.WriteLine();
            Console.WriteLine("~~");
            Console.WriteLine("TestStepCreation");
            Console.WriteLine("stepName: " + stepName);

            HelperClass.ReportHelper.test = HelperClass.ReportHelper.extent.CreateTest(stepName);
            Console.WriteLine("~~");
            Console.WriteLine();
        }

        public static void TestFailLog(string functionName, Exception e)
        {
            Console.WriteLine();
            Console.WriteLine("~~");
            Console.WriteLine("TestFailLog");
            Console.WriteLine("functionName: " + functionName);
            testStepResult = "FAILED";
            HelperClass.ElementsHelper.GetCurrentURL();
            test.Log(Status.Fail, "[" + "] Failed!<br><br> -> Error: <br>" + e + "<br><br> -> URL: <br> " + HelperClass.ElementsHelper.CurrentURL);
            HelperClass.ElementsHelper.Screenshot();
            test.Info("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(HelperClass.ElementsHelper.lastScreenshotPath).Build());

            Console.WriteLine("~~");
            Console.WriteLine();
        }

        public static void TestInfoLogAndScreenshots()
        {
            Console.WriteLine();
            Console.WriteLine("~~");
            Console.WriteLine("TestInfoLogAndScreenshots");
            HelperClass.ElementsHelper.GetCurrentURL();
            test.Log(Status.Info, "Current URL: <br> " + HelperClass.ElementsHelper.CurrentURL);
            HelperClass.ElementsHelper.Screenshot();
            test.Info("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(HelperClass.ElementsHelper.lastScreenshotPath).Build());
            Console.WriteLine("~~");
            Console.WriteLine();
        }
        public static void TestInfoLog(string info)
        {
            Console.WriteLine();
            Console.WriteLine("~~");
            Console.WriteLine("TestInfoLog");
            test.Log(Status.Info, info);  Console.WriteLine("~~");
            Console.WriteLine();
        }
    }
}
