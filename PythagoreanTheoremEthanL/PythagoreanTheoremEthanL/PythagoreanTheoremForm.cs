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

        // Function: CalculateHyp
        // Input: int opp, int adj
        // Output: Hypotenuse
        // Description: This function calculates the hypotenuse by getting the users adj and opp sides
        public double CalculateHyp(int opp, int adj)
        {
            // declare local variables
            int oppSide;
            int adjSide;
            double hypSide;

            // make the opp and adj from the text boxes
           oppSide = int.Parse(this.txtOpp.Text);
           adjSide = int.Parse(this.txtAdj.Text);

            // math for hypotenuse
            hypSide = Math.Sqrt((oppSide * oppSide) + (adjSide * adjSide));

            // Update the label to say the answe
            this.lblAnswer.Text = "The Hypotenuse is: " + hypSide;

            return hypSide;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            int userOpp;
            int userAdj;

            // Convert the userOpp and userAdj to int16 from the text boxes
            userOpp = Convert.ToInt16(this.txtOpp.Text);
            userAdj = Convert.ToInt16(this.txtAdj.Text);

            // calling function
            CalculateHyp(userOpp, userAdj);
        }
    }
}
