using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundingProgramEthanL
{
    public partial class frmRoundingProgram : Form
    {
        public frmRoundingProgram()
        {
            InitializeComponent();
        }

        private void RoundDecimal(ref TextBox dec, ref NumericUpDown places)
        {
            double userDec;

            userDec = Convert.ToDouble(this.txtInput.Text);

            double userPlaces;

            userPlaces = Convert.ToDouble(this.nudRound.DecimalPlaces);

            double userAnswer;

            userAnswer = (userDec * Math.Pow(10, userPlaces) + 0.5);
            userAnswer = Math.Truncate(userAnswer);
            userAnswer = userAnswer / userDec;

            MessageBox.Show("The answer is " + userAnswer);
        }
       

        private void BtnRound_Click(object sender, EventArgs e)
        {
            // calling the procedure
            RoundDecimal(ref txtInput, ref nudRound);
        }
    }
}
