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
    public partial class BoPhanDuyet : Form
    {
        public BoPhanDuyet()
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
        private void BoPhanDuyet_Load(object sender, EventArgs e)
        {
            
        }
    }
}
