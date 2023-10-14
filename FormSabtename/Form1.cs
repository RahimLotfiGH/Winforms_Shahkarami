using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormSabtename
{
    public partial class frmInscription : Form
    {
        public frmInscription()
        {
            InitializeComponent();
        }

        private void txtLetter_KeyPress(object sender, KeyPressEventArgs e)
        {

            txtDigit.Text = (txtDigit.Text != string.Empty) ? string.Empty + ((int)e.KeyChar).ToString() : ((int)e.KeyChar).ToString();
            txtLetter.Text = string.Empty;
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtAge.MaxLength = 3;
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8))
            {
                e.KeyChar = (char)27;
            }
            e.KeyChar = (char)(1632 + int.Parse(e.KeyChar.ToString()));
        }

        private void txtName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            CultureInfo language = new CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            var btn = (RadioButton)sender;
            switch (btn.Name)
            {
                case "RadioBtnBackBlue":
                    BackColor = Color.Blue;
                    break;
                case "RadioBtnBackGray":
                    BackColor = Color.Gray;
                    break;
                case "RadioBtnBackYellow":
                    BackColor = Color.Yellow;
                    break;

                case "RadioBtnForeGreen":
                    ForeColor = Color.Green;
                    break;
                case "RadioBtnForeBlack":
                    ForeColor = Color.Black;
                    break;
                case "RadioBtnForeBlue":
                    ForeColor = Color.Blue;
                    break;
                default:
                    break;
            }
        }
        List<string> checkLanguages = new List<string>();
        StringBuilder str;


        private void checkedListBoxLanguage_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                checkLanguages.Distinct();
                checkLanguages.Add(checkedListBoxLanguage.Items[e.Index].ToString());
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                checkLanguages.Remove(checkedListBoxLanguage.Items[e.Index].ToString());
            }
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            var resultPopup = new ResultForm();
            // resultPopup.MdiParent = this;
            resultPopup.UpdateListBox(checkLanguages.Distinct().ToList());
            resultPopup.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItemInListBoxNames();
        }

        private void AddItemInListBoxNames()
        {
            lstBoxNames.Items.Add(txttNames.Text);
            txttNames.Text = string.Empty;
            txttNames.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstBoxNames.Items.Remove(lstBoxNames.SelectedItem);
        }

        private void txttNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                AddItemInListBoxNames();
        }
    }
}
