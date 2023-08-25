using System;
using System.Collections.Generic;
using System.Text;

namespace CIMB_Test_Auto.ElementContainers
{
    class CIMBDealsElements
    {
        public static string dealsPopupCloseBtn = "//div/img[contains(@class,'close')]";
        public static string dealsHeader = "//img[contains(@src,'cimb-deals-logo')]";
        public static string viewAllTravelLink = "//a[contains(text(),'View All')][contains(@href,'travel')]";

        public static string dealsOption = "//div[contains(@class,'alp-cimbd-deal card')]/img";
        public static string searchInput = "//input[contains(@name,'searchTerm')]";
        public static string searchBtn = "(//button[contains(@type,'submit')])[1]";


        public static string dealsResultLoaded = "//div[contains(@class,'alp-cimbd-deal card')]/img|//h2[contains(text(),'find what you')]";
        public static string noResultReturn = "//h2[contains(text(),'find what you')]";

        public static string dealIntendedDisplayed(string dealName) { string xpath = "//p[contains(@class,'card-text')][contains(text(),'" + dealName + "')]"; Console.WriteLine("xpath: "+ xpath); return xpath; }
    }
}
