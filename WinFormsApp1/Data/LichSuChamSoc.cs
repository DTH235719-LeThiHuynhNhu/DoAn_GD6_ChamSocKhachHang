using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamSocKhachHang.Data
{
    public class LichSuChamSoc
    {
        public int ID { get; set; }

        public int KhachHangID { get; set; }
        public int NhanVienID { get; set; }
        public int DichVuID { get; set; }

        public DateTime NgayChamSoc { get; set; }
        public string GhiChu { get; set; }

        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual DichVu DichVu { get; set; }
    }
}
