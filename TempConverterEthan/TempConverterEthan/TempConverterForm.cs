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
        public void CalculateFahrenheit(int celcius, int fahrenheit)
        {
            // declare local variables
            int celcius;
            int fahrenheit;

            // calculate the fahrenheit with the given celcius
            celcius = (celcius * 1.8) + 32;

            // display a message box with the calculated area
            MessageBox.Show("The degrees in fahrenheit is: ");
        }

        private void BtnConvertToFah_Click(object sender, EventArgs e)
        {
            // declare local variables
            int userCelcius;
            int 
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
