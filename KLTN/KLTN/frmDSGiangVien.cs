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
    public partial class frmDSGiangVien : Form
    {
        public frmDSGiangVien()
        {
            InitializeComponent();
            DSGiangVien.Rows[0].Cells[0].Value = "Truong";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
