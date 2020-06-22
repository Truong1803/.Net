using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    
    public partial class frmQuanLyDiem : Form
    {
        public string check = "";
        
        public frmQuanLyDiem()
        {
            this.CenterToScreen();

            InitializeComponent();
            RefreshData();
            tinhDiem();
            //txtMaSinhVien.ReadOnly = true;
            LockControl();
        }
        public void LockControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaSinhVien.ReadOnly = true;
            txtMaMonHoc.ReadOnly = true;
            txtTenMonHoc.ReadOnly = true;
            txtSoTinChi.ReadOnly = true;
            txtDiem.ReadOnly = true;
        }

        public void RefreshData()
        {
           
            QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
            var query = from b in db.BangDiems
                        where b.MaSinhVien == QuanLySinhVien.btnTimKiem.GetMSV()
                        select new
                        {
                            b.MaSinhVien,
                            b.MaMonHoc,
                            b.TenMonHoc,
                            b.SoTinChi,
                            b.Diem
                        };

            txtTimKiem.Text = "";
            dataDiem.DataSource = query;

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void UnlockControl()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtDiem.ReadOnly = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            UnlockControl();
            txtMaSinhVien.ReadOnly = false;
            txtMaMonHoc.ReadOnly = false;
            txtTenMonHoc.ReadOnly = false;
            txtSoTinChi.ReadOnly = false;
            txtDiem.ReadOnly = false;
            check = "Them";
            txtMaMonHoc.Text = "";
            txtMaSinhVien.Text = "";
            txtTenMonHoc.Text = "";
            txtSoTinChi.Text = "";
            txtDiem.Text = "";
            txtTimKiem.Text = "";
        }
        private void tinhDiem()
        {
            double TongDiem = 0;
            int TongTin = 0;
            if (dataDiem.Rows.Count == 0)
            {
                txtSoTinChiTL.Text = "0";
                txtTBTichLuy.Text = "0";
            }
            else
            {
                for (int i = 0; i < dataDiem.Rows.Count; i++)
                {
                    string tin = dataDiem.Rows[i].Cells[3].Value.ToString();
                    string diem = dataDiem.Rows[i].Cells[4].Value.ToString();                   
                    TongDiem = TongDiem + double.Parse(tin) * double.Parse(diem);
                    TongTin = TongTin + int.Parse(tin);

                }
                
                txtSoTinChiTL.Text = TongTin.ToString();
                txtTBTichLuy.Text = (TongDiem / TongTin).ToString("#,##0.00");
            }
        }
        

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = "Sua";
            UnlockControl();
            txtMaSinhVien.ReadOnly = false;
            txtMaMonHoc.ReadOnly = false;
            txtTenMonHoc.ReadOnly = false;
            txtSoTinChi.ReadOnly = false;
            txtDiem.ReadOnly = false;
            txtTimKiem.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check == "Them")
            {
                try
                {
                    QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
                    BangDiem n = new BangDiem();
                    n.MaSinhVien = txtMaSinhVien.Text;
                    n.MaMonHoc = txtMaMonHoc.Text;
                    n.TenMonHoc = txtTenMonHoc.Text;
                    n.SoTinChi = int.Parse(txtSoTinChi.Text);
                    n.Diem = double.Parse(txtDiem.Text);
                    db.BangDiems.InsertOnSubmit(n);
                    db.SubmitChanges();
                    MessageBox.Show("Bạn đã thêm xong mã môn học " + txtMaMonHoc.Text);                  
                    RefreshData();
                    tinhDiem();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hãy xem lại mã " + txtMaSinhVien.Text + " nó đã tồn tại!");
                }
            }
            else if (check == "Sua")
            {
                QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
                var a = (from p in db.BangDiems
                         where p.MaSinhVien == txtMaSinhVien.Text && p.MaMonHoc == txtMaMonHoc.Text
                         select p).FirstOrDefault();
                a.MaSinhVien = txtMaSinhVien.Text;
                a.MaMonHoc = txtMaMonHoc.Text;
                a.TenMonHoc = txtTenMonHoc.Text;
                a.SoTinChi = int.Parse(txtSoTinChi.Text);
                a.Diem = double.Parse(txtDiem.Text);
                db.SubmitChanges();
                MessageBox.Show("Bạn đã thay đổi thành công");                
                RefreshData();
                tinhDiem();
            }
            txtTimKiem.Text = "";
            LockControl();
            btnTimKiem.Enabled = true;

        }

        private void dataDiem_SelectionChanged(object sender, EventArgs e)
        {
            txtMaSinhVien.Text = dataDiem.Rows[dataDiem.CurrentRow.Index].Cells[0].Value.ToString();
            txtMaMonHoc.Text = dataDiem.Rows[dataDiem.CurrentRow.Index].Cells[1].Value.ToString();
            txtTenMonHoc.Text = dataDiem.Rows[dataDiem.CurrentRow.Index].Cells[2].Value.ToString();
            txtSoTinChi.Text = dataDiem.Rows[dataDiem.CurrentRow.Index].Cells[3].Value.ToString();
            txtDiem.Text = dataDiem.Rows[dataDiem.CurrentRow.Index].Cells[4].Value.ToString();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa môn học " + dataDiem.Rows[dataDiem.CurrentRow.Index].Cells[2].Value.ToString(), "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string MaSinhVien = dataDiem.Rows[dataDiem.CurrentRow.Index].Cells[0].Value.ToString();
                string MaMonHoc = dataDiem.Rows[dataDiem.CurrentRow.Index].Cells[1].Value.ToString();
                QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
                BangDiem t = db.BangDiems.FirstOrDefault(p => p.MaSinhVien == MaSinhVien && p.MaMonHoc==MaMonHoc);
                db.BangDiems.DeleteOnSubmit(t);
                db.SubmitChanges();

                
            }
            txtTimKiem.Text = "";
            RefreshData();
            tinhDiem();

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaMonHoc.Text = "";
            txtMaSinhVien.Text = "";
            txtTenMonHoc.Text = "";
            txtSoTinChi.Text = "";
            txtDiem.Text = "";
            check = "Them";
            txtTimKiem.Text = "";
            LockControl();
        }

        private void frmQuanLyDiem_Load(object sender, EventArgs e)
        {
            if (dataDiem.Rows.Count == 0)
            {
                return;
            }
            else
            {
                for (int i = 0; i < dataDiem.Rows.Count; i++)
                {
                    string diem = dataDiem.Rows[i].Cells[4].Value.ToString();
                    if (double.Parse(diem) <= 4)
                    {
                        dataDiem.Rows[i].Cells[4].Style.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
            var query = from b in db.BangDiems
                        where b.MaMonHoc == txtTimKiem.Text && b.MaSinhVien==QuanLySinhVien.btnTimKiem.GetMSV()
                        select new
                        {
                            b.MaSinhVien,
                            b.MaMonHoc,
                            b.TenMonHoc,
                            b.SoTinChi,
                            b.Diem
                         
                        };
            dataDiem.DataSource = query;
            LockControl();
            if (dataDiem.Rows.Count == 0)
            {
                return;
            }
            else
            {
                for (int i = 0; i < dataDiem.Rows.Count; i++)
                {
                    string diem = dataDiem.Rows[i].Cells[4].Value.ToString();
                    if (double.Parse(diem) <= 4)
                    {
                        dataDiem.Rows[i].Cells[4].Style.ForeColor = Color.Red;
                    }
                }
            }

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            RefreshData();
            if (dataDiem.Rows.Count == 0)
            {
                return;
            }
            else
            {
                for (int i = 0; i < dataDiem.Rows.Count; i++)
                {
                    string diem = dataDiem.Rows[i].Cells[4].Value.ToString();
                    if (double.Parse(diem) <= 4)
                    {
                        dataDiem.Rows[i].Cells[4].Style.ForeColor = Color.Red;
                    }
                }
            }
        }

    }
}
