using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Drawing.Imaging;

namespace caro3
{
    public enum KETTHUC
    {
        HoaCo,
        Player1,
        Player2
    }
    class CaroChess
    {
        public static Pen pen;
        /*public static SolidBrush sbWhite;
        public static SolidBrush sbBlack;
        public static SolidBrush sbGreen;*/
        Image _imageX = new Bitmap(Properties.Resources.x, 25, 25);
        Image _imageO = new Bitmap(Properties.Resources.o, 25, 25);
        private TextBox playerName;
        private List<Players> player;
        private OCo[,] _MangOCo;
        private BanCo _BanCo;
        private int _LuotDi;
        private int check_com = 0;
        private int check_player = 0;
        private int _CheDoChoi;
        private bool _SanSang;
        private Stack<OCo> Stack_CacNuocDaDi;
        private KETTHUC _ketthuc;
        public TextBox PlayerName { get { return playerName; } set { playerName = value; } }
        private List<Players> Players
        {
            get { return player; }
            set { player = value; }
        }
        public bool SanSang
        {
            get { return _SanSang; }
        }
        public int CheDoChoi
        {
            get { return _CheDoChoi; }
        }
        public CaroChess(TextBox playerName)
        {
            pen = new Pen(Color.Red);
            //sbWhite = new SolidBrush(Color.White);
            //sbBlack = new SolidBrush(Color.Black);
        
            _BanCo = new BanCo(20, 20);
            _MangOCo = new OCo[_BanCo.SoDong, _BanCo.SoCot];
            Stack_CacNuocDaDi = new Stack<OCo>();
            _LuotDi = 1;
            this.PlayerName = playerName;
            this.Players = new List<Players>()
            {
                new Players("Trường"),
                new Players("Ai Đó"),
                
            };
        }
        private void ChangePlayer(int CheDoChoi)
        {
            this._CheDoChoi = CheDoChoi;
            if (CheDoChoi == 1)
                playerName.Text = Players[_LuotDi - 1].Name;
            else
                playerName.Text = Players[0].Name;
        }
        public void VeBanCo(Graphics g)
        {
            _BanCo.VeBanCo(g);
        }
        public void KhoiTaoMangOCo()
        {
            for (int i = 0; i < _BanCo.SoDong; i++)
            {
                for (int j = 0; j < _BanCo.SoCot; j++)
                {
                    _MangOCo[i, j] = new OCo(i, j, new Point(j * OCo._ChieuRong, i * OCo._ChieuCao), 0);
                }
            }
        }
        public bool DanhCo(int MouseX, int MouseY, Graphics g)
        {
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = "tick.mp3";
            player.controls.play();
            if (MouseX % OCo._ChieuRong == 0 || MouseY % OCo._ChieuCao == 0)
                return false;
            int Cot = MouseX / OCo._ChieuRong;
            int Dong = MouseY / OCo._ChieuCao;
            if (_MangOCo[Dong, Cot].SoHuu != 0)
                return false;
            switch (_LuotDi)
            {
                case 1:
                    _MangOCo[Dong, Cot].SoHuu = 1;
                    _BanCo.VeQuanCo(g, _MangOCo[Dong, Cot].ViTri, /*Image.FromFile(Application.StartupPath + "\\caro\\o1.png")*/_imageO);
                    _LuotDi = 2;
                    ChangePlayer(_CheDoChoi);
                    check_player++;
                    break;
                case 2:
                    _MangOCo[Dong, Cot].SoHuu = 2;
                    _BanCo.VeQuanCo(g, _MangOCo[Dong, Cot].ViTri, /*Image.FromFile(Application.StartupPath + "\\caro\\x1.png"*/_imageX);
                    _LuotDi = 1;
                    check_com++;
                    ChangePlayer(_CheDoChoi);
                    break;

            }
            Stack_CacNuocDaDi.Push(_MangOCo[Dong, Cot]);
            return true;
        }
        public void VeLaiQuanCo(Graphics g)
        {
            foreach (OCo oco in Stack_CacNuocDaDi)
            {
                if (oco.SoHuu == 1)
                {
                    
                    _BanCo.VeQuanCo(g, oco.ViTri, /*Image.FromFile(Application.StartupPath + "\\caro\\o1.png")*/_imageO);
                  
                }
                else if (oco.SoHuu == 2)
                {
                    
                    _BanCo.VeQuanCo(g, oco.ViTri, /*Image.FromFile(Application.StartupPath + "\\caro\\x1.png"*/_imageX);
                }
            }
        }
        public void StartPlayerVsPlayer(Graphics g)
        {
            check_player = 0;
            check_com = 0;
            _SanSang = true;
            Stack_CacNuocDaDi = new Stack<OCo>();
            _CheDoChoi = 1;
            KhoiTaoMangOCo();
            ChangePlayer(_CheDoChoi);
            VeBanCo(g);
        }
        
