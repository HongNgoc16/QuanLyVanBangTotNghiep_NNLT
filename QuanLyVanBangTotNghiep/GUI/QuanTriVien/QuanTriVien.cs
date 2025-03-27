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
    public partial class QuanTriVien : Form
    {
        public QuanTriVien()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();

            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChucNang.Controls.Add(childForm);
            panelChucNang.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void QuanTriVien_Load(object sender, EventArgs e)
        {
           
        }

               
        
        private void buttonNguoiDung_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formNguoiDung());
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            if (currentFormChild!= null)
            {
                currentFormChild.Close();
            }
        }

        private void buttonPhanQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formPhanQuyen());
        }

        private void buttonDonViQuanLy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formDonViQuanLy());
        }

        private void buttonNganhHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formChuyenNganh());
        }

        private void buttonLoaiTotNghiep_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formXepLoaiTN());

        }

        private void buttonSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formSinhVien());
        }

        private void buttonKhoaHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formKhoaHoc());
        }

        private void buttonChuyenNganh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formChuyenNganh());
        }
    }
}
