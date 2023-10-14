using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
