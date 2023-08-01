using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DonHangModel
    {
        public int MaHoaDon { get; set; }
        public DateTime? NgayTao { get; set; }
        public string DiaChiNhan { get; set; }
        public string MoTa { get; set; }
        public int MaKhachHang { get; set; }
        public int MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public float TongTien { get; set; }
        public List<ChiTietDonHang> listdh { get; set; }
    }
    public class ChiTietDonHang
    {
        public int MaSanPham { get; set; }
        public int SoLuong { get; set; }
    }
}
