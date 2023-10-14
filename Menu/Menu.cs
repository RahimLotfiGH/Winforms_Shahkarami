using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Menu
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = InitializeOpenDialog();

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //richTxtBox.LoadFile(openDialog.FileName);
                richTxtBox.Text = System.IO.File.ReadAllText(openDialog.FileName);
            }
        }

        private OpenFileDialog InitializeOpenDialog()
        {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "Text Files(*.txt)|*.txt|All files(*.*)|*.*";
            openDialog.Title = "Select a file";
            return openDialog;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HandleSaveFile();
        }

        private void HandleSaveFile()
        {
            SaveFileDialog saveDialog = InitializeSaveDialog();

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveDialog.FileName, richTxtBox.Text);
                //richTxtBox.SaveFile(saveDialog.FileName);
            }
        }

        private SaveFileDialog InitializeSaveDialog()
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text files(*.txt)|*.txt";
            saveDialog.Title = "Save the File";
            saveDialog.DefaultExt = "txt";
            return saveDialog;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTxtBox.Font = fontDialog.Font;
                richTxtBox.ForeColor = fontDialog.Color;
                //richTxtBox.SelectionFont = fontDialog.Font;
                //richTxtBox.SelectionColor = fontDialog.Color;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTxtBox.BackColor = colorDialog.Color;
                //richTxtBox.ForeColor = colorDialog.Color;
                //richTxtBox.SelectionBackColor = colorDialog.Color;
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = InitializeFolderBrowseDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                richTxtBox.Text = folderDialog.SelectedPath;
            }
        }

        private FolderBrowserDialog InitializeFolderBrowseDialog()
        {
            var folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Select a folder... ";
            folderDialog.ShowNewFolderButton = true;
            return folderDialog;
        }


        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            if (richTxtBox.Text != string.Empty)
            {
                var dialogResult = MessageBox.Show("Do you wanna save the file before closing? "
                , "Exit"
                , MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    HandleSaveFile();
                }
            }


            Environment.Exit(0);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            richTxtBox.Text = string.Empty;
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            richTxtBox.Copy();
        }

        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            richTxtBox.Cut();
        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            richTxtBox.Paste();
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            timer.Start();
            btn.BackColor = Color.FromArgb(173, 216, 230);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            timer.Stop();
            btn.BackColor = Color.FromArgb(215, 228, 242);

        }

        private void picBox_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://heilton.com/");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void picBox_MouseHover(object sender, EventArgs e)
        {
            picBox.Size = new Size(112, 152);
        }

        private void picBox_MouseLeave(object sender, EventArgs e)
        {
            picBox.Size = new Size(109, 143);
           
        }

        private void PicBoxBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = InitializeOpenDialogForPic();

            if (openDialog.ShowDialog() == DialogResult.OK)
                picBox.Image = Image.FromFile(openDialog.FileName);

        }

        private static OpenFileDialog InitializeOpenDialogForPic()
        {
            var openDialog = new OpenFileDialog();
            openDialog.Title = "Select an Image";
            openDialog.Filter = "Image Files(*.Jpg;*.Png)|*.Jpg;*.Png";
            return openDialog;
        }
    }
}
