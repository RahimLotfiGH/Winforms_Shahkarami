using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = InitializeOpenDialog();

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //richTxtBox.LoadFile(openDialog.FileName);
                richTxtBox.Text = File.ReadAllText(openDialog.FileName);
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
            SaveFileDialog saveDialog = InitializeSaveDialog();

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveDialog.FileName, richTxtBox.Text);
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
    }
}
