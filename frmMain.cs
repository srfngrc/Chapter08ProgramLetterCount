using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter08ProgramLetterCount
{
    public partial class frmMain : Form
    {
        private const int MAXLETTERS = 26; // Symbolic constants
        private const int MAXCHARS = MAXLETTERS - 1;
        private const int LETTERA = 65;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalc_Click_1(object sender, EventArgs e)
        {
            char oneLetter;
            int index;
            int serafin;
            int i;
            int length;
            int[] count = new int[MAXLETTERS];
            string input;
            string buff;
            length = txtInput.Text.Length;
                            if (length == 0) // did the user entered any word or character??
                            {
                                MessageBox.Show("You need to enter some text.", "Missing Input");
                                txtInput.Focus();
                                return;
                            }

            input = txtInput.Text;
            input = input.ToUpper();
            for (i = 0; i < input.Length; i++) // check all entered letters.
            {
                serafin = input[i];
                oneLetter = input[i]; // Get a character
                index = oneLetter - LETTERA; // Make into an index
                if (index < 0 || index > MAXCHARS) ; // continue; // it is NOT a letter.
                else count[index]++; // it IS a letter.
            }


            //PRINT THE RESULTS WITH FORMAT AT THE LISTBOX
            for (i = 0; i < MAXLETTERS; i++)
            {
                buff = string.Format("{0, 4} {1,35}[{2}]", (char)(i + LETTERA)," ", count[i]);
                lstOutput.Items.Add(buff);
            }
        }
    }
}
