using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter_GUI {
/* Simple Windows Form Assignment Currency Converter
* User will select a currency that they have
* and a currency that they want to convert too.
* These Values will be saved in 2 variables that will
* be used to select an index of the array xRates from Currency Exchange Class.
* A user will input a value of currency that they have and it will be sent the Currency class
* after determining which currency it will be converted too.
* This result is put into the remaining text box and the program will
* ask if the user wishes to reset the program and go again
* or if they would like to close the program.
* 
* Author: Thomas Feldman, n8306699 
* Date: 1st May 2017
*   
*/
    public partial class Form1 : Form {

        //The follwing is setting up the variables we need to save the selected values of the combo boxes
        Currencies whichCurrencyFrom;
        int whichConversionFrom;

        Currencies whichCurrencyToo;
        int whichConversionToo;
        
        public Form1() {
            InitializeComponent();           
            comboBoxCurrencyOld.DataSource = Currency_Exchange_Class.InitialiseComboBox();
            comboBoxCurrencyNew.DataSource = Currency_Exchange_Class.InitialiseComboBox();
            comboBoxCurrencyOld.SelectedIndexChanged += new EventHandler(comboBoxCurrencyOld_SelectedIndexChanged);
            comboBoxCurrencyNew.SelectedIndexChanged += new EventHandler(comboBoxCurrencyNew_SelectedIndexChanged);
            //For some reason, I need to disable everything at the start after i put the above in
            //because it will just enable the whole form? Not sure if this was intended or if i stuffed something up
            comboBoxCurrencyOld.Enabled = true;
            comboBoxCurrencyNew.Enabled = false;
            labelNewCurrency.Visible = false;
            labelOldCurrency.Visible = false;            
            buttonCalculate.Enabled = false;
            textBoxCurrentAmount.Enabled = false;
            groupBoxReset.Visible = false;
        }//end Form1

        private void comboBoxCurrencyOld_SelectedIndexChanged(object sender,EventArgs e) {
            //sets the selected value to equal a variable that will be used to calcualte the result
            whichConversionFrom = comboBoxCurrencyOld.SelectedIndex;
            whichCurrencyFrom = (Currencies)whichConversionFrom;            
            comboBoxCurrencyNew.Enabled = true;
            comboBoxCurrencyOld.Enabled = false;
        }//end old currency combo box

        private void comboBoxCurrencyNew_SelectedIndexChanged(object sender,EventArgs e) {
            //sets the selected value to equal a variable which will be used to calculate the result
            whichConversionToo = comboBoxCurrencyNew.SelectedIndex;
            whichCurrencyToo = (Currencies)whichConversionToo;
            comboBoxCurrencyNew.Enabled = false;
            SetLabels();                      
        }//end new currency combobox

        public void SetLabels() {
            //Sets the hidden Labels to the Enum values as a string
            labelOldCurrency.Text = whichCurrencyFrom.ToString();
            labelOldCurrency.Visible = true;
            labelNewCurrency.Text = whichCurrencyToo.ToString();
            labelNewCurrency.Visible = true;
            textBoxCurrentAmount.Enabled = true;
        }//End SetLabels

        private void textBoxCurrentAmount_TextChanged(object sender,EventArgs e) {
            //enables the button when a value has been added
            buttonCalculate.Enabled = true;
            buttonCalculate.Visible = true;
        }//end text box change

        private void EnableOutput(double value) {
            //This will set the outputted result to the final text box and ask if the user would like to convert another
            groupBoxReset.Visible = true;
            groupBoxReset.Enabled = true;
            textBoxCurrentAmount.Enabled = false;
            textBoxConverted.Text = value.ToString();
        }//End output

        private void buttonCalculate_Click(object sender,EventArgs e) {            
            double currencyCurrent, result;
            //Set variables needed for conversion
            //Check if user input is a integer, if not, reset the input
            if(!double.TryParse(textBoxCurrentAmount.Text,out currencyCurrent)){
                    MessageBox.Show("Value entered must be numeric");
                    textBoxCurrentAmount.Text = "";
                    textBoxCurrentAmount.Focus();
                    return;               
            }//End number check
            //Check for positive
            if(double.TryParse(textBoxCurrentAmount.Text, out currencyCurrent)) {
                if(currencyCurrent <0) {
                    MessageBox.Show("Value entered must be positive");
                    textBoxCurrentAmount.Text = "";
                    textBoxCurrentAmount.Focus();
                    return;
                }
            }//end positive check
            
            //Selecting the currency I am converting too in a switch based on the enum Currencies
            switch(whichCurrencyToo) {
                case Currencies.AUD:
                    //If the currency we want is 1 (AUD), set the cValue to equal the currency we have
                    int cValue = whichConversionFrom;
                    //set the result to equal the return value from the conversion, rounded using Math.Round, to 2 places, rounding from zero
                    result = Math.Round(Currency_Exchange_Class.ConvertToAustralia(currencyCurrent,cValue), 2, MidpointRounding.AwayFromZero);
                    //send the result to the output method
                    EnableOutput(result);
                    //If we got to this, break out of the switch
                    break;
                case Currencies.CNY:
                    cValue = whichConversionFrom;
                    //The nvalue is set to equal the enum value of the currency we want
                    int nValue = whichConversionToo;
                    result = Math.Round(Currency_Exchange_Class.ConvertToChina(currencyCurrent,cValue,nValue), 2, MidpointRounding.AwayFromZero);
                    EnableOutput(result);
                    break;
                case Currencies.DKK:
                    cValue = whichConversionFrom;
                    nValue = whichConversionToo;
                    result = Math.Round(Currency_Exchange_Class.ConvertToDenmark(currencyCurrent,cValue,nValue), 2, MidpointRounding.AwayFromZero);
                    EnableOutput(result);
                    break;
                case Currencies.EUR:
                    cValue = whichConversionFrom;
                    nValue = whichConversionToo;
                    result = Math.Round(Currency_Exchange_Class.ConvertToEurope(currencyCurrent,cValue,nValue), 2, MidpointRounding.AwayFromZero);
                    EnableOutput(result);
                    break;
                case Currencies.INR:
                    cValue = whichConversionFrom;
                    nValue = whichConversionToo;
                    result = Math.Round(Currency_Exchange_Class.ConvertToIndia(currencyCurrent,cValue,nValue), 2, MidpointRounding.AwayFromZero);
                    EnableOutput(result);
                    break;
                case Currencies.NZD:
                    cValue = whichConversionFrom;
                    nValue = whichConversionToo;
                    result = Math.Round(Currency_Exchange_Class.ConvertToNewZealand(currencyCurrent,cValue,nValue), 2, MidpointRounding.AwayFromZero);
                    EnableOutput(result);
                    break;
                case Currencies.AED:
                    cValue = whichConversionFrom;
                    nValue = whichConversionToo;
                    result = Math.Round(Currency_Exchange_Class.ConvertToUAE(currencyCurrent,cValue,nValue),2,MidpointRounding.AwayFromZero);
                    EnableOutput(result);
                    break;
                case Currencies.GBP:
                    cValue = whichConversionFrom;
                    nValue = whichConversionToo;
                    result = Math.Round(Currency_Exchange_Class.ConvertToUK(currencyCurrent,cValue,nValue),2,MidpointRounding.AwayFromZero);
                    EnableOutput(result);
                    break;
                case Currencies.USD:
                    cValue = whichConversionFrom;
                    nValue = whichConversionToo;
                    result = Math.Round(Currency_Exchange_Class.ConvertToUSA(currencyCurrent,cValue,nValue),2,MidpointRounding.AwayFromZero);
                    EnableOutput(result);
                    break;
                case Currencies.VND:
                    cValue = whichConversionFrom;
                    nValue = whichConversionToo;
                    result = Math.Round(Currency_Exchange_Class.ConvertToVietnam(currencyCurrent,cValue,nValue),2,MidpointRounding.AwayFromZero);
                    EnableOutput(result);
                    break;
            }//End Switch

        }//End Button Calculate

        private void radioButtonYes_CheckedChanged(object sender,EventArgs e) {
            //When yes is checked, do the Reset Method
            ResetProgram();
        }//End Yes Checked

        private void ResetProgram() {
            //The following is the resetting all of the parts of the FORM1
            groupBoxReset.Visible = false;
            buttonCalculate.Visible = false;
            buttonCalculate.Enabled = false;
            comboBoxCurrencyOld.Enabled = true;
            comboBoxCurrencyNew.Enabled = false;
            labelNewCurrency.Visible = false;
            labelOldCurrency.Visible = false;
            textBoxCurrentAmount.Enabled = false;
            textBoxCurrentAmount.Text = "";
            textBoxConverted.Text = "";
            radioButtonYes.Checked = false;
        }//End ResetProgram

        //Will exit the program
        private void radioButtonNo_CheckedChanged(object sender,EventArgs e) {
            MessageBox.Show("Bye Bye!");
            Environment.Exit(0);
        }//End Exit Program
    }//end class
}
