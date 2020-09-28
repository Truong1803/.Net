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
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            RefreshData();
        }
        private void RefreshData()
        {
            QuanLyNganhHocDataContext db = new QuanLyNganhHocDataContext();
            var query = from b in db.Nganhs
                    select new
                    {
                        b.MaNganh,
                        b.TenNganhTV,
                        b.TenNganhTA,
                        b.KhoaQuanLy,
                        b.NgayMo,
                        b.MoTa,
                    };
            dataListNganh.DataSource = query;
        }
        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void dataListNganh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        static string check ;
        
        static public string GetCheck()
        {
            return check;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            RefreshData();
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            check = dataListNganh.Rows[dataListNganh.CurrentRow.Index].Cells[0].Value.ToString();
            Form3 f = new Form3();
            f.ShowDialog();
            RefreshData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ngành " + dataListNganh.Rows[dataListNganh.CurrentRow.Index].Cells[1].Value.ToString(), "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                QuanLyNganhHocDataContext db1 = new QuanLyNganhHocDataContext();
                var query1 = from c in db1.Nganhs

                             select new
                             {
                                 c.MaNganh,
                                 c.TenNganhTV,
                                 c.TenNganhTA,
                                 c.KhoaQuanLy,
                                 c.NgayMo,
                                 c.MoTa
                             };
                string MaNganh = dataListNganh.Rows[dataListNganh.CurrentRow.Index].Cells[0].Value.ToString();
                Nganh t1 = db1.Nganhs.FirstOrDefault(p => p.MaNganh == MaNganh);
                db1.Nganhs.DeleteOnSubmit(t1);
                db1.SubmitChanges();
                RefreshData();
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            QuanLyNganhHocDataContext db = new QuanLyNganhHocDataContext();
            var query = from b in db.Nganhs
                        where b.MaNganh == txtTimKiem.Text
                        select new
                        {
                            b.MaNganh,
                            b.TenNganhTV,
                            b.TenNganhTA,
                            b.KhoaQuanLy,
                            b.NgayMo,
                            b.MoTa
                        };
            dataListNganh.DataSource = query;
        }
    }
}
