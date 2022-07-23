using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Note_Pad
{
    public partial class Goto : Form
    {
        Form1 formain;
        public Goto(Form1 frm)
        {
            formain = frm;
            InitializeComponent();
        }

        private void Goto_Load(object sender, EventArgs e)
        { // Get Line Number
            TextLEDGOTO.Text = formain.getline().ToString();
            TextLEDGOTO.SelectAll();
        }

        private void GOTOBTN_Click(object sender, EventArgs e)
        { //GoTo
        int n;
         n = Convert.ToInt16(TextLEDGOTO.Text) - 1;
            if(n>formain.getline())
            {
                MessageBox.Show("Out of Range.");
                TextLEDGOTO.SelectAll();
                TextLEDGOTO.Focus();
            }
            else
            {
                formain.gotoFun(n);
                this.Close();
            }

        }

        private void CancelBTN_Click(object sender, EventArgs e)
        { //Exit
            this.Close();
        }
    }
}
