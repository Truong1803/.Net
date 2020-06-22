using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            this.CenterToScreen();

            InitializeComponent();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dataloginDataContext db = new dataloginDataContext();
            var a = (from p in db.LoginSVs
                     where p.UserName == txtUserName.Text && p.PassWord==txtPassWord.Text
                     select p) .FirstOrDefault();
            if(a!=null)
            { 
                this.Hide();
                btnTimKiem f = new btnTimKiem();//show thong tin sinh vien
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("UserName hoặc PassWord không chính xác!!!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
        }
    }
}
