using System;
using System.Collections.Generic;
using System.Text;

namespace CIMB_Test_Auto.ElementContainers
{
    class EduLoanStdCalculatorElements
    {
        public static string dealsPopupCloseBtn = "//div/img[contains(@class,'close')]";
        public static string eduLoanHeader = "//h1[contains(text(),'Education Loan Calculator (Standard Repayment)')]";
        public static string eduLoanStandardPaymentLink = "//h3[contains(text(),'EDUCATION LOAN CALCULATOR (STANDARD REPAYMENT)')]";

       public static string loanAmountInput = "//span[contains(text(),'Loan Amount')]/following-sibling::h3//input";
        public static string loanTenureInput = "//span[contains(text(),'Loan Tenure')]/following-sibling::h3//input";


      public static string minLoanAmountWarning = "//div[contains(text(),'Please enter an amount greater than S$1,000')]";
      public static string maxLoanAmountWarning = "//div[contains(text(),'Please enter an amount less than S$200,000')]";

        public static string minLoanTenureWarning = "//div[contains(text(),'Please enter minimum 1 year')]";
        public static string maxLoanTenureWarning = "//div[contains(text(),'Please enter maximum 10 year(s)')]";

        public static string monthlyInstallmentDisplayed = "//span[contains(text(),'Monthly Instalment')]/following-sibling::h3/span[2]";
        public static string interestRateDisplayed = "//span[contains(text(),'Interest Rate')]/following-sibling::h3/span[1]";
        public static string totalInterestChargedDisplayed = "//span[contains(text(),'Total Interest Charged')]/following-sibling::h3/span[2]";
        public static string totalPaymentAmountDisplayed = "//span[contains(text(),'Total Payment Amount')]/following-sibling::h3/span[2]";

    }
}
