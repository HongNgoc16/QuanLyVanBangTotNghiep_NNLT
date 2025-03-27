using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyVanBangTotNghiep
{
    public class Dm_DonViQuanLy
    {
        private int _Id_DonViQuanLy;
        private string _Ma_DonViQuanLy;
        private string _Ten_DonViQuanLy;
        private string _Ten_DonViQuanLy_Cha;
        private bool _Trang_Thai_Su_Dung;

        public Dm_DonViQuanLy()
        {
        }
        public int Id_DonViQuanLy
        {
            get
            {
                return _Id_DonViQuanLy;
            }
            set
            {
                _Id_DonViQuanLy = value;
            }
        }

        public string Ma_Don_Vi_Quan_Ly
        {
            get
            {
                return _Ma_DonViQuanLy;
            }
            set
            {
                _Ma_DonViQuanLy = value;
            }
        }
        public string Ten_DonViQuanLy
        {
            get
            {
                return _Ten_DonViQuanLy;
            }
            set
            {
                _Ten_DonViQuanLy = value;
            }
        }
        public string Ten_DonViQuanLy_Cha
        {
            get
            {
                return _Ten_DonViQuanLy_Cha;
            }
            set
            {
                _Ten_DonViQuanLy_Cha = value;
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
