using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamSocKhachHang.Data
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string HoTen { get; set; }
        public string DienThoai { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }

        public virtual ICollection<LichSuChamSoc> LichSuChamSoc { get; set; } = new List<LichSuChamSoc>();
    }
}
