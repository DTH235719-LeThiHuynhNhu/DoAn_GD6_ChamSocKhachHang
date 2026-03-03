namespace ChamSocKhachHang.form
{
    partial class frmLichSuChamSoc
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
            dtpTimNgay = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtGhiChu = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            dtpNgayChamSoc = new DateTimePicker();
            cboDichVu = new ComboBox();
            cboNhanVien = new ComboBox();
            cboKhachHang = new ComboBox();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            btnTimKiem = new Button();
            groupBox2 = new GroupBox();
            dataGridView4 = new DataGridView();
            txtTimKiem = new TextBox();
            btnLamMoi = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // dtpTimNgay
            // 
            dtpTimNgay.Location = new Point(66, 519);
            dtpTimNgay.Name = "dtpTimNgay";
            dtpTimNgay.Size = new Size(250, 27);
            dtpTimNgay.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 118);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 12;
            label6.Text = "Dịch vụ";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 32);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 11;
            label5.Text = "Ngày chăm sóc";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 0;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(567, 96);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(248, 27);
            txtGhiChu.TabIndex = 1;
            txtGhiChu.TextChanged += txtNoiDung_TextChanged;
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
            label2.Location = new Point(17, 74);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 10;
            label2.Text = "Nhân viên";
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(611, 161);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpNgayChamSoc);
            groupBox1.Controls.Add(cboDichVu);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(25, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(835, 200);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "LỊCH SỬ CHĂM SÓC KHÁCH HÀNG";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(429, 99);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 19;
            label7.Text = "Ghi chú";
            // 
            // dtpNgayChamSoc
            // 
            dtpNgayChamSoc.Location = new Point(565, 26);
            dtpNgayChamSoc.Name = "dtpNgayChamSoc";
            dtpNgayChamSoc.Size = new Size(250, 27);
            dtpNgayChamSoc.TabIndex = 18;
            // 
            // cboDichVu
            // 
            cboDichVu.FormattingEnabled = true;
            cboDichVu.Location = new Point(139, 115);
            cboDichVu.Name = "cboDichVu";
            cboDichVu.Size = new Size(250, 28);
            cboDichVu.TabIndex = 17;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(139, 71);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(250, 28);
            cboNhanVien.TabIndex = 16;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(139, 29);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(250, 28);
            cboKhachHang.TabIndex = 13;
            // 
            // btnHuyBo
            // 
            btnHuyBo.ForeColor = SystemColors.ActiveCaptionText;
            btnHuyBo.Location = new Point(511, 161);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = SystemColors.ActiveCaptionText;
            btnLuu.Location = new Point(411, 161);
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
            btnXoa.Location = new Point(311, 161);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.ForeColor = SystemColors.ActiveCaptionText;
            btnSua.Location = new Point(211, 161);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.ForeColor = SystemColors.ActiveCaptionText;
            btnThem.Location = new Point(111, 161);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 37);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Khách Hàng";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.GradientActiveCaption;
            btnTimKiem.Location = new Point(608, 521);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView4);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(25, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(835, 278);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "DANH SÁCH LỊCH SỬ CHĂM SÓC";
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.Location = new Point(3, 23);
            dataGridView4.MultiSelect = false;
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RightToLeft = RightToLeft.No;
            dataGridView4.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridView4.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView4.Size = new Size(829, 252);
            dataGridView4.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(356, 521);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(221, 27);
            txtTimKiem.TabIndex = 18;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = SystemColors.GradientActiveCaption;
            btnLamMoi.Location = new Point(720, 521);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 20;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // frmLichSuChamSoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(897, 560);
            Controls.Add(dtpTimNgay);
            Controls.Add(groupBox1);
            Controls.Add(btnTimKiem);
            Controls.Add(groupBox2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnLamMoi);
            Name = "frmLichSuChamSoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLichSuChamSoc";
            Load += frmLichSuChamSoc_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpTimNgay;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtGhiChu;
        private Label label3;
        private Label label2;
        private Button btnThoat;
        private GroupBox groupBox1;
        private ComboBox cboNhanVien;
        private ComboBox cboKhachHang;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private Button btnTimKiem;
        private GroupBox groupBox2;
        private DataGridView dataGridView4;
        private TextBox txtTimKiem;
        private Button btnLamMoi;
        private ComboBox cboDichVu;
        private DateTimePicker dtpNgayChamSoc;
        private Label label7;
    }
}