/*
 * Created by: Ethan L
 * Created on: 11/06/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Calculate the hypotenuse
 * This program gets the opposite and adjacent from the user and calculates the hypotenuse
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

namespace PythagoreanTheoremEthanL
{
    public partial class frmPythagoreanTheorem : Form
    {
        public frmPythagoreanTheorem()
        {
            InitializeComponent();
        }

        public double CalculateHyp(double opp, double adj);

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double opp;
            double adj;
            double hyp;

            // make the opp and adj from 
            opp = Double.Parse(this.txtOpp.Text);
            adj = Double.Parse(this.txtAdj.Text);

            // calling function
            CalculateHyp(opp, adj);
        }
    }
}
