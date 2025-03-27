using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVanBangTotNghiep
{
    public class Dm_XepLoai
    {
        private int _Id_XepLoai;
        private string _Ma_XepLoai;
        private string _Ten_XepLoai;
        private double _Diem_Toi_Thieu;
        private double _Diem_Toi_Da;
        private bool _Trang_Thai_Su_Dung;

        public Dm_XepLoai() { }

        public int Id_XepLoai
        {
            get { return _Id_XepLoai; }
            set { _Id_XepLoai = value; }
        }
        public string Ma_Xep_Loai
        {
            get { return _Ma_XepLoai; }
            set { _Ma_XepLoai = value; }
        }
        public string Ten_Xep_Loai
        {
            get { return _Ten_XepLoai; }
            set { _Ten_XepLoai = value; }
        }
        public double Diem_Toi_Thieu
        {
            get { return _Diem_Toi_Thieu; }
            set { _Diem_Toi_Thieu = value; }
        }
        public double Diem_Toi_Da
        {
            get { return _Diem_Toi_Da; }
            set { _Diem_Toi_Da = value; }
        }
        public bool Trang_Thai_Su_Dung
        {
            get { return _Trang_Thai_Su_Dung; }
            set { _Trang_Thai_Su_Dung = value; }
        }
    }


}
