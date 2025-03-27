using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVanBangTotNghiep
{
    public class Dm_NguoiDung
    {
        private int _Id_NguoiDung;
        private string _Ma_NguoiDung;
        private string _Ten_Dang_Nhap;
        private string _Mat_Khau;
        private string _Loai_NguoiDung;

        public Dm_NguoiDung()
        {
        }
        public int Id_NguoiDung
        {
            get
            {
                return _Id_NguoiDung;
            }
            set
            {
                _Id_NguoiDung = value;
            }
        }

        public string Ma_NguoiDung
        {
            get
            {
                return _Ma_NguoiDung;
            }
            set
            {
                _Ma_NguoiDung = value;
            }
        }
        public string Ten_Dang_Nhap
        {
            get
            {
                return _Ten_Dang_Nhap;
            }
            set
            {
                _Ten_Dang_Nhap = value;
            }
        }
        
       
        public string Mat_Khau
        {
            get
            {
                return _Mat_Khau;
            }
            set
            {
                _Mat_Khau = value;
            }
        }
        public string Loai_NguoiDung
        {
            get
            {
                return _Loai_NguoiDung;
            }
            set
            {
                _Loai_NguoiDung = value;
            }
        }
    }
}

