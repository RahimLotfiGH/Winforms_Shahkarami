namespace FormSabtename
{
    partial class frmInscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscription));
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.txtDigit = new System.Windows.Forms.TextBox();
            this.GbxLetterDigit = new System.Windows.Forms.GroupBox();
            this.lblDigit = new System.Windows.Forms.Label();
            this.lblLetter = new System.Windows.Forms.Label();
            this.GbxLetterDigit.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLetter
            // 
            this.txtLetter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtLetter.Location = new System.Drawing.Point(102, 34);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLetter.Size = new System.Drawing.Size(37, 20);
            this.txtLetter.TabIndex = 0;
            this.txtLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDigit
            // 
            this.txtDigit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDigit.Location = new System.Drawing.Point(102, 78);
            this.txtDigit.Name = "txtDigit";
            this.txtDigit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDigit.Size = new System.Drawing.Size(37, 20);
            this.txtDigit.TabIndex = 5;
            this.txtDigit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GbxLetterDigit
            // 
            this.GbxLetterDigit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GbxLetterDigit.Controls.Add(this.lblDigit);
            this.GbxLetterDigit.Controls.Add(this.lblLetter);
            this.GbxLetterDigit.Controls.Add(this.txtLetter);
            this.GbxLetterDigit.Controls.Add(this.txtDigit);
            this.GbxLetterDigit.Location = new System.Drawing.Point(24, 33);
            this.GbxLetterDigit.Name = "GbxLetterDigit";
            this.GbxLetterDigit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GbxLetterDigit.Size = new System.Drawing.Size(193, 119);
            this.GbxLetterDigit.TabIndex = 6;
            this.GbxLetterDigit.TabStop = false;
            this.GbxLetterDigit.Text = "تبدیل حروف به عدد";
            // 
            // lblDigit
            // 
            this.lblDigit.AutoSize = true;
            this.lblDigit.Location = new System.Drawing.Point(157, 81);
            this.lblDigit.Name = "lblDigit";
            this.lblDigit.Size = new System.Drawing.Size(24, 13);
            this.lblDigit.TabIndex = 7;
            this.lblDigit.Text = "عدد";
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = true;
            this.lblLetter.Location = new System.Drawing.Point(157, 37);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(28, 13);
            this.lblLetter.TabIndex = 6;
            this.lblLetter.Text = "حرف";
            // 
            // frmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GbxLetterDigit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInscription";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "فرم ثبت نام";
            this.GbxLetterDigit.ResumeLayout(false);
            this.GbxLetterDigit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.TextBox txtDigit;
        private System.Windows.Forms.GroupBox GbxLetterDigit;
        private System.Windows.Forms.Label lblDigit;
        private System.Windows.Forms.Label lblLetter;
    }
}

