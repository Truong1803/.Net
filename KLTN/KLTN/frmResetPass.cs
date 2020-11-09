using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KLTN
{
    public partial class frmResetPass : Form
    {
        public frmResetPass()
        {
            InitializeComponent();
        }

        private void SMS_CheckedChanged(object sender, EventArgs e)
        {
            txtSMS.Enabled = true;
            txtEmail.Enabled = false;
        }

        private void Email_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.Enabled = true;
            txtSMS.Enabled = false;
        }
    }
}
