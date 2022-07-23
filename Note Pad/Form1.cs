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
    public partial class Form1 : Form
    {
        public string fn;
        Boolean saveflag;
        //MyUndo NotePadUndo = new MyUndo();
        public Form1()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)//Exit 
        { Application.Exit(); }
        private void SetBackColor(object sender, EventArgs e) // Color Set Note Pad  
        {
            TextBoxLED.BackColor = Color.FromName(((ToolStripMenuItem)sender).Text);
            //Red - Blue - Green
            if (TextBoxLED.BackColor == Color.Red || TextBoxLED.BackColor == Color.Blue || TextBoxLED.BackColor == Color.Green)
            { TextBoxLED.ForeColor = Color.White; menuStrip1.BackColor = Color.Black; }
            // Black
            if (TextBoxLED.BackColor == Color.Black)
            { TextBoxLED.ForeColor = Color.White; menuStrip1.BackColor = Color.Black; menuStrip1.ForeColor = Color.Red; }
            // White
            if (TextBoxLED.BackColor == Color.White)
            { TextBoxLED.ForeColor = Color.Black; menuStrip1.BackColor = Color.WhiteSmoke; menuStrip1.ForeColor = Color.Black; }
            //Check Box
            foreach (ToolStripMenuItem x in backColorToolStripMenuItem.DropDownItems)
                if (x.Equals(sender))
                    x.Checked = true;
                else x.Checked = false;
        }
        private void ColorSetBTN(object sender, EventArgs e) // Color Set BTN Note Pad
        {
            TextBoxLED.BackColor = Color.FromName(((Button)sender).Text);
            menuStrip1.ForeColor = Color.FromName(((Button)sender).Text);
            // Black
            if (TextBoxLED.BackColor == Color.Black)
            { TextBoxLED.ForeColor = Color.White; menuStrip1.BackColor = Color.Black; menuStrip1.ForeColor = Color.Red; }
            // Whites
            if (TextBoxLED.BackColor == Color.White)
            { TextBoxLED.ForeColor = Color.Black; menuStrip1.BackColor = Color.WhiteSmoke; menuStrip1.ForeColor = Color.Black; }
        }
        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e) //StatusBar
        { statusBar1.Visible = statusBarToolStripMenuItem.Checked; }
        private void moreToolStripMenuItem2_Click(object sender, EventArgs e) //More Back Color LED Set
        {
            colorDialog1.FullOpen = true;
            colorDialog1.ShowDialog();
            TextBoxLED.BackColor = colorDialog1.Color;
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.ForeColor = Color.Black;
            //White
            if (TextBoxLED.BackColor == Color.White)
                TextBoxLED.ForeColor = Color.Black;
            //Black
            if (TextBoxLED.BackColor == Color.Black)
                TextBoxLED.ForeColor = Color.White;
        }
        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e) //Fore Color LED Set
        { colorDialog1.FullOpen = true; colorDialog1.ShowDialog(); TextBoxLED.ForeColor = colorDialog1.Color; }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e) //Font LED Set
        { fontDialog1.Font = TextBoxLED.Font; fontDialog1.ShowDialog(); TextBoxLED.Font = fontDialog1.Font; }
        private void Form1_Load(object sender, EventArgs e)
        { //Text Ram
            if (System.IO.File.Exists("LOG-TEXT.TXT") == true)
            { string ram; ram = System.IO.File.ReadAllText("LOG-TEXT.TXT"); TextBoxLED.Text = ram; }

            string[] X = new string[3];
            if (System.IO.File.Exists("LOG.TXT") == true)
            {
                X = System.IO.File.ReadAllLines("LOG.TXT");
                ToolStripMenuItem temp = new ToolStripMenuItem();
                temp.Text = X[0];
                TextBoxLED.Font = new Font(X[1], Convert.ToInt16(X[2]));
                SetBackColor(temp, null);
            }
            saveflag = true;
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        { //Word Wrap
            TextBoxLED.WordWrap = wordWrapToolStripMenuItem.Checked;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        { //Seve As
            fn = null;
            saveToolStripMenuItem_Click(null, null);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        { //Save TXT
            if (fn == null)
            {
                DialogResult x;
                saveFileDialog1.DefaultExt = "txt";
                x = saveFileDialog1.ShowDialog();
                if (x == DialogResult.Cancel)
                    return;
                fn = saveFileDialog1.FileName;
            }
            System.IO.File.WriteAllText(fn, TextBoxLED.Text);
            saveflag = true;
            this.Text = fn;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        { //New File
            if (saveflag != true)
            {
                DialogResult Save;
                Save = MessageBox.Show("File Not Seve ^_^ File Save ??", "Save File ...", MessageBoxButtons.YesNo);
                if (Save == DialogResult.Yes)
                    saveToolStripMenuItem_Click(null, null);
            }
            TextBoxLED.Text = "";
            this.Text = "NotePad 2.1.1 + AGC007 +";
            saveflag = true;
            fn = null;
        }

        private void TextBoxLED_TextChanged(object sender, EventArgs e)
        { // Save Test
            saveflag = false;
            SetRC();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        { //Open File
            newToolStripMenuItem_Click(null, null);
            openFileDialog1.Filter = "Text File|*.txt|Document File|*.doc|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            fn = openFileDialog1.FileName;
            TextBoxLED.Text = System.IO.File.ReadAllText(fn);
            saveflag = true;
            this.Text = fn;
        }

        private void LOG_Click(object sender, EventArgs e)//LOG save
        { System.IO.File.WriteAllText("LOG-TEXT.TXT", TextBoxLED.Text); }
        private void LOGCLR_Click(object sender, EventArgs e)//LOG clr
        { System.IO.File.Delete("LOG-TEXT.TXT"); }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)//Check Exit
        {
            string[] a = new string[3];
            a[0] = TextBoxLED.BackColor.Name;
            a[1] = TextBoxLED.Font.Name;
            a[2] = TextBoxLED.Font.Size.ToString();
            System.IO.File.WriteAllLines("LOG.TXT", a);
            newToolStripMenuItem_Click(null, null);
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)//Copy
        { Clipboard.SetText(TextBoxLED.SelectedText); }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)//Paste
        { TextBoxLED.SelectedText = Clipboard.GetText(); }
        private void delToolStripMenuItem_Click(object sender, EventArgs e)//Del
        { TextBoxLED.SelectedText = ""; }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)//Cut
        { copyToolStripMenuItem_Click(null, null); delToolStripMenuItem_Click(null, null); }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)//Select ALL
        { TextBoxLED.SelectAll(); }
        private void findToolStripMenuItem_Click(object sender, EventArgs e)//Find
        { FormFind f1 = new FormFind(this); f1.Show(this); }

        public Boolean FindFun(string s)
        { //FIND
            int i;
            i = TextBoxLED.Text.IndexOf(s);
            if (i == -1)
            {
                MessageBox.Show("Not Found");
                return false;
            }
            else
            {
                TextBoxLED.SelectionStart = i;
                TextBoxLED.SelectionLength = s.Length;
                TextBoxLED.Focus();
                return true;
            }
        }
        /// <summary>
        /// متدی برای جستجو در جعبه متن
        /// </summary>
        /// <param name="s">رشته مورد جستجو</param>
        /// <param name="compairtype">نوع مقایسه</param>
        /// <param name="RL">نوع مقایسه</param>
        /// <returns></returns>
        public Boolean FindFunNext(string s, StringComparison compairtype = StringComparison.OrdinalIgnoreCase, Boolean RL = true)
        { //FIND Next
            int i = 0;
            //RL
            if (RL == true)
                i = TextBoxLED.Text.IndexOf(s, TextBoxLED.SelectionStart + 1, compairtype);
            else
                i = TextBoxLED.Text.LastIndexOf(s, TextBoxLED.SelectionStart - 1, compairtype);

            if (i == -1)
            {
                MessageBox.Show("Not Found");
                return false;
            }
            else
            {
                TextBoxLED.SelectionStart = i;
                TextBoxLED.SelectionLength = s.Length;
                TextBoxLED.Focus();
                return true;
            }
        }

        //private void undoToolStripMenuItem_Click(object sender, EventArgs e)//Undo
        //{ TextBoxLED.Text = NotePadUndo.Undo(); }

        //private void redoToolStripMenuItem_Click(object sender, EventArgs e)//Redo
        //{ TextBoxLED.Text = NotePadUndo.Redo(); }
        //private void Form1_KeyUp(object sender, KeyEventArgs e)//KeyUp
        //{ NotePadUndo.settext(TextBoxLED.Text); }
        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)//Replace
        { Replace f = new Replace(this); f.Show(this); }
        //Replace FUN
        /// <summary>
        /// متدی برای جاگیزین کردن متن انتخاب شده
        /// </summary>
        /// <param name="str">رشته مورد نظر </param>
        public void ReplaceFun(string str)
        {
            if (TextBoxLED.SelectionLength > 0)
                TextBoxLED.SelectedText = str;
        }
        // Replace All FUN
        /// <summary>
        /// متدی براری جایگزاری همه موارد
        /// </summary>
        /// <param name="str1">رشته جستحو</param>
        /// <param name="str2">رشته جایگزینی</param>
        /// <param name="cmptype">نوع مقایسه</param>
        /// <param name="LR">جهت مقایسه</param>
        public void ReplaceAllFun(string str1, string str2, StringComparison cmptype, Boolean LR)
        {
            while (FindFunNext(str1, cmptype, LR))
                ReplaceFun(str2);
        }

        private void gotoToolStripMenuItem1_Click(object sender, EventArgs e)
        { //Goto
            Goto f = new Goto(this);
            f.ShowDialog();
        }
        /// <summary>
        /// متدی برای گرفتن تعداد خطوط
        /// </summary>
        /// <returns></returns>
        public int getline()
        {
            return TextBoxLED.Lines.Count();
        }
        public void gotoFun(int x)
        {
            TextBoxLED.SelectionStart = TextBoxLED.GetFirstCharIndexFromLine(x);
        }
        // SET RC
        public void SetRC()
        {
            int row = TextBoxLED.GetLineFromCharIndex(TextBoxLED.SelectionStart) + 1;
            int col = TextBoxLED.SelectionStart - TextBoxLED.GetFirstCharIndexOfCurrentLine() + 1;
            LBLRowCol.Text = "Ln" + row.ToString() + ",Col" + col.ToString();
        }

        private void TextBoxLED_Click(object sender, EventArgs e)
        { SetRC(); } //Click - RC SET Line
        private void TextBoxLED_KeyUp(object sender, KeyEventArgs e)
        { SetRC(); } //KeyUp - RC SET Line
                     //----------  Menu Lock  -----------//
        private void topToolStripMenuItem_Click(object sender, EventArgs e)
        { menuStrip1.Dock = DockStyle.Top; Blackbtn.Visible = false; Whitebtn.Visible = false; LOG.Visible = false; LOGCLR.Visible = false; HiddemMenu.Visible = true; } // Menu Top
        private void botToolStripMenuItem_Click(object sender, EventArgs e)
        { menuStrip1.Dock = DockStyle.Bottom; Blackbtn.Visible = false; Whitebtn.Visible = false; LOG.Visible = false; LOGCLR.Visible = false; HiddemMenu.Visible = true; } // Menu Bottom
        private void rhiteToolStripMenuItem_Click(object sender, EventArgs e)
        { menuStrip1.Dock = DockStyle.Right; Blackbtn.Visible = false; Whitebtn.Visible = false; LOG.Visible = false; LOGCLR.Visible = false; HiddemMenu.Visible = true; } // Menu Right
        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        { menuStrip1.Dock = DockStyle.Left; Blackbtn.Visible = true; Whitebtn.Visible = true; LOG.Visible = true; LOGCLR.Visible = true; HiddemMenu.Visible = false; } // Menu Left
                                                                                                                                                                       //----------  Menu Lock  -----------//
        private void blackStyleToolStripMenuItem_Click(object sender, EventArgs e) // BlackH-BTN
        { TextBoxLED.BackColor = Color.Black; TextBoxLED.ForeColor = Color.White; menuStrip1.BackColor = Color.Black; menuStrip1.ForeColor = Color.Red; }
        private void whiteStyleToolStripMenuItem_Click(object sender, EventArgs e)// whiteH-BTN
        { TextBoxLED.BackColor = Color.White; TextBoxLED.ForeColor = Color.Black; menuStrip1.BackColor = Color.WhiteSmoke; menuStrip1.ForeColor = Color.Black; }
        private void lOGToolStripMenuItem_Click(object sender, EventArgs e) //LOG HiddBTN
        { System.IO.File.WriteAllText("LOG.TXT", TextBoxLED.Text); }
        private void lOGCLRToolStripMenuItem_Click(object sender, EventArgs e) //LOG HiddBTNCLR
        { System.IO.File.Delete("LOG.TXT"); }
        //ON OFF Button
        public void setonoff()
        {
            copyToolStripMenuItem.Enabled = Convert.ToBoolean(TextBoxLED.SelectionLength);
            cutToolStripMenuItem.Enabled = TextBoxLED.SelectionLength > 0;
            delToolStripMenuItem.Enabled = TextBoxLED.SelectionLength > 0;
            pasteToolStripMenuItem.Enabled = Clipboard.ContainsText();
            findToolStripMenuItem.Enabled = TextBoxLED.Text.Length > 0;
            gotoToolStripMenuItem1.Enabled = TextBoxLED.TextLength > 0;
            saveAsToolStripMenuItem.Enabled = !saveflag;
        }
        private void abotToolStripMenuItem_DropDownOpening(object sender, EventArgs e)// Menu on off
        { setonoff(); }
        private void printToolStripMenuItem_Click(object sender, EventArgs e) //Print
        {
            DialogResult x;
            printDialog1.Document = printDocument1;
            x = printDialog1.ShowDialog();
            if (x == DialogResult.OK)
            { printDocument1.Print(); }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)// Print Page
        { e.Graphics.DrawString(TextBoxLED.Text, TextBoxLED.Font, Brushes.Black, 0, 0); }
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e) //Print Previwe
        { printPreviewDialog1.Document = printDocument1; printPreviewDialog1.ShowDialog(); }
    }
}

    //Undo-Redo
    //    public class MyUndo { //Undo
    //     string[] temp = new string[100];
    //     int index; int currentposition;
    // public MyUndo(){
    //    index = 0; currentposition = 0;}
    // public void settext(string s){
    //    temp[index] = s; currentposition = index; ++index;}
    // public string Undo(){
    // if (currentposition > 0) return temp[--currentposition]; return null;}
    // public string Redo(){
    // if (currentposition < index) return temp[++currentposition]; return null;}
    //   } //END My Undo
    //}
