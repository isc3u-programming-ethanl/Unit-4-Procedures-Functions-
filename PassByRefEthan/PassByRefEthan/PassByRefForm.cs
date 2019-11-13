using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassByRefEthan
{
    public partial class frmPassByRef : Form
    {
        // declare global variables
        Random randNumberGenerator = new Random();

        public frmPassByRef()
        {
            InitializeComponent();
        }

        // Procedure: ChangeCard
        // Input: ref PictureBox aPictureBox, intCardNumber
        // Output: void
        // Description: This procedure takes a picture box passed by the reference and a card number. It assigns the image in the picture box
        // to the card with the given card number.
        private void ChangeCard(ref PictureBox aPictureBox, int cardNumber)
        {
            if (cardNumber == 1)
            {
                aPictureBox.Image = Properties.Resources.Front;
            }
            else if (cardNumber == 2)
            {
                aPictureBox.Image = Properties.Resources.JC;
            }
            else if (cardNumber == 3)
            {
                aPictureBox.Image = Properties.Resources.JD;
            }
            else if (cardNumber == 4)
            {
                aPictureBox.Image = Properties.Resources.JH;
            }
            else if (cardNumber == 5)
            {
                aPictureBox.Image = Properties.Resources.JS;
            }
            else if (cardNumber == 6)
            {
                aPictureBox.Image = Properties.Resources.KC;
            }
            else if (cardNumber == 7)
            {
                aPictureBox.Image = Properties.Resources.KD;
            }
            else if (cardNumber == 8)
            {
                aPictureBox.Image = Properties.Resources.KH;
            }
            else if (cardNumber == 9)
            {
                aPictureBox.Image = Properties.Resources.KS;
            }
            else if (cardNumber == 10)
            {
                aPictureBox.Image = Properties.Resources.QC;
            }
            else if (cardNumber == 11)
            {
                aPictureBox.Image = Properties.Resources.QD;
            }
            else if (cardNumber == 12)
            {
                aPictureBox.Image = Properties.Resources.QH;
            }
            else if (cardNumber == 13)
            {
                aPictureBox.Image = Properties.Resources.QS;
            }
        }
        
        private void PicCard_Click(object sender, EventArgs e)
        {
            // declare local constants
            const int MAX_NUM_CARDS = 13;

            // declare local variables
            int aRandomNumber;

            // get a random number between 1 and the maxium
            aRandomNumber = randNumberGenerator.Next(1, MAX_NUM_CARDS + 1);

            // get the card depending on the random selection
            ChangeCard(ref this.picCard, aRandomNumber);
        }
    }
}
