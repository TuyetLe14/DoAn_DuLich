using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_DuLich_LTC085A0003_LTC085A0004
{
    public class clsKhachHang
    {
        private string sMaKH,sMaQG, sHoTen, sDiaChi, sDienThoai, sHinh;
        private bool bPhai;

        public string MaKH { get => sMaKH; set => sMaKH = value; }
        public string HoTen { get => sHoTen; set => sHoTen = value; }
        public string DiaChi { get => sDiaChi; set => sDiaChi = value; }
        public string DienThoai { get => sDienThoai; set => sDienThoai = value; }
        public string Hinh { get => sHinh; set => sHinh = value; }
        public bool Phai { get => bPhai; set => bPhai = value; }
        public string MaQG { get => sMaQG; set => sMaQG = value; }

        public clsKhachHang() { }

        public clsKhachHang(string kh,string QG, string Ten, string DC, string DT, bool Ph, string Hi)
        {
            MaKH = kh;
            HoTen = Ten;
            MaQG = QG;
            DiaChi = DC;
            DienThoai = DT;
            Phai = Ph;
            Hinh = Hi;
        }
    }
}
