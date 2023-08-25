using System;
using System.Collections.Generic;
using System.Text;

namespace CIMB_Test_Auto.ElementContainers
{
    class HomepageElements
    {
          public static string homepageElemLoaded = "//img[contains(@class,'header-logo-img')]";
        public static string closePopup = "(.//*[normalize-space(text()) and normalize-space(.)='here'])[1]/following::*[name()='svg'][2]";
        public static string burgerMenu = "(.//*[normalize-space(text()) and normalize-space(.)='Personal'])[1]/preceding::*[name()='svg'][1]";
        public static string CIMBDealsOption = "//a[contains(text(),'CIMB Deals')][1]";
        public static string toolsOption = "//a[contains(text(),'Tools')][1]";
    }
}
