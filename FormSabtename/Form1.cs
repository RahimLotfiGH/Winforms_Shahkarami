using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
