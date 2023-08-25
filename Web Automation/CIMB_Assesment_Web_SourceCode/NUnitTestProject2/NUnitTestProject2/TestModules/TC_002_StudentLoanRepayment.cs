using NUnit.Framework;
using CIMB_Test_Auto;
using System.Collections.Generic;
using System;
using System.Reflection;

namespace CIMB_Test_Auto
{
    public class TC_002_StudentLoanRepayment
    {
        public static Dictionary<string, dynamic> testCaseData = Data.TCData.testData_TC002;
     
        [Test,Order(0)]
        public void Step_000_LaunchBrowser()
        {
            var myType = typeof(TC_002_StudentLoanRepayment);
            var n = myType.Namespace;
            HelperClass.ElementsHelper.TestCaseName = MethodBase.GetCurrentMethod().DeclaringType.Name.ToString();
   Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Step_000_LaunchBrowser");
            HelperClass.ReportHelper.InitializedReport(HelperClass.ElementsHelper.TestCaseName);
            HelperClass.DriverEngine.SetupNewDriver();
            HelperClass.Browser.GoToURL(Data.URLList.CIMB_SG_Home);
            PagesClass.HomepageAction.HomepageLoaded();
            Console.WriteLine("-----------");
            Console.WriteLine();
        }
        [Test, Order(1)]
        public void Step_001_ClickBurgerMenu()
        {
            HelperClass.ReportHelper.TestStepCreation("Step_001_ClickBurgerMenu");
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Step_001_ClickBurgerMenu");
            PagesClass.HomepageAction.ClickBurgerMenu();
            Console.WriteLine("-----------");
            Console.WriteLine();
            HelperClass.ReportHelper.TestInfoLogAndScreenshots();
        }
        [Test, Order(2)]
        public void Step_002_ClickToolsLink()
        {
            HelperClass.ReportHelper.TestStepCreation("Step_002_ClickToolsLink");
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Step_002_ClickToolsLink");
            PagesClass.HomepageAction.GoToToolsPage();
            PagesClass.ToolsPage.VerifyToolsPageLoaded();
            HelperClass.ReportHelper.TestInfoLogAndScreenshots();
        }

        [Test, Order(3)]
        public void Step_003_ClickEduLoanCalculatorLink()
        {
            HelperClass.ReportHelper.TestStepCreation("Step_003_ClickEduLoanCalculatorLink");
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Step_003_ClickEduLoanCalculatorLink");
            PagesClass.ToolsPage.GoToStudentLoadStandardRepayment();
            HelperClass.DriverEngine.SwitchToNewTab();
            PagesClass.EduLoanPage.VerifyEduPageCalculatorPageLoaded();
            HelperClass.ReportHelper.TestInfoLogAndScreenshots();
        }
        [Test, Order(4)]
        public void Step_004_EnterLoanRepaymentInfo()
        {
            HelperClass.ReportHelper.TestStepCreation("Step_004_EnterLoanRepaymentInfo");
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Step_004_EnterLoanRepaymentInfo");

            PagesClass.EduLoanPage.EnterLoanDetailsIntoInput(testCaseData["validLoanAmount"], testCaseData["validLoanTenure"]);
            HelperClass.ReportHelper.TestInfoLogAndScreenshots();
        }

        [Test, Order(5)]
        public void Step_005_VerifyLoanRepaymentInfoIsDisplayed()
        {
            HelperClass.ReportHelper.TestStepCreation("Step_005_VerifyLoanRepaymentInfoIsDisplayed");
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Step_005_VerifyLoanRepaymentInfoIsDisplayed");

            PagesClass.EduLoanPage.VerifyCalculatedInfoIsDisplayed();
            HelperClass.ReportHelper.TestInfoLogAndScreenshots();
        }

        [Test, Order(6)]
        public void Step_006_StoreLoanRepaymentInfoIsDisplayed()
        {
            HelperClass.ReportHelper.TestStepCreation("Step_006_StoreLoanRepaymentInfoIsDisplayed");
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Step_006_StoreLoanRepaymentInfoIsDisplayed");
            PagesClass.EduLoanPage.GetInfoDisplayedAfterCalculation();
            HelperClass.ReportHelper.TestInfoLogAndScreenshots();
        }
        [Test, Order(7)]
        public void Step_007_VerifySampleRepaymentTableDisplayed()
        {
            HelperClass.ReportHelper.TestStepCreation("Step_007_VerifySampleRepaymentTableDisplayed");
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Step_007_VerifySampleRepaymentTableDisplayed");

              HelperClass.ReportHelper.TestInfoLogAndScreenshots();
        }
        [Test, Order(7)]
        public void Step_007_TestExit()
        {
            HelperClass.ReportHelper.TestStepCreation("Step_007_TestExit");
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Step_007_TestExit");
            HelperClass.DriverEngine.ExitDriver();
            Console.WriteLine("-----------");
            Console.WriteLine();
        }
    }
}