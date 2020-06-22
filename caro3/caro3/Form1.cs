using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caro3
{

    public partial class Form1 : Form
    {
        int chedochoi=0;
        int locked =0;
        bool start = true;
        private CaroChess caroChess;
        private Graphics grs;
        public Form1()
        {
            InitializeComponent();
            caroChess = new CaroChess(tbxPlayername);
            caroChess.KhoiTaoMangOCo();
            grs = pnlBanCo.CreateGraphics();
            PVE.Click += new EventHandler(PVE_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlBanCo_Paint(object sender, PaintEventArgs e)
        {
            caroChess.VeBanCo(grs);
            caroChess.VeLaiQuanCo(grs);
        }

        private void pnlBanCo_MouseClick(object sender, MouseEventArgs e)
        {
            if (!caroChess.SanSang)
                return;
            if (caroChess.DanhCo(e.X, e.Y, grs))
            {
                if (caroChess.KiemTraChienThang())
                {
                    caroChess.KetThucTroChoi();
                }
                else
                {
                    if (caroChess.CheDoChoi == 2)
                    {
                        caroChess.KhoiDongComputer(grs);
                        if (caroChess.KiemTraChienThang())
                        {
                            caroChess.KetThucTroChoi();
                        }
                    }
                }
            }
            
        }

        private void PVP(object sender, EventArgs e)
        {
            chedochoi = 1;
            if (start == true || locked == 1)
            {
                start = false;
                locked = 2;              
                grs.Clear(pnlBanCo.BackColor);
                caroChess.StartPlayerVsPlayer(grs);
            }
            else
                return;

        }

        

        private void PVE_Click(object sender, EventArgs e)
        {
            chedochoi = 2;
            if (start == true || locked == 2)
            {
                start = false;
                locked = 1;
                grs.Clear(pnlBanCo.BackColor);
                caroChess.StartPlayerVsCom(grs);
            }
            else
                return;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            if (chedochoi == 0)
                return;
            else if (chedochoi == 1)
            {
                grs.Clear(pnlBanCo.BackColor);
                caroChess.StartPlayerVsPlayer(grs);
            }
            else
            {
                grs.Clear(pnlBanCo.BackColor);
                caroChess.StartPlayerVsCom(grs);
            }
        }
    }
}