        #region DuyetChienThang
        public void KetThucTroChoi()
        {
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = "win1.mp3";
            //player.URL = "win2.mp3";
            player.controls.play();           
            if (_CheDoChoi == 1)
            {
                switch (_ketthuc)
                {
                    case KETTHUC.HoaCo:
                        MessageBox.Show("Hoa");
                        break;
                    case KETTHUC.Player1:
                        MessageBox.Show(Players[0].Name + " chiến thắng!");
                        break;
                    case KETTHUC.Player2:
                        MessageBox.Show(Players[1].Name + " chiến thắng!");
                        break;
                    
                }
            }
            else
            {
                /*switch (_ketthuc)
                {
                    case KETTHUC.Player1:
                        MessageBox.Show(Players[2].Name + " chiến thắng!");
                        break;
                    case KETTHUC.Player2:
                        MessageBox.Show("COMPUTER thang");
                        break;
                }*/
                if (check_com == check_player)
                {
                    MessageBox.Show(Players[0].Name + " chiến thắng!");
                }
                else
                {
                    MessageBox.Show("COMPUTER thang");
                }
            }
            _SanSang = false;
        }
        public bool KiemTraChienThang()
        {
            if (Stack_CacNuocDaDi.Count == (_BanCo.SoCot * _BanCo.SoDong)) 
            {
                _ketthuc = KETTHUC.HoaCo;
                return true;
            }
            foreach (OCo oco in Stack_CacNuocDaDi)
            {
                if (DuyetDoc(oco.Dong, oco.Cot, oco.SoHuu)||DuyetNgang(oco.Dong,oco.Cot,oco.SoHuu)|| DuyetCheoXuoi(oco.Dong, oco.Cot, oco.SoHuu)|| DuyetCheoNguoc(oco.Dong, oco.Cot, oco.SoHuu))
                {
                    _ketthuc = oco.SoHuu == 1 ? KETTHUC.Player1 : KETTHUC.Player2;
                    return true;
                }
            }
            return false;
        }
        private bool DuyetDoc(int currDong, int currCot, int currSoHuu)
        {
            if (currDong > _BanCo.SoDong - 5)
                return false;
            int Dem;
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot].SoHuu != currSoHuu)
                    return false;
            }
            if (currDong == 0||currDong+Dem==_BanCo.SoDong)
                return true;
            if (_MangOCo[currDong - 1, currCot].SoHuu == 0 || _MangOCo[currDong+Dem,currCot].SoHuu==0)
                return true;
            return false;
        }
        private bool DuyetNgang(int currDong, int currCot, int currSoHuu)
        {
            if (currCot > _BanCo.SoCot - 5)
                return false;
            int Dem;
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOCo[currDong , currCot + Dem].SoHuu != currSoHuu)
                    return false;
            }
            if (currCot == 0 || currCot + Dem == _BanCo.SoCot)
                return true;
            if (_MangOCo[currDong , currCot-1].SoHuu == 0 || _MangOCo[currDong , currCot + Dem].SoHuu == 0)
                return true;
            return false;
        }
        private bool DuyetCheoXuoi(int currDong, int currCot, int currSoHuu)
        {
            if (currDong >_BanCo.SoDong-5||currCot > _BanCo.SoCot - 5)
                return false;
            int Dem;
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOCo[currDong+Dem, currCot + Dem].SoHuu != currSoHuu)
                    return false;
            }
            if (currDong==0||  currCot == 0 ||currDong+Dem==_BanCo.SoDong ||currCot + Dem == _BanCo.SoCot)
                return true;
            if (_MangOCo[currDong-1, currCot - 1].SoHuu == 0 || _MangOCo[currDong+Dem, currCot + Dem].SoHuu == 0)
                return true;
            return false;
        }
        private bool DuyetCheoNguoc(int currDong, int currCot, int currSoHuu)
        {
            if (currDong < 4 || currCot > _BanCo.SoCot - 5)
                return false;
            int Dem;
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot + Dem].SoHuu != currSoHuu)
                    return false;
            }
            if (currDong==4 || currDong==_BanCo.SoDong-1 || currCot==0||currCot+Dem==_BanCo.SoCot)
                return true;
            if (_MangOCo[currDong+1, currCot - 1].SoHuu == 0 || _MangOCo[currDong-Dem, currCot + Dem].SoHuu == 0)
                return true;
            return false;
        }
        #endregion
        public void StartPlayerVsCom(Graphics g)
        {
            check_com = 0;
            check_player = 0;
            _SanSang = true;
            Stack_CacNuocDaDi = new Stack<OCo>();
            _CheDoChoi = 2;
            KhoiTaoMangOCo();
            VeBanCo(g);
            KhoiDongComputer(g);
        }
        #region AI
        private long[] MangDiemTanCong = new long[7] { 0, 9, 54, 162, 1458, 13112, 118008 };
        private long[] MangDiemPhongNgu = new long[7] { 0, 3, 27, 99, 729, 6561, 59849 };
        public void KhoiDongComputer(Graphics g)
        {
            if (Stack_CacNuocDaDi.Count == 0)
            {
                DanhCo(_BanCo.SoCot / 2 * OCo._ChieuRong + 1, _BanCo.SoDong / 2 * OCo._ChieuCao+1,g);
            }
            else{
                OCo oco = TimKiemNuocDi();
                DanhCo(oco.ViTri.X + 1, oco.ViTri.Y + 1, g);
            }

        }
        private OCo TimKiemNuocDi()
        {
            OCo oCoResult = new OCo();
            long DiemMax = 0;
            for(int i = 0; i < _BanCo.SoDong; i++)
            {
                for(int j = 0; j < _BanCo.SoCot; j++)
                {
                    if (_MangOCo[i, j].SoHuu == 0)
                    {
                        long DiemTanCong=DiemTC_DuyetDoc(i,j)+DiemTC_DuyetNgang(i,j)+DiemTC_DuyetCheoNguoc(i,j)+DiemTC_DuyetCheoXuoi(i,j);
                        long DiemPhongNgu= DiemPN_DuyetDoc(i,j) + DiemPN_DuyetNgang(i,j) + DiemPN_DuyetCheoNguoc(i,j) + DiemPN_DuyetCheoXuoi(i,j); ;
                        long DiemTam = DiemTanCong > DiemPhongNgu ? DiemTanCong : DiemPhongNgu;
                        if (DiemMax <= DiemTam)
                        {
                            DiemMax = DiemTam;
                            oCoResult = new OCo(_MangOCo[i, j].Dong, _MangOCo[i, j].Cot, _MangOCo[i, j].ViTri, _MangOCo[i, j].SoHuu);
                        }
                    }
                }
            }
            return oCoResult;
        }
        #region TanCong
        private long DiemTC_DuyetDoc(int currDong,int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[currDong + Dem, currCot].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
            }
            for (int Dem = 1; Dem < 6 && currDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[currDong - Dem, currCot].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }

            }
            if (SoQuanDich == 2)
                return 0;
            DiemTong -= MangDiemPhongNgu[SoQuanDich+1]*2;
            DiemTong += MangDiemTanCong[SoQuanTa];
            return DiemTong;
        }
        private long DiemTC_DuyetNgang(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot; Dem++)
            {
                if (_MangOCo[currDong , currCot + Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[currDong , currCot + Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
            }
            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong , currCot - Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[currDong , currCot - Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }

            }
            if (SoQuanDich == 2)
                return 0;
            DiemTong -= MangDiemPhongNgu[SoQuanDich + 1]*2;
            DiemTong += MangDiemTanCong[SoQuanTa];
            return DiemTong;
        }
        private long DiemTC_DuyetCheoNguoc(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot&&currDong-Dem>=0; Dem++)
            {
                if (_MangOCo[currDong-Dem, currCot + Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[currDong - Dem, currCot + Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
            }
            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0 && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot - Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[currDong + Dem, currCot - Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }

            }
            if (SoQuanDich == 2)
                return 0;
            DiemTong -= MangDiemPhongNgu[SoQuanDich + 1]*2;
            DiemTong += MangDiemTanCong[SoQuanTa];
            return DiemTong;
        }
        private long DiemTC_DuyetCheoXuoi(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot + Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[currDong + Dem, currCot + Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
            }
            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0 && currDong - Dem >=0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot - Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[currDong - Dem, currCot - Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }

            }
            if (SoQuanDich == 2)
                return 0;
            DiemTong -= MangDiemPhongNgu[SoQuanDich + 1]*2;
            DiemTong += MangDiemTanCong[SoQuanTa];
            return DiemTong;
        }
        #endregion
        #region PhongNgu
        private long DiemPN_DuyetDoc(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong + Dem, currCot].SoHuu == 2)
                {
                    SoQuanDich++;
               
                }
                else
                {
                    break;
                }
            }
            for (int Dem = 1; Dem < 6 && currDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong - Dem, currCot].SoHuu == 2)
                {
                    SoQuanDich++;
                 
                }
                else
                {
                    break;
                }

            }
            if (SoQuanTa == 2)
                return 0;
            DiemTong += MangDiemPhongNgu[SoQuanDich];
     
            return DiemTong;
        }
        private long DiemPN_DuyetNgang(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot; Dem++)
            {
                if (_MangOCo[currDong, currCot + Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong, currCot + Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    
                }
                else
                {
                    break;
                }
            }
            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong, currCot - Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong, currCot - Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    
                }
                else
                {
                    break;
                }

            }
            if (SoQuanTa == 2)
                return 0;
            DiemTong += MangDiemPhongNgu[SoQuanDich ];
           
            return DiemTong;
        }
        private long DiemPN_DuyetCheoNguoc(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot && currDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot + Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong - Dem, currCot + Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                   
                }
                else
                {
                    break;
                }
            }
            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0 && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot - Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong + Dem, currCot - Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    
                }
                else
                {
                    break;
                }

            }
            if (SoQuanTa == 2)
                return 0;
            DiemTong += MangDiemPhongNgu[SoQuanDich ];
            return DiemTong;
        }
        private long DiemPN_DuyetCheoXuoi(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot + Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong + Dem, currCot + Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    
                }
                else
                {
                    break;
                }
            }
            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0 && currDong - Dem >=0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot - Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong - Dem, currCot - Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    
                }
                else
                {
                    break;
                }

            }
            if (SoQuanTa == 2)
                return 0;
            DiemTong += MangDiemPhongNgu[SoQuanDich ];
          
            return DiemTong;
        }
        #endregion
        #endregion
    }
}
