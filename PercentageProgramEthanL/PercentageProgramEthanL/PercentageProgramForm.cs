/*
 * Created by: Ethan L
 * Created on: 11/08/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Percentage Program
 * This program takes the user's grade level and returns the equivalent percentage mark
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

namespace PercentageProgramEthanL
{
    public partial class frmPercentageProgram : Form
    {

        public frmPercentageProgram()
        {
            InitializeComponent();
          
        }

        // Function: ConvertToPercent
        // Input: String level
        // Output: int
        // Description: This function accepts a level of type string and returns the percentage equivalent as an integer.
        private int ConvertToPercent(String level)
        {
            int percentage;

            switch (level)
            {
                case "4++":
                    percentage = 98;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "4+":
                    percentage = 95;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "4":
                    percentage = 87;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "4-":
                    percentage = 83;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "3+":
                    percentage = 78;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "3":
                    percentage = 75;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "3-":
                    percentage = 72;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "2+":
                    percentage = 68;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "2":
                    percentage = 65;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "2-":
                    percentage = 62;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "1+":
                    percentage = 58;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "1":
                    percentage = 55;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "1-":
                    percentage = 52;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "0+":
                    percentage = 45;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "0":
                    percentage = 40;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "0-":
                    percentage = 35;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "0--":
                    percentage = 30;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "0---":
                    percentage = 20;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;
                case "0----":
                    percentage = 10;
                    MessageBox.Show("Level " + level + " is equivalent to " + percentage + "%");
                    break;

                default:
                    percentage = -1;
                    MessageBox.Show("Please enter a valid level");
                    break;
            }
            return percentage;
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // declare variables
            string userLevel;
            int userPercentage;

            userLevel = this.txtInput.Text;

            // call the function
            userPercentage = ConvertToPercent(userLevel);
        }
    }
}
