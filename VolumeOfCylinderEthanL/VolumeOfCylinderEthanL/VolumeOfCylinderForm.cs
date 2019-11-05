/*
 * Created by: Ethan L
 * Created on: 11/05/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Volume of a Cylinder
 * This program gets the users radius and height, and then calculates them and displays the volume of a cylinder (using the 2 inputs)
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

namespace VolumeOfCylinderEthanL
{
    public partial class frmVolOfCylinder : Form
    {
        public frmVolOfCylinder()
        {
            InitializeComponent();
        }

        // Function: CalculateVolCylinder
        // Input: double radius, double height
        // Output: volume
        // Description: This function returns volume with given the radius and height
        private double CalculateVolCylinder(int radius, int height)
        {
            double userVolume; 

            userVolume = 3.14 * Math.Pow(radius, 2) * height;

            return userVolume;
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            int userRadius;
            int userHeight;
            double userVolume;

            // get the radius from the user
            userRadius = Convert.ToInt16(this.txtRadius.Text);
            userHeight = Convert.ToInt16(this.txtHeight.Text);

            // call the function to return a random number
            userVolume = CalculateVolCylinder(userRadius, userHeight);

            // display the volume on the label
            this.lblAnswer.Text = "The volume is: " + userVolume + " cubic meters";

            // show the label
            this.lblAnswer.Show();
        }

        private void FrmVolOfCylinder_Load(object sender, EventArgs e)
        {
            this.lblAnswer.Hide();
        }
    }
}
