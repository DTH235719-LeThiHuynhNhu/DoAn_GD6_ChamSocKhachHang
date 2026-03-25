using ChamSocKhachHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChamSocKhachHang.form
{
    public partial class frmDichVu : Form
    {
        CSKHContext context = new CSKHContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa)

        string duongDanAnh = "";

        public frmDichVu()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtTenDichVu.Enabled = giaTri;
            txtGia.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadDichVu(context.DichVus.ToList());
        }

        private void LoadDichVu(List<DichVu> dv)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dv;

            txtTenDichVu.DataBindings.Clear();
            txtTenDichVu.DataBindings.Add("Text", bs, "TenDichVu");

            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", bs, "Gia");

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bs, "MoTa");

            picHinhAnh.DataBindings.Clear();
            picHinhAnh.DataBindings.Add("ImageLocation", bs, "HinhAnh");

            dataGridView1.DataSource = bs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            xuLyThem = true;
            BatTatChucNang(true);

            txtTenDichVu.DataBindings.Clear();
            txtGia.DataBindings.Clear();
            txtMoTa.DataBindings.Clear();

            txtTenDichVu.Clear();
            txtGia.Clear();
            txtMoTa.Clear();

            picHinhAnh.Image = null;
            duongDanAnh = "";

            txtTenDichVu.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            duongDanAnh = dataGridView1.CurrentRow.Cells["HinhAnh"].Value?.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDichVu.Text))
            {
                MessageBox.Show("Nhập tên dịch vụ!");
                return;
            }

            if (!decimal.TryParse(txtGia.Text, out decimal gia))
            {
                MessageBox.Show("Giá phải là số!");
                return;
            }

            if (xuLyThem)
            {
                DichVu dv = new DichVu();
                dv.TenDichVu = txtTenDichVu.Text;
                dv.Gia = gia;
                dv.MoTa = txtMoTa.Text;
                dv.HinhAnh = duongDanAnh;

                context.DichVus.Add(dv);
            }
            else
            {
                DichVu dv = context.DichVus.Find(id);
                if (dv != null)
                {
                    dv.TenDichVu = txtTenDichVu.Text;
                    dv.Gia = gia;
                    dv.MoTa = txtMoTa.Text;
                }
            }

            context.SaveChanges();
            frmDichVu_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dịch vụ?",
                "Xóa",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                var dv = context.DichVus.Find(id);
                if (dv != null)
                {
                    context.DichVus.Remove(dv);
                    context.SaveChanges();
                }

                frmDichVu_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text.ToLower();

            var dv = context.DichVus
                .Where(x => x.TenDichVu.ToLower().Contains(key))
                .ToList();

            LoadDichVu(dv);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadDichVu(context.DichVus.ToList());

            txtTenDichVu.Clear();
            txtGia.Clear();
            txtMoTa.Clear();

            picHinhAnh.Image = null;
            duongDanAnh = "";

            BatTatChucNang(false);
            dataGridView1.ClearSelection();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(ofd.FileName);

                string folder = Application.StartupPath + "\\Images\\";
                Directory.CreateDirectory(folder);

                string newPath = folder + fileName;

                File.Copy(ofd.FileName, newPath, true);

                duongDanAnh = "Images\\" + fileName;

                picHinhAnh.Image = Image.FromFile(newPath);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu nhập
            txtTenDichVu.Clear();
            txtGia.Clear();
            txtMoTa.Clear();


            // Tắt trạng thái thêm/sửa
            xuLyThem = false;

            // Reset nút
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnLuu.Enabled = false;
            btnHuyBo.Enabled = false;

            // Load lại dữ liệu
            LoadDichVu(context.DichVus.ToList());
        }
    }
}
