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
    public partial class FormFind : Form
    {
        Form1 frnmain;

  public FormFind(Form1 frn)
    { frnmain = frn; InitializeComponent();}
  public FormFind()
    { InitializeComponent();}

        private void FindBTN_Click(object sender, EventArgs e)
        { //Find Text
            frnmain.FindFun(TextLEDFind.Text);   
        }

        private void FindNext_Click(object sender, EventArgs e)
        { //Find Text Next
            StringComparison a = StringComparison.OrdinalIgnoreCase;
            if (CheckMath.Checked == true)
                a = StringComparison.Ordinal;

            frnmain.FindFunNext(TextLEDFind.Text,a,DownFind.Checked);
             // frnmain.FindFunNext(TextLEDFind.Text, a, DownFind.Checked);
            // frnmain.FindFunNext(FindNext.Text);
        }

        private void CANFindBTN_Click(object sender, EventArgs e)
        { //EXIT
            this.Close();
        }
    }
}
