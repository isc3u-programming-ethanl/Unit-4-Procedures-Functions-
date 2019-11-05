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
        private double CalculateVolCylinder(double radius, double height)
        {

        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double userRadius;
            double userHeight;
            double userVolume;

            // get the radius from the user
            userRadius = Convert.ToInt16(this.txtRadius.Text);
            userHeight = Convert.ToInt16(this.txtHeight.Text);

            // call the function to return a random number
            userVolume = CalculateVolCylinder();

            // display the volume on the label
            this.lblAnswer.Text = "The volume is: " + userVolume + "cubic meters";
        }
    }
}
