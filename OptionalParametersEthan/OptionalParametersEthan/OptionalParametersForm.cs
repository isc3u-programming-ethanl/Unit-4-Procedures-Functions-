/*
 * Created by: Ethan L
 * Created on: 11/04/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Optional Parameters
 * This program has 2 procedures with the same name (PrintAddress) but different parameters. Here are the procedure calls
 * PrintAddress(apptNumber, streetAddress, city, province, postalCode);
 * PrintAddress(apptNumber, streetAddress, city, province, postalCode);
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionalParametersEthan
{
    public partial class frmOptionalParameters : Form
    {
        public frmOptionalParameters()
        {
            InitializeComponent();
        }

        // Procedure: PrintAddress
        // Input: String streetAddress, city, province, postalCode, aptNumber
        // Output: void
        // Description: This procedure displays a message box with the given four parameters: streetAddress, city, province, postalCode.
        public void PrintAddress(String aptNumber, String streetAddress, String city, String province, String postalCode)
        {
            MessageBox.Show("Your address is: " + streetAddress + " " + city + " " + province + " " + postalCode + " " + aptNumber);
        }

        // Procedure: PrintAddress
        // Input: String streetAddress, city, province, postalCode
        // Output: void
        // Description: This procedure displays a message box with the given four parameters: streetAddress, city, province, postalCode.
        public void PrintAddress(String streetAddress, String city, String province, String postalCode)
        {
            MessageBox.Show("Your address is: " + streetAddress + " " + city + " " + province + " " + postalCode);
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // declare local variables
            String userAptNumber, userStreetAddress, userCity, userProvince, userPostalCode;

            // get inputs from text boxes
            userAptNumber = this.txtUnit.Text;
            userStreetAddress = this.txtAddress.Text;
            userCity = this.txtCity.Text;
            userProvince = this.txtProvince.Text;
            userPostalCode = this.txtPostalCode.Text;

            // make the user enter a street address
            if (userStreetAddress == "")
            {
                MessageBox.Show("Please enter your address.", "Full Address Program");
            }
            // make the user enter a city
            else if (userCity == "")
            {
                MessageBox.Show("Please enter your city.", "Full Address Program");
            }
            // make the user enter a province
            else if (userProvince == "")
            {
                MessageBox.Show("Please enter your province.", "Full Address Program");
            }
            // make the user enter a postal code
            else if (userPostalCode == "")
            {
                MessageBox.Show("Please enter your postal code.", "Full Address Program");
            }
            // if the user does not enter an apartment number, call the procedure that only accepts 4 String parameters 
            else if (userAptNumber == "")
            {
                PrintAddress(userStreetAddress, userCity, userProvince, userPostalCode);
            }
            // if the user enters all 5 names, call the procedure that accepts all 5 String parameters
            else
            {
                PrintAddress(userAptNumber, userStreetAddress, userCity, userProvince, userPostalCode);
            }
        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPostalCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtProvince_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
