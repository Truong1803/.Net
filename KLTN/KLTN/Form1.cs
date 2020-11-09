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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmResetPass f = new frmResetPass();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmPhongDaoTao f = new frmPhongDaoTao();
            //frmGiangVien f = new frmGiangVien();
            //frmTruongBoMon f = new frmTruongBoMon();
            frmSinhVien f = new frmSinhVien();
            f.ShowDialog();
        }
    }
}
