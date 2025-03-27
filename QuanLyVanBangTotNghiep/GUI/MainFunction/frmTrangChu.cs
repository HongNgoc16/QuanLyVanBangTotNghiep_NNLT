using QuanLyVanBangTotNghiep.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVanBangTotNghiep
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            this.Hide();
            dangNhap.ShowDialog();
            this.Show();
         }

        private void buttonTraCuu_Click(object sender, EventArgs e)
        {
            TraCuuVanBang traCuu = new TraCuuVanBang();
            this.Hide();
            traCuu.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            DangKyCapBanSao dangKyCapBanSao = new DangKyCapBanSao();
            this.Hide();
            dangKyCapBanSao.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuiYeuCauChinhSua guiYeuCau = new GuiYeuCauChinhSua();
            this.Hide();
            guiYeuCau.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HuongDan huongDan = new HuongDan();
            this.Hide();
            huongDan.ShowDialog();
            this.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
