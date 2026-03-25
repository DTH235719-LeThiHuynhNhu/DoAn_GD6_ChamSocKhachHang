using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamSocKhachHang.Data
{
    public class CSKHContext : DbContext
    {
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<DichVu> DichVus { get; set; }
        public DbSet<LichSuChamSoc> LichSuChamSocs { get; set; }
        public DbSet<LichHen> LichHens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                @"Server=localhost\SQLEXPRESS02;
        Database=QuanLyChamSocKhachHang;
        Trusted_Connection=True;
        TrustServerCertificate=True;
        Encrypt=False;");
        }

    }
}
