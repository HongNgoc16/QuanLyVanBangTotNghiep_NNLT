using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVanBangTotNghiep
{
    public class Dm_KhoaHoc
    {
            private int _Id_KhoaHoc;
            private string _Ma_KhoaHoc;
            private int _Nam_Bat_Dau;
            private int _Nam_Ket_Thuc;
            private bool _Trang_Thai;

            public Dm_KhoaHoc()
            {
            }
            public int Id_KhoaHoc
            {
                get
                {
                    return _Id_KhoaHoc;
                }
                set
                {
                    _Id_KhoaHoc = value;
                }
            }

            public string Ma_KhoaHoc
            {
                get
                {
                    return _Ma_KhoaHoc;
                }
                set
                {
                    _Ma_KhoaHoc = value;
                }
            }
            public int Nam_Bat_Dau
            {
                get
                {
                    return _Nam_Bat_Dau;
                }
                set
                {
                    _Nam_Bat_Dau = value;
                }
            }
            public int Nam_Ket_Thuc
            {
                get
                {
                    return _Nam_Ket_Thuc;
                }
                set
                {
                    _Nam_Ket_Thuc = value;
                }
            }
            public bool Trang_Thai
            {
                get
                {
                    return _Trang_Thai;
                }
                set
                {
                    _Trang_Thai = value;
                }
            }

    }
}
