using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVanBangTotNghiep.Entity
{
    public class Dm_SinhVien
    {
        private int _Id_SinhVien;
        private string _Ma_SinhVien;
        private string _Ho_Va_Ten;
        private bool _Gioi_Tinh;
        private DateTime _Ngay_Sinh;
        private string _Id_KhoaHoc;
        private string _Id_ChuyenNganh;
        private string _So_Dien_Thoai;
        private string _Email;
        private double _Diem_Trung_Binh_Tich_Luy;
        private string _Id_XepLoai;
        private string _Id_Don_Vi_Quan_Ly;
        private bool _Trang_Thai;

        public Dm_SinhVien() { }

        public int Id_SinhVien
        {
            get { return _Id_SinhVien; }
            set { _Id_SinhVien = value; }
        }

        public string Ma_SinhVien
        {
            get { return _Ma_SinhVien; }
            set { _Ma_SinhVien = value; }
        }

        public string Ho_Va_Ten
        {
            get { return _Ho_Va_Ten; }
            set { _Ho_Va_Ten = value; }
        }

        public bool Gioi_Tinh
        {
            get { return _Gioi_Tinh; }
            set { _Gioi_Tinh = value; }
        }

        public DateTime Ngay_Sinh
        {
            get { return _Ngay_Sinh; }
            set { _Ngay_Sinh = value; }
        }

       

        public string Id_KhoaHoc
        {
            get { return _Id_KhoaHoc; }
            set { _Id_KhoaHoc = value; }
        }
        public string Id_ChuyenNganh
        {
            get { return _Id_ChuyenNganh; }
            set { _Id_ChuyenNganh = value; }
        }
        public string So_Dien_Thoai
        {
            get { return _So_Dien_Thoai; }
            set { _So_Dien_Thoai = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public double Diem_Trung_Binh_Tich_Luy
        {
            get { return _Diem_Trung_Binh_Tich_Luy; }
            set { _Diem_Trung_Binh_Tich_Luy = value; }
        }
        public string XepLoai
        {
            get { return _Id_XepLoai; }
            set { _Id_XepLoai = value; }
        }

        public string Id_Don_Vi_Quan_Ly
        {
            get { return _Id_Don_Vi_Quan_Ly; }
            set { _Id_Don_Vi_Quan_Ly = value; }
        }
        public bool Trang_Thai
        {
            get { return _Trang_Thai; }
            set { _Trang_Thai = value; }
        }

    }
}
