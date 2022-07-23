using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Note_Pad
{
    public partial class Replace : Note_Pad.FormFind
    {
        Form1 formain;
        public Replace()
        {
            InitializeComponent();
        }
        public Replace(Form1 x): base(x)
        {
            formain = x;
            InitializeComponent();
        }

        private void ReplaceBTN_Click(object sender, EventArgs e)
        { //Replace
            formain.ReplaceFun(ReplaceTEXTLED.Text);
        }

        private void ReplaceAllBTN_Click(object sender, EventArgs e)
        { ////Replace All
            StringComparison x = StringComparison.OrdinalIgnoreCase;
            if (CheckMath.Checked == true)
                x = StringComparison.Ordinal;
            formain.ReplaceAllFun(TextLEDFind.Text, ReplaceTEXTLED.Text, x, DownFind.Checked);
        }
    }
}
