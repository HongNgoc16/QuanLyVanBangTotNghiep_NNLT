using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVanBangTotNghiep
{
    public class Dm_NganhHoc
    {
        private int _Id_NganhHoc;
        private string _Ma_NganhHoc;
        private string _Ten_Nganh;
        private string _Ten_Chuyen_Nganh;
        private bool _Trang_Thai_Su_Dung;

        public Dm_NganhHoc()
        {
        }
        public int Id_NganhHoc
        {
            get
            {
                return _Id_NganhHoc;
            }
            set
            {
                _Id_NganhHoc = value;
            }
        }

        public string Ma_Nganhhoc
        {
            get
            {
                return _Ma_NganhHoc;
            }
            set
            {
                _Ma_NganhHoc = value;
            }
        }
        public string Ten_Nganh
        {
            get
            {
                return _Ten_Nganh;
            }
            set
            {
                _Ten_Nganh = value;
            }
        }
        public string Ten_Chuyen_Nganh
        {
            get
            {
                return _Ten_Chuyen_Nganh;
            }
            set
            {
                _Ten_Chuyen_Nganh = value;
            }
        }
        public bool Trang_Thai_Su_Dung
        {
            get
            {
                return _Trang_Thai_Su_Dung;
            }
            set
            {
                _Trang_Thai_Su_Dung = value;
            }
        }

    }
}
