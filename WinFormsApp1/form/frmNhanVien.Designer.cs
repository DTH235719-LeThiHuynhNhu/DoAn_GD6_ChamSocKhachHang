namespace ChamSocKhachHang.form
{
    partial class frmNhanVien
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnLamMoi = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtTenDangNhap = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtMatKhau = new TextBox();
            txtDienThoai = new TextBox();
            btnThoat = new Button();
            txtTimKiem = new TextBox();
            dataGridView3 = new DataGridView();
            groupBox2 = new GroupBox();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtHoTen = new TextBox();
            label1 = new Label();
            btnTimKiem = new Button();
            btnSua = new Button();
            groupBox1 = new GroupBox();
            btnXuatExcel = new Button();
            btnNhapExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = SystemColors.GradientActiveCaption;
            btnLamMoi.Location = new Point(752, 508);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 11;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(369, 39);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 12;
            label6.Text = "Tên đăng nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(369, 82);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 11;
            label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 0;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(506, 39);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(160, 27);
            txtTenDangNhap.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 86);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 10;
            label2.Text = "Số điện thoại";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(506, 82);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(160, 27);
            txtMatKhau.TabIndex = 9;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(139, 79);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(171, 27);
            txtDienThoai.TabIndex = 8;
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(606, 126);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(140, 508);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(469, 27);
            txtTimKiem.TabIndex = 9;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(3, 23);
            dataGridView3.MultiSelect = false;
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RightToLeft = RightToLeft.No;
            dataGridView3.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView3.Size = new Size(829, 252);
            dataGridView3.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView3);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(34, 208);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(835, 278);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // btnHuyBo
            // 
            btnHuyBo.ForeColor = SystemColors.ActiveCaptionText;
            btnHuyBo.Location = new Point(506, 126);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = SystemColors.ActiveCaptionText;
            btnLuu.Location = new Point(406, 126);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = SystemColors.ActiveCaptionText;
            btnXoa.Location = new Point(306, 126);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.ForeColor = SystemColors.ActiveCaptionText;
            btnThem.Location = new Point(106, 126);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(139, 30);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(171, 27);
            txtHoTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 37);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên nhân viên";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.GradientActiveCaption;
            btnTimKiem.Location = new Point(640, 508);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnSua
            // 
            btnSua.ForeColor = SystemColors.ActiveCaptionText;
            btnSua.Location = new Point(206, 126);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNhapExcel);
            groupBox1.Controls.Add(btnXuatExcel);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(34, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(835, 174);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.ForeColor = SystemColors.ActiveCaptionText;
            btnXuatExcel.Location = new Point(718, 35);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(94, 29);
            btnXuatExcel.TabIndex = 13;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnNhapExcel
            // 
            btnNhapExcel.ForeColor = SystemColors.ActiveCaptionText;
            btnNhapExcel.Location = new Point(718, 86);
            btnNhapExcel.Name = "btnNhapExcel";
            btnNhapExcel.Size = new Size(94, 29);
            btnNhapExcel.TabIndex = 14;
            btnNhapExcel.Text = "Nhập Excel";
            btnNhapExcel.UseVisualStyleBackColor = true;
            btnNhapExcel.Click += btnNhapExcel_Click;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(907, 559);
            Controls.Add(btnLamMoi);
            Controls.Add(txtTimKiem);
            Controls.Add(groupBox2);
            Controls.Add(btnTimKiem);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLamMoi;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtTenDangNhap;
        private Label label3;
        private Label label2;
        private TextBox txtMatKhau;
        private TextBox txtDienThoai;
        private Button btnThoat;
        private TextBox txtTimKiem;
        private DataGridView dataGridView3;
        private GroupBox groupBox2;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtHoTen;
        private Label label1;
        private Button btnTimKiem;
        private Button btnSua;
        private GroupBox groupBox1;
        private Button btnXuatExcel;
        private Button btnNhapExcel;
    }
}