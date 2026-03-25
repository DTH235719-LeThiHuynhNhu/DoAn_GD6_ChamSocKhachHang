using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamSocKhachHang.Data
{
    public class LichHen
    {
        public int ID { get; set; }
        public int KhachHangID { get; set; }

        public DateTime NgayHen { get; set; }
        public string NoiDung { get; set; }
        public bool TrangThai { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
