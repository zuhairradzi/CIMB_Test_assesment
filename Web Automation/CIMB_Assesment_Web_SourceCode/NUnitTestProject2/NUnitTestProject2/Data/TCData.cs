using System;
using System.Collections.Generic;
using System.Text;

namespace CIMB_Test_Auto.Data
{
    class TCData
    {
        public static Dictionary<string, dynamic> testData_TC001 = new Dictionary<string, dynamic>()
        {
            { "searchInput","Anantara" } ,
            { "invalidSearchInput","123@@!!$$$" }
        };

        public static Dictionary<string, dynamic> testData_TC002 = new Dictionary<string, dynamic>()
        {
            { "currentInterestRatePerAnnum","4.78" } ,
            { "minInvalidLoanAmount","999" } ,
            { "minInvalidLoanTenure","0" },
            { "minValidLoanAmount","1000" } ,
            { "minValidLoanTenure","1" },
            { "validLoanAmount","5000" } ,
            { "validLoanTenure","8" },
            { "maxValidLoanAmount","199999" } ,
            { "maxValidLoanTenure","10" },
            { "maxInvalidLoanAmount","200000" } ,
            { "maxInvalidLoanTenure","11" },
        };
    }
}
