namespace Note_Pad
{
    partial class Replace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replace));
            this.ReplaceAllBTN = new System.Windows.Forms.Button();
            this.ReplaceBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReplaceTEXTLED = new System.Windows.Forms.TextBox();
            this.DirectionFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // CANFindBTN
            // 
            this.CANFindBTN.Location = new System.Drawing.Point(239, 129);
            // 
            // CheckMath
            // 
            this.CheckMath.Location = new System.Drawing.Point(15, 95);
            // 
            // DirectionFind
            // 
            this.DirectionFind.Location = new System.Drawing.Point(114, 76);
            // 
            // ReplaceAllBTN
            // 
            this.ReplaceAllBTN.Location = new System.Drawing.Point(239, 99);
            this.ReplaceAllBTN.Name = "ReplaceAllBTN";
            this.ReplaceAllBTN.Size = new System.Drawing.Size(75, 23);
            this.ReplaceAllBTN.TabIndex = 7;
            this.ReplaceAllBTN.Text = "Replace All";
            this.ReplaceAllBTN.UseVisualStyleBackColor = true;
            this.ReplaceAllBTN.Click += new System.EventHandler(this.ReplaceAllBTN_Click);
            // 
            // ReplaceBTN
            // 
            this.ReplaceBTN.Location = new System.Drawing.Point(239, 70);
            this.ReplaceBTN.Name = "ReplaceBTN";
            this.ReplaceBTN.Size = new System.Drawing.Size(75, 23);
            this.ReplaceBTN.TabIndex = 8;
            this.ReplaceBTN.Text = "Replace";
            this.ReplaceBTN.UseVisualStyleBackColor = true;
            this.ReplaceBTN.Click += new System.EventHandler(this.ReplaceBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Replace:";
            // 
            // ReplaceTEXTLED
            // 
            this.ReplaceTEXTLED.Location = new System.Drawing.Point(72, 41);
            this.ReplaceTEXTLED.Multiline = true;
            this.ReplaceTEXTLED.Name = "ReplaceTEXTLED";
            this.ReplaceTEXTLED.Size = new System.Drawing.Size(161, 23);
            this.ReplaceTEXTLED.TabIndex = 10;
            // 
            // Replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(330, 158);
            this.Controls.Add(this.ReplaceTEXTLED);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReplaceBTN);
            this.Controls.Add(this.ReplaceAllBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Replace";
            this.Text = "Replace...";
            this.Controls.SetChildIndex(this.CANFindBTN, 0);
            this.Controls.SetChildIndex(this.TextLEDFind, 0);
            this.Controls.SetChildIndex(this.CheckMath, 0);
            this.Controls.SetChildIndex(this.DirectionFind, 0);
            this.Controls.SetChildIndex(this.ReplaceAllBTN, 0);
            this.Controls.SetChildIndex(this.ReplaceBTN, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ReplaceTEXTLED, 0);
            this.DirectionFind.ResumeLayout(false);
            this.DirectionFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReplaceAllBTN;
        private System.Windows.Forms.Button ReplaceBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReplaceTEXTLED;
    }
}
