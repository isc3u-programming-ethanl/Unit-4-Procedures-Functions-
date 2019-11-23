using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringEqualityEthan
{
    public partial class frmStringEquality : Form
    {
        public frmStringEquality()
        {
            InitializeComponent();
        }

        public bool StringsAreEqual(String one, String two)
        {
            // declare local variables
            bool isEqual = false;

            string string1;
            string string2;

            int length1;
            int length2;

            length1 = one.Length;
            length2 = two.Length;

            if (length1 == length2)
            {
                string1 = one.ToUpper();
                string2 = two.ToUpper();

                if (string1 == string2)
                {
                    isEqual = true;
                }
            }
            return isEqual;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            string realString1;
            string realString2;

            realString1 = Convert.ToString(this.txtString1);
            realString2 = Convert.ToString(this.txtString2);

            bool isEqual = StringsAreEqual(realString1, realString2);

            if (isEqual == true)
            {
                this.lblAnswer.Text = "These strings are equal.";
                this.lblAnswer.Show();
            }
            else
            {
                this.lblAnswer.Text = "These strings are NOT equal.";
                this.lblAnswer.Show();
            }
        }
    }
}
