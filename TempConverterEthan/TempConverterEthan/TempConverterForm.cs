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
        public void CalculateFahrenheit(double celcius)
        {
            // declare local variables
            double celcius;

            // calculate the fahrenheit with the given celcius
            celcius = (celcius * 1.8) + 32;
        }

        private void BtnConvertToFah_Click(object sender, EventArgs e)
        {

        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
