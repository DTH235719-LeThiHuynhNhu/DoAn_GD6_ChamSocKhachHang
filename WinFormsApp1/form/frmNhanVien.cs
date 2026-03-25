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
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System.IO;

namespace ChamSocKhachHang.form
{
    public partial class frmNhanVien : Form
    {
        CSKHContext context = new CSKHContext();
        bool xuLyThem = false;
        int id;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtHoTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadNhanVien(context.NhanViens.ToList());


        }

        private void LoadNhanVien(List<NhanVien> nv)
        {
            var data = nv.Select(x => new
            {
                x.ID,
                x.HoTen,
                x.DienThoai,
                x.TenDangNhap,
                x.MatKhau
            }).ToList();

            dataGridView3.DataSource = data;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtHoTen.Clear();
            txtDienThoai.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();

            txtHoTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dataGridView3.CurrentRow.Cells["ID"].Value);

            NhanVien nv = context.NhanViens.Find(id);

            if (nv != null)
            {
                txtHoTen.Text = nv.HoTen;
                txtDienThoai.Text = nv.DienThoai;
                txtTenDangNhap.Text = nv.TenDangNhap;
                txtMatKhau.Text = nv.MatKhau;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            if (xuLyThem)
            {
                NhanVien nv = new NhanVien
                {
                    HoTen = txtHoTen.Text,
                    DienThoai = txtDienThoai.Text,
                    TenDangNhap = txtTenDangNhap.Text,
                    MatKhau = txtMatKhau.Text
                };

                context.NhanViens.Add(nv);
            }
            else
            {
                NhanVien nv = context.NhanViens.Find(id);
                if (nv != null)
                {
                    nv.HoTen = txtHoTen.Text;
                    nv.DienThoai = txtDienThoai.Text;
                    nv.TenDangNhap = txtTenDangNhap.Text;
                    nv.MatKhau = txtMatKhau.Text;
                }
            }

            context.SaveChanges();
            BatTatChucNang(false);
            LoadNhanVien(context.NhanViens.ToList());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên?",
                "Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView3.CurrentRow.Cells["ID"].Value);

                NhanVien nv = context.NhanViens.Find(id);
                if (nv != null)
                {
                    context.NhanViens.Remove(nv);
                    context.SaveChanges();
                }

                LoadNhanVien(context.NhanViens.ToList());
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            var nv = context.NhanViens
                .Where(x => x.HoTen.ToLower().Contains(keyword)
                         || x.DienThoai.Contains(keyword))
                .ToList();

            LoadNhanVien(nv);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadNhanVien(context.NhanViens.ToList());

            txtHoTen.Clear();
            txtDienThoai.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();

            BatTatChucNang(false);
            dataGridView3.ClearSelection();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu nhập
            txtHoTen.Clear();
            txtDienThoai.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();

            // Tắt trạng thái thêm/sửa
            xuLyThem = false;

            // Reset nút
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnLuu.Enabled = false;
            btnHuyBo.Enabled = false;

            // Load lại dữ liệu
            LoadNhanVien(context.NhanViens.ToList());
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {


            // SET LICENSE (QUAN TRỌNG)
            ExcelPackage.License.SetNonCommercialOrganization("MyApp");

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (ExcelPackage pck = new ExcelPackage())
                    {
                        var ws = pck.Workbook.Worksheets.Add("NhanVien");

                        for (int i = 0; i < dataGridView3.Columns.Count; i++)
                        {
                            ws.Cells[1, i + 1].Value = dataGridView3.Columns[i].HeaderText;
                        }

                        int rowExcel = 2;

                        for (int i = 0; i < dataGridView3.Rows.Count; i++)
                        {
                            if (dataGridView3.Rows[i].IsNewRow) continue;

                            for (int j = 0; j < dataGridView3.Columns.Count; j++)
                            {
                                ws.Cells[rowExcel, j + 1].Value =
                                    dataGridView3.Rows[i].Cells[j].Value?.ToString() ?? "";
                            }

                            rowExcel++;
                        }

                        File.WriteAllBytes(sfd.FileName, pck.GetAsByteArray());
                    }

                    MessageBox.Show("Xuất Excel thành công!");
                }
            }
        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            ExcelPackage.License.SetNonCommercialOrganization("MyApp");

            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (var package = new ExcelPackage(new FileInfo(ofd.FileName)))
                    {
                        var ws = package.Workbook.Worksheets[0];

                        var headers = new Dictionary<string, int>();

                        // đọc header (dòng 1)
                        for (int col = 1; col <= ws.Dimension.Columns; col++)
                        {
                            headers[ws.Cells[1, col].Text] = col;
                        }

                        for (int row = 2; row <= ws.Dimension.Rows; row++)
                        {
                            // ❗ kiểm tra nếu thiếu cột
                            if (!headers.ContainsKey("HoTen") ||
                                !headers.ContainsKey("DienThoai") ||
                                !headers.ContainsKey("TenDangNhap") ||
                                !headers.ContainsKey("MatKhau"))
                            {
                                MessageBox.Show("Excel sai định dạng!");
                                return;
                            }

                            NhanVien nv = new NhanVien
                            {
                                HoTen = ws.Cells[row, headers["HoTen"]].Text,
                                DienThoai = ws.Cells[row, headers["DienThoai"]].Text,
                                TenDangNhap = ws.Cells[row, headers["TenDangNhap"]].Text,
                                MatKhau = ws.Cells[row, headers["MatKhau"]].Text
                            };

                            context.NhanViens.Add(nv);
                        }

                        context.SaveChanges();
                    }

                    MessageBox.Show("Nhập Excel thành công!");

                    LoadNhanVien(context.NhanViens.ToList());
                }
            }
        }
    }
}
