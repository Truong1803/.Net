using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            this.CenterToScreen();

            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtPassWord.Text == txtRePassWord.Text)
            {
                try
                {
                    dataloginDataContext db = new dataloginDataContext();
                    LoginSV n = new LoginSV();
                    n.UserName = txtUserName.Text;
                    n.PassWord = txtPassWord.Text;
                    db.LoginSVs.InsertOnSubmit(n);
                    db.SubmitChanges();
                    MessageBox.Show("Bạn đã đăng ký thành công UserName: " + txtUserName.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hãy xem lại UserName " + txtUserName.Text + " nó đã tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("PassWord không trùng khớp!!!");
            }
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                txtPassWord.UseSystemPasswordChar = false;
                txtRePassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
                txtRePassWord.UseSystemPasswordChar = true;

            }
        }
    }
}
