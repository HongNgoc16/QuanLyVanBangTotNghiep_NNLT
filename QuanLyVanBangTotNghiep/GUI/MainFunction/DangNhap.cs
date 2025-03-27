using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyVanBangTotNghiep
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

       
        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            textMatKhau.UseSystemPasswordChar = !checkHienThiMK.Checked;

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }


        private void buttonDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
