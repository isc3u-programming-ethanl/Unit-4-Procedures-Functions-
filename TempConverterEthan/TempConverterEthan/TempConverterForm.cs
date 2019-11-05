/*
 * Created by: Ethan L
 * Created on: 11/03/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Pass By Value
 * This program gets the degrees Celsius from the user, passes it BY VALUE to a procedure, that converts it to Fahrenheit, and then displays the degrees Fahrenheit in a message box.
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

namespace TempConverterEthan
{
    public partial class frmTempConverter : Form
    {
        public frmTempConverter()
        {
            InitializeComponent();
        }

        // Function: CalculateToFahrenheit
        // Input: double celcius
        // Output: void
        // This function takes the users celcius (input) and converts it to fahrenheit (9/5 int32)
        public void CalculateFahrenheit(int celcius)
        {
            // declare local variables
            int celciusTemp;
            double fahrenheitTemp;

            // get input from textbox
            celciusTemp = int.Parse(txtInput.Text);

            // calculate the fahrenheit with the given celcius
            fahrenheitTemp = (celciusTemp * 1.8) + 32;

            // display a message box with the calculated area
            MessageBox.Show("The degrees in fahrenheit is: " + fahrenheitTemp + "°");
        }

        private void BtnConvertToFah_Click(object sender, EventArgs e)
        {
            // declare local variables
            int userCelcius;

            // convert the input celcius and fahrenheit from String to int and assign them to their corresponding variables
            userCelcius = Convert.ToInt16(this.txtInput.Text);

            // call the function to calculate the fahrenheit passing the userCelcius and userFahrenheit arguments by value
            this.CalculateFahrenheit(userCelcius);
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
