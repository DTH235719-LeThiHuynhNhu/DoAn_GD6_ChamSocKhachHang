using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamSocKhachHang.Data
{
    public class DichVu
    {
        public int ID { get; set; }
        public string TenDichVu { get; set; }
        public decimal Gia { get; set; }
        public string MoTa { get; set; }

        public string? HinhAnh { get; set; }

        public virtual ICollection<LichSuChamSoc> LichSuChamSoc { get; set; } = new List<LichSuChamSoc>();
    }
}
