namespace FormSabtename
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 27);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(139, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(126, 72);
            this.textLastName.Name = "textLastName";
            this.textLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textLastName.Size = new System.Drawing.Size(139, 20);
            this.textLastName.TabIndex = 1;
            this.textLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(126, 120);
            this.textAge.Name = "textAge";
            this.textAge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textAge.Size = new System.Drawing.Size(139, 20);
            this.textAge.TabIndex = 2;
            this.textAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(145, 172);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(100, 23);
            this.lbl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label lbl;
    }
}

