using NUnit.Framework;
using CIMB_Test_Auto;
using System.Collections.Generic;
using System;
using System.Reflection;

namespace CIMB_Test_Auto
{
    public class TC_001_TravelAndLifestyles
    {
        public static Dictionary<string, dynamic> testCaseData = Data.TCData.testData_TC001;

        [Test,Order(0)]
        public void Step_000_LaunchBrowser()
        {
            var myType = typeof(TC_001_TravelAndLifestyles);
            var n = myType.Namespace;
            HelperClass.ElementsHelper.TestCaseName = MethodBase.GetCurrentMethod().DeclaringType.Name.ToString();
   Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Step_000_LaunchBrowser");
            HelperClass.ReportHelper.InitializedReport(HelperClass.ElementsHelper.TestCaseName);
            HelperClass.DriverEngine.SetupNewDriver();
            HelperClass.Browser.GoToURL(Data.URLList.CIMB_MY_Home);
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
        public void Step_002_ClickCIMBDeals()
        {
            HelperClass.ReportHelper.TestStepCreation("Step_002_ClickCIMBDeals");
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Step_002_ClickCIMBDeals");
            PagesClass.HomepageAction.GoToCIMBDeals();
            PagesClass.CIMBDealsPage.VerifyDealsPageLoaded();
            HelperClass.ReportHelper.TestInfoLogAndScreenshots();
        }
        [Test, Order(3)]
        public void Step_003_SearchATravelDeal()
        {
            HelperClass.ReportHelper.TestStepCreation("Step_003_SearchATravelDeal");
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Step_003_SearchATravelDeal");
            PagesClass.CIMBDealsPage.SearchDeals(testCaseData["searchInput"]);
            PagesClass.CIMBDealsPage.SearchResultLoaded();
            Console.WriteLine("-----------");
            Console.WriteLine();
            HelperClass.ReportHelper.TestInfoLogAndScreenshots();
        }
        [Test, Order(4)]
        public void Step_004_VerifySearchResultShowsCorrectResult()
        {
            HelperClass.ReportHelper.TestStepCreation("Step_004_VerifySearchResultShowsCorrectResult");
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Step_004_VerifySearchResultShowsCorrectResult");
            PagesClass.CIMBDealsPage.VerifyDealSearchResultDisplayed(testCaseData["searchInput"]);
            Console.WriteLine("-----------");
            Console.WriteLine();
            HelperClass.ReportHelper.TestInfoLogAndScreenshots();
        }

        [Test, Order(5)]
        public void Step_005_SearchTravelDealWithSpecialCharacters()
        {
            HelperClass.ReportHelper.TestStepCreation("Step_005_SearchTravelDealWithSpecialCharacters");
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Step_005_SearchTravelDealWithSpecialCharacters");
            PagesClass.CIMBDealsPage.SearchDeals(testCaseData["invalidSearchInput"]);
            PagesClass.CIMBDealsPage.SearchResultLoaded();
            Console.WriteLine("-----------");
            Console.WriteLine();
            HelperClass.ReportHelper.TestInfoLogAndScreenshots();
        }
        [Test, Order(6)]
        public void Step_006_VerifySearchResultShowsNoResult()
        {
            HelperClass.ReportHelper.TestStepCreation("Step_006_VerifySearchResultShowsNoResult");
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("Step_006_VerifySearchResultShowsNoResult");
            PagesClass.CIMBDealsPage.VerifyNoDealDisplayed();
            Console.WriteLine("-----------");
            Console.WriteLine();
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