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

namespace ChamSocKhachHang.form
{
    public partial class frmKhachHang : Form
    {
        CSKHContext context = new CSKHContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa)
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtTenKhachHang.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<KhachHang> kh = context.KhachHangs.ToList();
            LoadKhachHang(kh);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtTenKhachHang.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtEmail.DataBindings.Clear();

            txtTenKhachHang.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();

            txtTenKhachHang.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                return;
            }

            if (xuLyThem)
            {
                KhachHang kh = new KhachHang();
                kh.HoTen = txtTenKhachHang.Text;
                kh.DienThoai = txtDienThoai.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.Email = txtEmail.Text;

                context.KhachHangs.Add(kh);
            }
            else
            {
                KhachHang kh = context.KhachHangs.Find(id);
                if (kh != null)
                {
                    kh.HoTen = txtTenKhachHang.Text;
                    kh.DienThoai = txtDienThoai.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.Email = txtEmail.Text;
                }
            }

            context.SaveChanges();
            BatTatChucNang(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khách hàng?",
                        "Xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ID"].Value);

                KhachHang kh = context.KhachHangs.Find(id);
                if (kh != null)
                {
                    context.KhachHangs.Remove(kh);
                    context.SaveChanges();
                }

                frmKhachHang_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e) { }

        private void textBox1_TextChanged_1(object sender, EventArgs e) { }

        private void LoadKhachHang(List<KhachHang> kh)
        {
            var displayList = kh.Select(x => new {
                x.ID,
                x.HoTen,
                x.DienThoai,
                x.Email,
                x.DiaChi,
                // Lấy ngày chăm sóc gần nhất từ bảng lịch sử của khách hàng đó
                LichSuChamSoc = context.LichSuChamSocs
                            .Where(ls => ls.KhachHangID == x.ID)
                            .OrderByDescending(ls => ls.NgayChamSoc)
                            .Select(ls => ls.NgayChamSoc.ToString("dd/MM/yyyy"))
                            .FirstOrDefault() ?? "Chưa chăm sóc"
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = displayList;

            // Các đoạn DataBindings cũ của bạn (txtTenKhachHang...) 
            // giữ nguyên nhưng hãy đảm bảo dùng đúng tên trường

            dataGridView2.DataSource = bindingSource;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            var kh = context.KhachHangs
                .Where(x => x.HoTen.ToLower().Contains(keyword)
                         || x.DienThoai.Contains(keyword))
                .ToList();

            LoadKhachHang(kh);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();

            // Load lại dữ liệu
            List<KhachHang> kh = context.KhachHangs.ToList();
            LoadKhachHang(kh);

            // Xóa dữ liệu trên textbox
            txtTenKhachHang.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();

            BatTatChucNang(false);
            dataGridView2.ClearSelection();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu nhập
            txtTenKhachHang.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();

            // Tắt trạng thái thêm/sửa
            xuLyThem = false;

            // Reset nút
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnLuu.Enabled = false;
            btnHuyBo.Enabled = false;

            // Load lại dữ liệu
            LoadKhachHang(context.KhachHangs.ToList());
        }
        private void RefreshData()
        {
            // Load lại toàn bộ danh sách khách hàng từ context mới nhất
            // Lưu ý: .AsNoTracking() giúp lấy dữ liệu mới nhất nếu context bị cache
            var danhSach = context.KhachHangs.ToList();
            LoadKhachHang(danhSach);
        }
        private void btnMoLichSu_Click(object sender, EventArgs e)
        {
            frmLichSuChamSoc frm = new frmLichSuChamSoc();

            // ĐĂNG KÝ SỰ KIỆN: Khi form lịch sử lưu, thì form khách hàng tự Load lại
            frm.FormDaLuuDuLieu += (s, args) => {
                RefreshData();
            };

            frm.ShowDialog();
        }
    }
}
     