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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
            dataKLTN.Rows[0].Cells[0].Value = "1";
            dataKLTN.Rows[0].Cells[1].Value = "KL0001";
            dataKLTN.Rows[0].Cells[2].Value = "Quản lý Khóa Luận Tốt Nghiệp";
            dataKLTN.Rows[0].Cells[3].Value = "Nguyễn Đức Dân";
            dataKLTN.Rows[0].Cells[4].Value = "Toán Tin";
            dataKLTN.Rows[0].Cells[5].Value = "2 tháng";
            dataKLTN.Rows[0].Cells[6].Value = "05";
            dataKLTN.Rows[0].Cells[7].Value = "Kì 1 Nhóm 2 - 2020";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDSGiangVien f = new frmDSGiangVien();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmNopND f = new frmNopND();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmNopDeCuong f = new frmNopDeCuong();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmDangKiDeTai f = new frmDangKiDeTai();
            f.ShowDialog();
        }
    }
}
