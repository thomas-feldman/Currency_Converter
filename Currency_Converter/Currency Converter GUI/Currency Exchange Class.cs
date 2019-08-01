using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter_GUI {

    enum Currencies { AUD = 1, CNY, DKK, EUR, INR, NZD, AED, GBP, USD, VND };
    
    /// <summary>
    /// 
    /// </summary>
    static class Currency_Exchange_Class {

        private static double[] xRates = { 0, 1, 4.2681, 5.0844, 0.6849, 43.5921, 0.9705, 2.7094, 0.4963, 0.7382, 19115.5547 };


        /// <summary>
        /// Provides country names and currency code which  can be used to initialise a Combo Box
        /// </summary>
        /// <returns> string array each elemnt of which contains the country name and three letter currency code</returns>
        public static string[] InitialiseComboBox() {

            string[] countries = {   "",
                                    "Australia (AUD)",
                                    "China (CNY)",
                                    "Denmark (DKK)",
                                    "Europe (EUR)",
                                    "India (INR)",
                                    "New Zealand (NZD)",
                                    "United Arab Emirates (AED)",
                                    "United Kingdom (GBP)",
                                    "United States (USD)",
                                    "Vietnam (VND)" };

            return countries;
        } //end InitialiseComboBox()
        //The following 10 methods are setting up the conversions FROM one currency
        //Divided by itself, converting then TO the currency selected
        //cValue is the currency Value of the enum
        //nvalue is the new curency value of the enum
        //These will select the index in the array xRates to do the math             
        public static double ConvertToAustralia(double cMoney, int cValue) {
            return (cMoney / (xRates[cValue]));
        }
        public static double ConvertToChina(double cMoney,int cValue, int nValue) {
            return ((cMoney / (xRates[cValue]))* xRates[nValue]);
        }
        public static double ConvertToDenmark(double cMoney,int cValue,int nValue) {
            return ((cMoney / (xRates[cValue])) * xRates[nValue]);
        }
        public static double ConvertToEurope(double cMoney,int cValue,int nValue) {
            return ((cMoney / (xRates[cValue])) * xRates[nValue]);
        }
        public static double ConvertToIndia(double cMoney,int cValue,int nValue) {
            return ((cMoney / (xRates[cValue])) * xRates[nValue]);
        }
        public static double ConvertToNewZealand(double cMoney,int cValue,int nValue) {
            return ((cMoney / (xRates[cValue])) * xRates[nValue]);
        }
        public static double ConvertToUAE(double cMoney,int cValue,int nValue) {
            return ((cMoney / (xRates[cValue])) * xRates[nValue]);
        }
        public static double ConvertToUK(double cMoney,int cValue,int nValue) {
            return ((cMoney / (xRates[cValue])) * xRates[nValue]);
        }
        public static double ConvertToUSA(double cMoney,int cValue,int nValue) {
            return ((cMoney / (xRates[cValue])) * xRates[nValue]);
        }
        public static double ConvertToVietnam(double cMoney,int cValue,int nValue) {
            return ((cMoney / (xRates[cValue])) * xRates[nValue]);
        }
    }//end class
}
/*
*/