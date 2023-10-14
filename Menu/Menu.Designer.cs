namespace Menu
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem fileMenuItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTxtBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.tNew = new System.Windows.Forms.ToolStripButton();
            this.tCopy = new System.Windows.Forms.ToolStripButton();
            this.tPaste = new System.Windows.Forms.ToolStripButton();
            this.tCut = new System.Windows.Forms.ToolStripButton();
            this.tSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tColor = new System.Windows.Forms.ToolStripButton();
            this.tFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PicBoxBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.copyRightStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelPicLgAndLbl = new System.Windows.Forms.Panel();
            this.picBoxLg = new System.Windows.Forms.PictureBox();
            this.lblPicLgPanel = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelPicLgAndLbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fileMenuItem
            // 
            fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.toolStripMenuItem1,
            this.ExitMenuItem});
            fileMenuItem.Name = "fileMenuItem";
            fileMenuItem.Size = new System.Drawing.Size(37, 20);
            fileMenuItem.Text = "File";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(103, 22);
            this.NewMenuItem.Text = "New";
            this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(103, 22);
            this.OpenMenuItem.Text = "Open";
            this.OpenMenuItem.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(103, 22);
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(103, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // richTxtBox
            // 
            this.richTxtBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtBox.ContextMenuStrip = this.contextMenuStrip1;
            this.richTxtBox.Location = new System.Drawing.Point(8, 61);
            this.richTxtBox.Name = "richTxtBox";
            this.richTxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTxtBox.Size = new System.Drawing.Size(699, 414);
            this.richTxtBox.TabIndex = 0;
            this.richTxtBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 70);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyMenuItem,
            this.cutMenuItem,
            this.pasteMenuItem,
            this.colorMenuItem,
            this.fontMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyMenuItem.Text = "Copy";
            this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Name = "cutMenuItem";
            this.cutMenuItem.Size = new System.Drawing.Size(103, 22);
            this.cutMenuItem.Text = "Cut";
            this.cutMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pasteMenuItem.Text = "Paste";
            this.pasteMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // colorMenuItem
            // 
            this.colorMenuItem.Name = "colorMenuItem";
            this.colorMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorMenuItem.Text = "Color";
            this.colorMenuItem.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // fontMenuItem
            // 
            this.fontMenuItem.Name = "fontMenuItem";
            this.fontMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fontMenuItem.Text = "Font";
            this.fontMenuItem.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.LightCyan;
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tNew,
            this.tCopy,
            this.tPaste,
            this.tCut,
            this.tSave,
            this.toolStripSeparator1,
            this.tColor,
            this.tFont,
            this.toolStripSeparator2,
            this.PicBoxBtn,
            this.toolStripSeparator3});
            this.ToolBar.Location = new System.Drawing.Point(0, 24);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(834, 25);
            this.ToolBar.TabIndex = 9;
            // 
            // tNew
            // 
            this.tNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tNew.Image = global::Menu.Properties.Resources.new_25355;
            this.tNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tNew.Name = "tNew";
            this.tNew.Size = new System.Drawing.Size(23, 22);
            this.tNew.Text = "New";
            this.tNew.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // tCopy
            // 
            this.tCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tCopy.Image = global::Menu.Properties.Resources.copy_23057;
            this.tCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tCopy.Name = "tCopy";
            this.tCopy.Size = new System.Drawing.Size(23, 22);
            this.tCopy.Text = "Copy";
            this.tCopy.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // tPaste
            // 
            this.tPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tPaste.Image = global::Menu.Properties.Resources.copy_paste_document_file_1557;
            this.tPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tPaste.Name = "tPaste";
            this.tPaste.Size = new System.Drawing.Size(23, 22);
            this.tPaste.Text = "Paste";
            this.tPaste.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // tCut
            // 
            this.tCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tCut.Image = global::Menu.Properties.Resources.cut_icon_icons_com_52391;
            this.tCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tCut.Name = "tCut";
            this.tCut.Size = new System.Drawing.Size(23, 22);
            this.tCut.Text = "Cut";
            this.tCut.Click += new System.EventHandler(this.cutMenuItem_Click);
            // 
            // tSave
            // 
            this.tSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSave.Image = global::Menu.Properties.Resources.save_78348;
            this.tSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSave.Name = "tSave";
            this.tSave.Size = new System.Drawing.Size(23, 22);
            this.tSave.Text = "Save";
            this.tSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tColor
            // 
            this.tColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tColor.Image = global::Menu.Properties.Resources.Photos_31086;
            this.tColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tColor.Name = "tColor";
            this.tColor.Size = new System.Drawing.Size(23, 22);
            this.tColor.Text = "Color";
            this.tColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tFont
            // 
            this.tFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tFont.Image = global::Menu.Properties.Resources.Oxygen_Icons_org_Oxygen_Apps_preferences_desktop_font_256;
            this.tFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tFont.Name = "tFont";
            this.tFont.Size = new System.Drawing.Size(23, 22);
            this.tFont.Text = "Font";
            this.tFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // PicBoxBtn
            // 
            this.PicBoxBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PicBoxBtn.Image = global::Menu.Properties.Resources.picture_icon_251069;
            this.PicBoxBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PicBoxBtn.Name = "PicBoxBtn";
            this.PicBoxBtn.Size = new System.Drawing.Size(23, 22);
            this.PicBoxBtn.Text = "Add Image to Picture Box";
            this.PicBoxBtn.Click += new System.EventHandler(this.picBoxLg_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(734, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(2);
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseHover);
            this.btnSave.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.Location = new System.Drawing.Point(734, 219);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(2);
            this.btnOpen.Size = new System.Drawing.Size(75, 40);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            this.btnOpen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseHover);
            this.btnOpen.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnOpen.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnFont
            // 
            this.btnFont.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFont.Location = new System.Drawing.Point(734, 311);
            this.btnFont.Name = "btnFont";
            this.btnFont.Padding = new System.Windows.Forms.Padding(2);
            this.btnFont.Size = new System.Drawing.Size(75, 40);
            this.btnFont.TabIndex = 12;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            this.btnFont.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseHover);
            this.btnFont.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnFont.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnColor.Location = new System.Drawing.Point(734, 357);
            this.btnColor.Name = "btnColor";
            this.btnColor.Padding = new System.Windows.Forms.Padding(2);
            this.btnColor.Size = new System.Drawing.Size(75, 40);
            this.btnColor.TabIndex = 13;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            this.btnColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseHover);
            this.btnColor.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnColor.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnFolder
            // 
            this.btnFolder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFolder.Location = new System.Drawing.Point(734, 403);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Padding = new System.Windows.Forms.Padding(2);
            this.btnFolder.Size = new System.Drawing.Size(75, 40);
            this.btnFolder.TabIndex = 14;
            this.btnFolder.Text = "Folder";
            this.btnFolder.UseVisualStyleBackColor = false;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            this.btnFolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseHover);
            this.btnFolder.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnFolder.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyRightStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // copyRightStatus
            // 
            this.copyRightStatus.Name = "copyRightStatus";
            this.copyRightStatus.Size = new System.Drawing.Size(143, 17);
            this.copyRightStatus.Text = "Copyright © 2023 Heilton";
            // 
            // panelPicLgAndLbl
            // 
            this.panelPicLgAndLbl.Controls.Add(this.picBoxLg);
            this.panelPicLgAndLbl.Controls.Add(this.lblPicLgPanel);
            this.panelPicLgAndLbl.Location = new System.Drawing.Point(699, 61);
            this.panelPicLgAndLbl.Name = "panelPicLgAndLbl";
            this.panelPicLgAndLbl.Size = new System.Drawing.Size(135, 183);
            this.panelPicLgAndLbl.TabIndex = 17;
            this.panelPicLgAndLbl.Visible = false;
            this.panelPicLgAndLbl.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // picBoxLg
            // 
            this.picBoxLg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxLg.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBoxLg.Image = global::Menu.Properties.Resources.Screenshot_12;
            this.picBoxLg.Location = new System.Drawing.Point(0, 0);
            this.picBoxLg.Name = "picBoxLg";
            this.picBoxLg.Size = new System.Drawing.Size(135, 154);
            this.picBoxLg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLg.TabIndex = 16;
            this.picBoxLg.TabStop = false;
            this.picBoxLg.Click += new System.EventHandler(this.picBox_Click);
            this.picBoxLg.MouseLeave += new System.EventHandler(this.picBoxLg_MouseLeave);
            // 
            // lblPicLgPanel
            // 
            this.lblPicLgPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPicLgPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPicLgPanel.Location = new System.Drawing.Point(0, 157);
            this.lblPicLgPanel.Name = "lblPicLgPanel";
            this.lblPicLgPanel.Padding = new System.Windows.Forms.Padding(2);
            this.lblPicLgPanel.Size = new System.Drawing.Size(135, 26);
            this.lblPicLgPanel.TabIndex = 17;
            this.lblPicLgPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.SystemColors.Window;
            this.picBox.Image = global::Menu.Properties.Resources.Screenshot_13;
            this.picBox.Location = new System.Drawing.Point(713, 61);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(109, 143);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 6;
            this.picBox.TabStop = false;
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.panelPicLgAndLbl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTxtBox);
            this.Controls.Add(this.picBox);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotedPad";
            this.TopMost = true;
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelPicLgAndLbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton tCopy;
        private System.Windows.Forms.ToolStripButton tNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tCut;
        private System.Windows.Forms.ToolStripButton tSave;
        private System.Windows.Forms.ToolStripButton tPaste;
        private System.Windows.Forms.ToolStripButton tColor;
        private System.Windows.Forms.ToolStripButton tFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel copyRightStatus;
        private System.Windows.Forms.ToolStripButton PicBoxBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.PictureBox picBoxLg;
        private System.Windows.Forms.Panel panelPicLgAndLbl;
        private System.Windows.Forms.Label lblPicLgPanel;
    }
}

