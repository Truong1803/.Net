using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNganhHoc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try 
            {
                QuanLyNganhHocDataContext db = new QuanLyNganhHocDataContext();
                Nganh n = new Nganh();
                n.MaNganh = txtMaNganh.Text;
                n.TenNganhTV = txtTenNganhTV.Text;
                n.TenNganhTA = txtTenNganhTA.Text;
                n.KhoaQuanLy = cbKhoaQuanLy.Text;
                n.NgayMo = dtNgayMo.Value;
                n.MoTa = txtMoTa.Text;
                db.Nganhs.InsertOnSubmit(n);
                db.SubmitChanges();
                MessageBox.Show("Bạn đã thêm xong mã môn học " + txtMaNganh.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Đã tồn tại vui lòng xem lại !");
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
