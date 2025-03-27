using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVanBangTotNghiep
{
    public class Dm_PhanQuyenNguoiDung
    {
        private int _Id_LoaiNguoiDung;
        private string _Ma_LoaiNguoiDung;
        private string _Ten_LoaiNguoiDung;
        private bool _Trang_Thai_Su_Dung;

        public Dm_PhanQuyenNguoiDung() { }

        public int LoaiNguoiDung_ID
        {
            get { return _Id_LoaiNguoiDung; }
            set { _Id_LoaiNguoiDung = value; }
        }

        public string Ma_LoaiNguoiDung
        {
            get { return _Ma_LoaiNguoiDung; }
            set { _Ma_LoaiNguoiDung = value; }
        }

        public string Ten_LoaiNguoiDung
        {
            get { return _Ten_LoaiNguoiDung; }
            set { _Ten_LoaiNguoiDung = value; }
        }

        public bool Trang_Thai_Su_Dung
        {
            get { return _Trang_Thai_Su_Dung; }
            set { _Trang_Thai_Su_Dung = value; }
        }
    }
}





