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
    public partial class frmDangKiDeTai : Form
    {
        public frmDangKiDeTai()
        {
            InitializeComponent();

            dataDeTai.Rows[0].Cells[0].Value = "1";
            dataDeTai.Rows[0].Cells[1].Value = "DT0001";
            dataDeTai.Rows[0].Cells[2].Value = "Quản lý Khóa Luận Tốt Nghiệp";
            dataDeTai.Rows[0].Cells[3].Value = "Nguyễn Đức Dân";
            dataDeTai.Rows[0].Cells[4].Value = "Xem chi tiết";
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDeXuatDeTai f = new frmDeXuatDeTai();
            f.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmXemChiTiet f = new frmXemChiTiet();
            f.ShowDialog();
        }
    }
}
