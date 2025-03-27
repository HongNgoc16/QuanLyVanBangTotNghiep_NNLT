namespace QuanLyVanBangTotNghiep
{
    partial class formNguoiDung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ma_NguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Dang_Nhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mat_Khau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai_NguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Don_Vi_Quan_Ly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textMaND = new System.Windows.Forms.TextBox();
            this.textTenDangNhap = new System.Windows.Forms.TextBox();
            this.textMatKhau = new System.Windows.Forms.TextBox();
            this.cboBoxLoaiND = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBoxDonViQuanLy = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonThemMoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_NguoiDung,
            this.Ten_Dang_Nhap,
            this.Mat_Khau,
            this.Loai_NguoiDung,
            this.Don_Vi_Quan_Ly});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(941, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // Ma_NguoiDung
            // 
            this.Ma_NguoiDung.HeaderText = "Mã người dùng";
            this.Ma_NguoiDung.MinimumWidth = 8;
            this.Ma_NguoiDung.Name = "Ma_NguoiDung";
            // 
            // Ten_Dang_Nhap
            // 
            this.Ten_Dang_Nhap.HeaderText = "Tên đăng nhập";
            this.Ten_Dang_Nhap.MinimumWidth = 8;
            this.Ten_Dang_Nhap.Name = "Ten_Dang_Nhap";
            // 
            // Mat_Khau
            // 
            this.Mat_Khau.HeaderText = "Mật khẩu";
            this.Mat_Khau.MinimumWidth = 8;
            this.Mat_Khau.Name = "Mat_Khau";
            // 
            // Loai_NguoiDung
            // 
            this.Loai_NguoiDung.HeaderText = "Loại người dùng";
            this.Loai_NguoiDung.MinimumWidth = 8;
            this.Loai_NguoiDung.Name = "Loai_NguoiDung";
            // 
            // Don_Vi_Quan_Ly
            // 
            this.Don_Vi_Quan_Ly.HeaderText = "Đơn vị quản lý";
            this.Don_Vi_Quan_Ly.MinimumWidth = 8;
            this.Don_Vi_Quan_Ly.Name = "Don_Vi_Quan_Ly";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox1.Location = new System.Drawing.Point(0, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 217);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã người dùng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(450, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đăng nhập:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(20, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(450, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Loại người dùng:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textMaND
            // 
            this.textMaND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMaND.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaND.Location = new System.Drawing.Point(156, 40);
            this.textMaND.Name = "textMaND";
            this.textMaND.Size = new System.Drawing.Size(288, 31);
            this.textMaND.TabIndex = 4;
            // 
            // textTenDangNhap
            // 
            this.textTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenDangNhap.Location = new System.Drawing.Point(598, 37);
            this.textTenDangNhap.Name = "textTenDangNhap";
            this.textTenDangNhap.Size = new System.Drawing.Size(292, 31);
            this.textTenDangNhap.TabIndex = 5;
            // 
            // textMatKhau
            // 
            this.textMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMatKhau.Location = new System.Drawing.Point(156, 89);
            this.textMatKhau.Name = "textMatKhau";
            this.textMatKhau.Size = new System.Drawing.Size(288, 31);
            this.textMatKhau.TabIndex = 6;
            // 
            // cboBoxLoaiND
            // 
            this.cboBoxLoaiND.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxLoaiND.FormattingEnabled = true;
            this.cboBoxLoaiND.Items.AddRange(new object[] {
            "Quản trị viên",
            "Bộ phận quản lý",
            "Bộ phận duyệt"});
            this.cboBoxLoaiND.Location = new System.Drawing.Point(598, 86);
            this.cboBoxLoaiND.Name = "cboBoxLoaiND";
            this.cboBoxLoaiND.Size = new System.Drawing.Size(292, 33);
            this.cboBoxLoaiND.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(20, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Đơn vị quản lý:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cboBoxDonViQuanLy
            // 
            this.cboBoxDonViQuanLy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxDonViQuanLy.FormattingEnabled = true;
            this.cboBoxDonViQuanLy.Items.AddRange(new object[] {
            "Học viện Kỹ thuật Quân sự"});
            this.cboBoxDonViQuanLy.Location = new System.Drawing.Point(156, 136);
            this.cboBoxDonViQuanLy.Name = "cboBoxDonViQuanLy";
            this.cboBoxDonViQuanLy.Size = new System.Drawing.Size(288, 33);
            this.cboBoxDonViQuanLy.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboBoxDonViQuanLy);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboBoxLoaiND);
            this.groupBox2.Controls.Add(this.textMatKhau);
            this.groupBox2.Controls.Add(this.textTenDangNhap);
            this.groupBox2.Controls.Add(this.textMaND);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox2.Location = new System.Drawing.Point(3, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(941, 186);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(333, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH MỤC NGƯỜI DÙNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 44);
            this.panel1.TabIndex = 5;
            // 
            // buttonThemMoi
            // 
            this.buttonThemMoi.AutoSize = true;
            this.buttonThemMoi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonThemMoi.FlatAppearance.BorderSize = 0;
            this.buttonThemMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.buttonThemMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buttonThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThemMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemMoi.ForeColor = System.Drawing.Color.White;
            this.buttonThemMoi.Location = new System.Drawing.Point(141, 25);
            this.buttonThemMoi.Name = "buttonThemMoi";
            this.buttonThemMoi.Size = new System.Drawing.Size(117, 43);
            this.buttonThemMoi.TabIndex = 1;
            this.buttonThemMoi.Text = "Thêm mới";
            this.buttonThemMoi.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(321, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(501, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(681, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Tìm kiếm";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonThemMoi);
            this.panel2.Location = new System.Drawing.Point(3, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 94);
            this.panel2.TabIndex = 6;
            // 
            // formNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(973, 548);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formNguoiDung";
            this.Text = "formNguoiDung";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Dang_Nhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mat_Khau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai_NguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Don_Vi_Quan_Ly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textMaND;
        private System.Windows.Forms.TextBox textTenDangNhap;
        private System.Windows.Forms.TextBox textMatKhau;
        private System.Windows.Forms.ComboBox cboBoxLoaiND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboBoxDonViQuanLy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonThemMoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
    }
}