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
    public partial class frmLichSuChamSoc : Form
    {
        CSKHContext context = new CSKHContext();
        bool xuLyThem = false;
        int id;
        public frmLichSuChamSoc()
        {
            InitializeComponent();
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmLichSuChamSoc_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadLichSu();
            BatTatChucNang(false);
        }
        private void LoadComboBox()
        {
            cboKhachHang.DataSource = context.KhachHangs.ToList();
            cboKhachHang.DisplayMember = "HoTen";
            cboKhachHang.ValueMember = "ID";

            cboNhanVien.DataSource = context.NhanViens.ToList();
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "ID";

            cboDichVu.DataSource = context.DichVus.ToList();
            cboDichVu.DisplayMember = "TenDichVu";
            cboDichVu.ValueMember = "ID";
        }
        private void LoadLichSu()
        {
            var ls = context.LichSuChamSocs
                .Select(x => new
                {
                    x.ID,
                    KhachHang = x.KhachHang.HoTen,
                    NhanVien = x.NhanVien.HoTen,
                    DichVu = x.DichVu.TenDichVu,
                    x.NgayChamSoc,
                    x.GhiChu
                }).ToList();

            dataGridView4.DataSource = ls;
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            cboKhachHang.Enabled = giaTri;
            cboNhanVien.Enabled = giaTri;
            cboDichVu.Enabled = giaTri;
            dtpNgayChamSoc.Enabled = giaTri;
            txtGhiChu.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtGhiChu.Clear();
            dtpNgayChamSoc.Value = DateTime.Now;
        }

        public event EventHandler FormDaLuuDuLieu;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (xuLyThem)
            {
                LichSuChamSoc ls = new LichSuChamSoc
                {
                    KhachHangID = (int)cboKhachHang.SelectedValue,
                    NhanVienID = (int)cboNhanVien.SelectedValue,
                    DichVuID = (int)cboDichVu.SelectedValue,
                    NgayChamSoc = dtpNgayChamSoc.Value,
                    GhiChu = txtGhiChu.Text
                };

                context.LichSuChamSocs.Add(ls);
            }
            else
            {
                LichSuChamSoc ls = context.LichSuChamSocs.Find(id);

                if (ls != null)
                {
                    ls.KhachHangID = (int)cboKhachHang.SelectedValue;
                    ls.NhanVienID = (int)cboNhanVien.SelectedValue;
                    ls.DichVuID = (int)cboDichVu.SelectedValue;
                    ls.NgayChamSoc = dtpNgayChamSoc.Value;
                    ls.GhiChu = txtGhiChu.Text;
                }
            }

            context.SaveChanges();

            FormDaLuuDuLieu?.Invoke(this, EventArgs.Empty);

            LoadLichSu();
            BatTatChucNang(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView4.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dataGridView4.CurrentRow.Cells["ID"].Value);

            var ls = context.LichSuChamSocs.Find(id);

            if (ls != null)
            {
                cboKhachHang.SelectedValue = ls.KhachHangID;
                cboNhanVien.SelectedValue = ls.NhanVienID;
                cboDichVu.SelectedValue = ls.DichVuID;
                dtpNgayChamSoc.Value = ls.NgayChamSoc;
                txtGhiChu.Text = ls.GhiChu;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa lịch sử?", "Xóa",
        MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView4.CurrentRow.Cells["ID"].Value);

                var ls = context.LichSuChamSocs.Find(id);
                if (ls != null)
                {
                    context.LichSuChamSocs.Remove(ls);
                    context.SaveChanges();
                }

                LoadLichSu();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
