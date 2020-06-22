using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caro3
{
    class OCo
    {
        public const int _ChieuRong = 25; //OX
        public const int _ChieuCao = 25; //OY

        private int _Dong;
        public int Dong { get => _Dong; set => _Dong = value; }
        private int _Cot;
        public int Cot { get => _Cot; set => _Cot = value; }
        private Point _ViTri;
        public Point ViTri { get => _ViTri; set => _ViTri = value; }
        private int _SoHuu;
        public int SoHuu { get => _SoHuu; set => _SoHuu = value; }
        public OCo()
        {

        }
        public OCo(int dong, int cot, Point vitri, int sohuu)
        {
            _Dong = dong;
            _Cot = cot;
            _ViTri = vitri;
            _SoHuu = sohuu;
        }
    }
}
