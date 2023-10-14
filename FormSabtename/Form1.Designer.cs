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
            this.GbNameAndAge = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.GbForeColor = new System.Windows.Forms.GroupBox();
            this.RadioBtnForekBlue = new System.Windows.Forms.RadioButton();
            this.RadioBtnForeBlack = new System.Windows.Forms.RadioButton();
            this.RadioBtnForeGreen = new System.Windows.Forms.RadioButton();
            this.GbBackColor = new System.Windows.Forms.GroupBox();
            this.RadioBtnBackYellow = new System.Windows.Forms.RadioButton();
            this.RadioBtnBackGray = new System.Windows.Forms.RadioButton();
            this.RadioBtnBackBlue = new System.Windows.Forms.RadioButton();
            this.checkedListBoxLanguage = new System.Windows.Forms.CheckedListBox();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.GbxLetterDigit.SuspendLayout();
            this.GbNameAndAge.SuspendLayout();
            this.GbForeColor.SuspendLayout();
            this.GbBackColor.SuspendLayout();
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
            this.txtLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
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
            // GbNameAndAge
            // 
            this.GbNameAndAge.Controls.Add(this.txtAge);
            this.GbNameAndAge.Controls.Add(this.txtName);
            this.GbNameAndAge.Controls.Add(this.lblAge);
            this.GbNameAndAge.Controls.Add(this.lblName);
            this.GbNameAndAge.Location = new System.Drawing.Point(17, 170);
            this.GbNameAndAge.Name = "GbNameAndAge";
            this.GbNameAndAge.Size = new System.Drawing.Size(200, 100);
            this.GbNameAndAge.TabIndex = 7;
            this.GbNameAndAge.TabStop = false;
            this.GbNameAndAge.Text = "گرفتن نام و سن";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(29, 65);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 3;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(29, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            this.txtName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtName_PreviewKeyDown);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(157, 68);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(23, 13);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "سن";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(157, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(20, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "نام";
            // 
            // GbForeColor
            // 
            this.GbForeColor.Controls.Add(this.RadioBtnForekBlue);
            this.GbForeColor.Controls.Add(this.RadioBtnForeBlack);
            this.GbForeColor.Controls.Add(this.RadioBtnForeGreen);
            this.GbForeColor.Location = new System.Drawing.Point(240, 33);
            this.GbForeColor.Name = "GbForeColor";
            this.GbForeColor.Size = new System.Drawing.Size(200, 100);
            this.GbForeColor.TabIndex = 8;
            this.GbForeColor.TabStop = false;
            this.GbForeColor.Text = "تغییر رنگ قلم";
            // 
            // RadioBtnForekBlue
            // 
            this.RadioBtnForekBlue.AutoSize = true;
            this.RadioBtnForekBlue.Location = new System.Drawing.Point(151, 79);
            this.RadioBtnForekBlue.Name = "RadioBtnForekBlue";
            this.RadioBtnForekBlue.Size = new System.Drawing.Size(43, 17);
            this.RadioBtnForekBlue.TabIndex = 2;
            this.RadioBtnForekBlue.TabStop = true;
            this.RadioBtnForekBlue.Text = "آبی";
            this.RadioBtnForekBlue.UseVisualStyleBackColor = true;
            this.RadioBtnForekBlue.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // RadioBtnForeBlack
            // 
            this.RadioBtnForeBlack.AutoSize = true;
            this.RadioBtnForeBlack.Location = new System.Drawing.Point(146, 56);
            this.RadioBtnForeBlack.Name = "RadioBtnForeBlack";
            this.RadioBtnForeBlack.Size = new System.Drawing.Size(48, 17);
            this.RadioBtnForeBlack.TabIndex = 1;
            this.RadioBtnForeBlack.TabStop = true;
            this.RadioBtnForeBlack.Text = "سیاه";
            this.RadioBtnForeBlack.UseVisualStyleBackColor = true;
            this.RadioBtnForeBlack.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // RadioBtnForeGreen
            // 
            this.RadioBtnForeGreen.AutoSize = true;
            this.RadioBtnForeGreen.Location = new System.Drawing.Point(151, 33);
            this.RadioBtnForeGreen.Name = "RadioBtnForeGreen";
            this.RadioBtnForeGreen.Size = new System.Drawing.Size(43, 17);
            this.RadioBtnForeGreen.TabIndex = 0;
            this.RadioBtnForeGreen.TabStop = true;
            this.RadioBtnForeGreen.Text = "سبز";
            this.RadioBtnForeGreen.UseVisualStyleBackColor = true;
            this.RadioBtnForeGreen.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // GbBackColor
            // 
            this.GbBackColor.Controls.Add(this.RadioBtnBackYellow);
            this.GbBackColor.Controls.Add(this.RadioBtnBackGray);
            this.GbBackColor.Controls.Add(this.RadioBtnBackBlue);
            this.GbBackColor.Location = new System.Drawing.Point(240, 170);
            this.GbBackColor.Name = "GbBackColor";
            this.GbBackColor.Size = new System.Drawing.Size(200, 100);
            this.GbBackColor.TabIndex = 9;
            this.GbBackColor.TabStop = false;
            this.GbBackColor.Text = "تغییر رنگ زمینه";
            // 
            // RadioBtnBackYellow
            // 
            this.RadioBtnBackYellow.AutoSize = true;
            this.RadioBtnBackYellow.Location = new System.Drawing.Point(154, 77);
            this.RadioBtnBackYellow.Name = "RadioBtnBackYellow";
            this.RadioBtnBackYellow.Size = new System.Drawing.Size(40, 17);
            this.RadioBtnBackYellow.TabIndex = 3;
            this.RadioBtnBackYellow.TabStop = true;
            this.RadioBtnBackYellow.Text = "زرد";
            this.RadioBtnBackYellow.UseVisualStyleBackColor = true;
            this.RadioBtnBackYellow.Click += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // RadioBtnBackGray
            // 
            this.RadioBtnBackGray.AutoSize = true;
            this.RadioBtnBackGray.Location = new System.Drawing.Point(123, 53);
            this.RadioBtnBackGray.Name = "RadioBtnBackGray";
            this.RadioBtnBackGray.Size = new System.Drawing.Size(71, 17);
            this.RadioBtnBackGray.TabIndex = 2;
            this.RadioBtnBackGray.TabStop = true;
            this.RadioBtnBackGray.Text = "خاکستری";
            this.RadioBtnBackGray.UseVisualStyleBackColor = true;
            this.RadioBtnBackGray.Click += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // RadioBtnBackBlue
            // 
            this.RadioBtnBackBlue.AutoSize = true;
            this.RadioBtnBackBlue.Location = new System.Drawing.Point(151, 30);
            this.RadioBtnBackBlue.Name = "RadioBtnBackBlue";
            this.RadioBtnBackBlue.Size = new System.Drawing.Size(43, 17);
            this.RadioBtnBackBlue.TabIndex = 1;
            this.RadioBtnBackBlue.TabStop = true;
            this.RadioBtnBackBlue.Text = "آبی";
            this.RadioBtnBackBlue.UseVisualStyleBackColor = true;
            this.RadioBtnBackBlue.Click += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // checkedListBoxLanguage
            // 
            this.checkedListBoxLanguage.FormattingEnabled = true;
            this.checkedListBoxLanguage.Items.AddRange(new object[] {
            "فارسی ",
            "انگلیسی",
            "فرانسوی",
            "آلمانی"});
            this.checkedListBoxLanguage.Location = new System.Drawing.Point(462, 37);
            this.checkedListBoxLanguage.Name = "checkedListBoxLanguage";
            this.checkedListBoxLanguage.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxLanguage.TabIndex = 10;
            this.checkedListBoxLanguage.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxLanguage_ItemCheck);
            // 
            // btnLanguage
            // 
            this.btnLanguage.Location = new System.Drawing.Point(487, 153);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(75, 23);
            this.btnLanguage.TabIndex = 11;
            this.btnLanguage.Text = "Go";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // frmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.checkedListBoxLanguage);
            this.Controls.Add(this.GbBackColor);
            this.Controls.Add(this.GbForeColor);
            this.Controls.Add(this.GbNameAndAge);
            this.Controls.Add(this.GbxLetterDigit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInscription";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ثبت نام";
            this.GbxLetterDigit.ResumeLayout(false);
            this.GbxLetterDigit.PerformLayout();
            this.GbNameAndAge.ResumeLayout(false);
            this.GbNameAndAge.PerformLayout();
            this.GbForeColor.ResumeLayout(false);
            this.GbForeColor.PerformLayout();
            this.GbBackColor.ResumeLayout(false);
            this.GbBackColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.TextBox txtDigit;
        private System.Windows.Forms.GroupBox GbxLetterDigit;
        private System.Windows.Forms.Label lblDigit;
        private System.Windows.Forms.Label lblLetter;
        private System.Windows.Forms.GroupBox GbNameAndAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox GbForeColor;
        private System.Windows.Forms.GroupBox GbBackColor;
        private System.Windows.Forms.RadioButton RadioBtnForekBlue;
        private System.Windows.Forms.RadioButton RadioBtnForeBlack;
        private System.Windows.Forms.RadioButton RadioBtnForeGreen;
        private System.Windows.Forms.RadioButton RadioBtnBackYellow;
        private System.Windows.Forms.RadioButton RadioBtnBackGray;
        private System.Windows.Forms.RadioButton RadioBtnBackBlue;
        private System.Windows.Forms.CheckedListBox checkedListBoxLanguage;
        private System.Windows.Forms.Button btnLanguage;
    }
}

