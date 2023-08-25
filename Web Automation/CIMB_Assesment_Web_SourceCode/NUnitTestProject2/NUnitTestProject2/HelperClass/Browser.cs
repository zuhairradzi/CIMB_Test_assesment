using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace CIMB_Test_Auto.HelperClass
{
    class Browser
    {

        public static void GoToURL(string URL)
        {
            HelperClass.DriverEngine.driver.Navigate().GoToUrl(URL);
        }

    }
}
