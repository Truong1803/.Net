using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class btnTimKiem : Form
    {
        string check = "";
        public btnTimKiem()
        {

            InitializeComponent();
            


        }
        public void LockControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnXem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnXemDiem.Enabled = false;
            btnTimKiemSV.Enabled = false;
            txtMaSinhVien.ReadOnly = true;
            txtTenSinhVien.ReadOnly = true;
            txtNgaySinh.ReadOnly = true;
            txtQueQuan.ReadOnly = true;
            txtGioiTinh.ReadOnly = true;
            txtKhoa.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtEmail.ReadOnly = true;
            //txtMSVTimKiem.ReadOnly = true;
        }
        public void UnlockControl()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnXem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnXemDiem.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            LockControl();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void RefreshData()
        {
            QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
            var query = from b in db.SinhViens
                        select new
                        {
                            b.MaSinhVien,
                            b.TenSinhVien,
                            b.NgaySinh,
                            b.GioiTinh,
                            b.QueQuan,
                            b.Khoa,
                            b.SoDienThoai,
                            b.Email
                            
                        };
            txtMaSinhVien.Text = "";
            txtTenSinhVien.Text = "";
            txtNgaySinh.Text = "";
            txtGioiTinh.Text = "";
            txtQueQuan.Text = "";
            txtKhoa.Text = "";
            txtMSVTimKiem.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            dataSinhVien.DataSource = query;
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            RefreshData();
            btnXemDiem.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTimKiemSV.Enabled = true;
            txtMSVTimKiem.ReadOnly = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnlockControl();
            txtMaSinhVien.Text = "";
            txtTenSinhVien.Text = "";
            txtNgaySinh.Text = "";
            txtGioiTinh.Text = "";
            txtQueQuan.Text = "";
            txtKhoa.Text = "";
            txtMSVTimKiem.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            check = "Them";
            txtMaSinhVien.ReadOnly = false;
            txtTenSinhVien.ReadOnly = false;
            txtNgaySinh.ReadOnly = false;
            txtQueQuan.ReadOnly = false;
            txtGioiTinh.ReadOnly = false;
            txtKhoa.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSDT.ReadOnly = false;
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            txtMaSinhVien.ReadOnly = false;
            txtTenSinhVien.ReadOnly = false;
            txtNgaySinh.ReadOnly = false;
            txtQueQuan.ReadOnly = false;
            txtGioiTinh.ReadOnly = false;
            txtKhoa.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtEmail.ReadOnly = false;
            check = "Sua";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check == "Them")
            {
                try
                {
                    QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
                    SinhVien n = new SinhVien();
                    n.MaSinhVien = txtMaSinhVien.Text;
                    n.TenSinhVien = txtTenSinhVien.Text;
                    n.NgaySinh = txtNgaySinh.Text;
                    n.GioiTinh = txtGioiTinh.Text;
                    n.QueQuan = txtQueQuan.Text;
                    n.Khoa = txtKhoa.Text;
                    n.Email = txtEmail.Text;
                    n.SoDienThoai = txtSDT.Text;
                    db.SinhViens.InsertOnSubmit(n);
                    db.SubmitChanges();
                    MessageBox.Show("Bạn đã thêm xong sinh viên " + txtMaSinhVien.Text);
                    RefreshData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hãy xem lại mã " + txtMaSinhVien.Text + " nó đã tồn tại!");
                }
                txtMSVTimKiem.Text = "";
            }
            else if (check == "Sua")
            {
                QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
                var a = (from p in db.SinhViens
                         where p.MaSinhVien == txtMaSinhVien.Text
                         select p).FirstOrDefault();
                a.TenSinhVien = txtTenSinhVien.Text;
                a.NgaySinh = txtNgaySinh.Text;
                a.GioiTinh = txtGioiTinh.Text;
                a.QueQuan = txtQueQuan.Text;
                a.Khoa = txtKhoa.Text;
                a.SoDienThoai = txtSDT.Text;
                a.Email = txtEmail.Text;
                db.SubmitChanges();
                MessageBox.Show("Bạn đã thay đổi thành công");
                RefreshData();
                

            }
            LockControl();
            btnXemDiem.Enabled = true;
            btnTimKiemSV.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sinh viên " + dataSinhVien.Rows[dataSinhVien.CurrentRow.Index].Cells[1].Value.ToString(), "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                QuanLySinhVienDataContext db1 = new QuanLySinhVienDataContext();
                var query1 = from c in db1.BangDiems
                             where c.MaSinhVien == txtMaSinhVien.Text
                            select new
                            {
                               c.MaSinhVien,
                               c.MaMonHoc,
                               c.SoTinChi,
                               c.TenMonHoc,
                               c.Diem    
                            };
                int dem=query1.Count();
                if(dem!=0) 
                {
                    while (dem != 0)
                    {
                        string MaSinhVien1 = dataSinhVien.Rows[dataSinhVien.CurrentRow.Index].Cells[0].Value.ToString();
                        BangDiem t1 = db1.BangDiems.FirstOrDefault(p => p.MaSinhVien == MaSinhVien1);
                        db1.BangDiems.DeleteOnSubmit(t1);
                        db1.SubmitChanges();
                        dem--;
                    }
                }
                //--------------------------------------------------
                string MaSinhVien = dataSinhVien.Rows[dataSinhVien.CurrentRow.Index].Cells[0].Value.ToString();
                QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
                SinhVien t = db.SinhViens.FirstOrDefault(p => p.MaSinhVien == MaSinhVien);
                db.SinhViens.DeleteOnSubmit(t);
                db.SubmitChanges();

                var query = from b in db.SinhViens
                            select new
                            {
                                b.MaSinhVien,
                                b.TenSinhVien,
                                b.NgaySinh,
                                b.GioiTinh,
                                b.QueQuan,
                                b.Khoa,
                                b.Email,
                                b.SoDienThoai
                            };

                dataSinhVien.DataSource = query;
                txtMSVTimKiem.Text = "";
                btnTimKiemSV.Enabled = true;

            }
        }

        private void dataSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            txtMaSinhVien.Text = dataSinhVien.Rows[dataSinhVien.CurrentRow.Index].Cells[0].Value.ToString();
            txtTenSinhVien.Text = dataSinhVien.Rows[dataSinhVien.CurrentRow.Index].Cells[1].Value.ToString();
            txtNgaySinh.Text = dataSinhVien.Rows[dataSinhVien.CurrentRow.Index].Cells[2].Value.ToString();
            txtGioiTinh.Text = dataSinhVien.Rows[dataSinhVien.CurrentRow.Index].Cells[3].Value.ToString();
            txtQueQuan.Text = dataSinhVien.Rows[dataSinhVien.CurrentRow.Index].Cells[4].Value.ToString();
            txtKhoa.Text = dataSinhVien.Rows[dataSinhVien.CurrentRow.Index].Cells[5].Value.ToString();
            txtSDT.Text= dataSinhVien.Rows[dataSinhVien.CurrentRow.Index].Cells[6].Value.ToString();
            txtEmail.Text= dataSinhVien.Rows[dataSinhVien.CurrentRow.Index].Cells[7].Value.ToString(); 
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMSVTimKiem.Text = "";
            txtMaSinhVien.Text = "";
            txtTenSinhVien.Text = "";
            txtNgaySinh.Text = "";
            txtGioiTinh.Text = "";
            txtQueQuan.Text = "";
            txtKhoa.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            check = "Them";
            LockControl();
            btnXemDiem.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)//btntimkiem
        {
            QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
            var query = from b in db.SinhViens
                        where b.MaSinhVien == txtMSVTimKiem.Text
                        select new
                        {
                            b.MaSinhVien,
                            b.TenSinhVien,
                            b.NgaySinh,
                            b.GioiTinh,
                            b.QueQuan,
                            b.Khoa,
                            b.SoDienThoai,
                            b.Email
                        };
            dataSinhVien.DataSource = query;
            LockControl();
            btnXemDiem.Enabled = true;
        }
        static string msv1;
        static public string GetMSV()
        {
            return msv1;
        }
        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            msv1= dataSinhVien.Rows[dataSinhVien.CurrentRow.Index].Cells[0].Value.ToString();
            // this.msv(this.msv1);
            //MessageBox.Show(msv1);
            this.Hide();
            frmQuanLyDiem f = new frmQuanLyDiem();
            f.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
