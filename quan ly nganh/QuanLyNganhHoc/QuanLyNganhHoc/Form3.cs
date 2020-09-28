using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNganhHoc
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            QuanLyNganhHocDataContext db = new QuanLyNganhHocDataContext();
            var a = (from p in db.Nganhs
                     where p.MaNganh == QuanLyNganhHoc.Form1.GetCheck()
                     select p).FirstOrDefault();
            txtMaNganh.Text= a.MaNganh;
            txtTenNganhTV.Text= a.TenNganhTV;
            txtTenNganhTA.Text = a.TenNganhTA;
            cbKhoaQuanLy.Text = a.KhoaQuanLy;
            dtNgayMo.Text = a.NgayMo.ToString();
            txtMoTa.Text = a.MoTa;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLyNganhHocDataContext db = new QuanLyNganhHocDataContext();
                var a = (from p in db.Nganhs
                         where p.MaNganh == QuanLyNganhHoc.Form1.GetCheck()
                         select p).FirstOrDefault();
                a.MaNganh = txtMaNganh.Text;
                a.TenNganhTV = txtTenNganhTV.Text;
                a.TenNganhTA = txtTenNganhTA.Text;
                a.KhoaQuanLy = cbKhoaQuanLy.Text;
                a.NgayMo = dtNgayMo.Value;
                a.MoTa = txtMoTa.Text;
                db.SubmitChanges();
                MessageBox.Show("Bạn đã thay đổi thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng xem lại !");
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
