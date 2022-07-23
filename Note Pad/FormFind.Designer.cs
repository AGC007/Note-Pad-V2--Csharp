namespace Note_Pad
{
    partial class FormFind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFind));
            this.FindBTN = new System.Windows.Forms.Button();
            this.CANFindBTN = new System.Windows.Forms.Button();
            this.FindL = new System.Windows.Forms.Label();
            this.TextLEDFind = new System.Windows.Forms.TextBox();
            this.CheckMath = new System.Windows.Forms.CheckBox();
            this.DirectionFind = new System.Windows.Forms.GroupBox();
            this.DownFind = new System.Windows.Forms.RadioButton();
            this.UpFind = new System.Windows.Forms.RadioButton();
            this.FindNext = new System.Windows.Forms.Button();
            this.DirectionFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindBTN
            // 
            this.FindBTN.Location = new System.Drawing.Point(239, 12);
            this.FindBTN.Name = "FindBTN";
            this.FindBTN.Size = new System.Drawing.Size(75, 23);
            this.FindBTN.TabIndex = 0;
            this.FindBTN.Text = "Find";
            this.FindBTN.UseVisualStyleBackColor = true;
            this.FindBTN.Click += new System.EventHandler(this.FindBTN_Click);
            // 
            // CANFindBTN
            // 
            this.CANFindBTN.Location = new System.Drawing.Point(239, 70);
            this.CANFindBTN.Name = "CANFindBTN";
            this.CANFindBTN.Size = new System.Drawing.Size(75, 23);
            this.CANFindBTN.TabIndex = 1;
            this.CANFindBTN.Text = "Close";
            this.CANFindBTN.UseVisualStyleBackColor = true;
            this.CANFindBTN.Click += new System.EventHandler(this.CANFindBTN_Click);
            // 
            // FindL
            // 
            this.FindL.AutoSize = true;
            this.FindL.Location = new System.Drawing.Point(4, 15);
            this.FindL.Name = "FindL";
            this.FindL.Size = new System.Drawing.Size(62, 13);
            this.FindL.TabIndex = 2;
            this.FindL.Text = "Find What :";
            // 
            // TextLEDFind
            // 
            this.TextLEDFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLEDFind.Location = new System.Drawing.Point(72, 12);
            this.TextLEDFind.Multiline = true;
            this.TextLEDFind.Name = "TextLEDFind";
            this.TextLEDFind.Size = new System.Drawing.Size(161, 23);
            this.TextLEDFind.TabIndex = 3;
            // 
            // CheckMath
            // 
            this.CheckMath.AutoSize = true;
            this.CheckMath.Location = new System.Drawing.Point(12, 63);
            this.CheckMath.Name = "CheckMath";
            this.CheckMath.Size = new System.Drawing.Size(83, 17);
            this.CheckMath.TabIndex = 4;
            this.CheckMath.Text = "Match Case";
            this.CheckMath.UseVisualStyleBackColor = true;
            // 
            // DirectionFind
            // 
            this.DirectionFind.Controls.Add(this.DownFind);
            this.DirectionFind.Controls.Add(this.UpFind);
            this.DirectionFind.Location = new System.Drawing.Point(114, 44);
            this.DirectionFind.Name = "DirectionFind";
            this.DirectionFind.Size = new System.Drawing.Size(119, 46);
            this.DirectionFind.TabIndex = 5;
            this.DirectionFind.TabStop = false;
            this.DirectionFind.Text = "Direction";
            // 
            // DownFind
            // 
            this.DownFind.AutoSize = true;
            this.DownFind.Checked = true;
            this.DownFind.Location = new System.Drawing.Point(51, 19);
            this.DownFind.Name = "DownFind";
            this.DownFind.Size = new System.Drawing.Size(53, 17);
            this.DownFind.TabIndex = 1;
            this.DownFind.TabStop = true;
            this.DownFind.Text = "Down";
            this.DownFind.UseVisualStyleBackColor = true;
            // 
            // UpFind
            // 
            this.UpFind.AutoSize = true;
            this.UpFind.Location = new System.Drawing.Point(6, 19);
            this.UpFind.Name = "UpFind";
            this.UpFind.Size = new System.Drawing.Size(39, 17);
            this.UpFind.TabIndex = 0;
            this.UpFind.Text = "Up";
            this.UpFind.UseVisualStyleBackColor = true;
            // 
            // FindNext
            // 
            this.FindNext.Location = new System.Drawing.Point(239, 41);
            this.FindNext.Name = "FindNext";
            this.FindNext.Size = new System.Drawing.Size(75, 23);
            this.FindNext.TabIndex = 6;
            this.FindNext.Text = "Find Next";
            this.FindNext.UseVisualStyleBackColor = true;
            this.FindNext.Click += new System.EventHandler(this.FindNext_Click);
            // 
            // FormFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 101);
            this.Controls.Add(this.FindNext);
            this.Controls.Add(this.DirectionFind);
            this.Controls.Add(this.CheckMath);
            this.Controls.Add(this.TextLEDFind);
            this.Controls.Add(this.FindL);
            this.Controls.Add(this.CANFindBTN);
            this.Controls.Add(this.FindBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find...";
            this.DirectionFind.ResumeLayout(false);
            this.DirectionFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindBTN;
        private System.Windows.Forms.Label FindL;
        private System.Windows.Forms.Button FindNext;
        protected System.Windows.Forms.Button CANFindBTN;
        protected System.Windows.Forms.TextBox TextLEDFind;
        protected System.Windows.Forms.CheckBox CheckMath;
        protected System.Windows.Forms.GroupBox DirectionFind;
        protected System.Windows.Forms.RadioButton DownFind;
        protected System.Windows.Forms.RadioButton UpFind;
    }
}