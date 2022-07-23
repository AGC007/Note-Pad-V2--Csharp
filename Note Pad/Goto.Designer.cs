namespace Note_Pad
{
    partial class Goto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goto));
            this.GOTOBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.TextLEDGOTO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GOTOBTN
            // 
            this.GOTOBTN.Location = new System.Drawing.Point(90, 60);
            this.GOTOBTN.Name = "GOTOBTN";
            this.GOTOBTN.Size = new System.Drawing.Size(75, 23);
            this.GOTOBTN.TabIndex = 1;
            this.GOTOBTN.Text = "Goto";
            this.GOTOBTN.UseVisualStyleBackColor = true;
            this.GOTOBTN.Click += new System.EventHandler(this.GOTOBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(171, 60);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 2;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // TextLEDGOTO
            // 
            this.TextLEDGOTO.Location = new System.Drawing.Point(12, 25);
            this.TextLEDGOTO.Multiline = true;
            this.TextLEDGOTO.Name = "TextLEDGOTO";
            this.TextLEDGOTO.Size = new System.Drawing.Size(232, 29);
            this.TextLEDGOTO.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Line Number :";
            // 
            // Goto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 92);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextLEDGOTO);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.GOTOBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Goto";
            this.Text = "Goto...";
            this.Load += new System.EventHandler(this.Goto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GOTOBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.TextBox TextLEDGOTO;
        private System.Windows.Forms.Label label1;
    }
}