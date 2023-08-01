using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.Interfaces
{
    public interface ISanPhamDAL
    {
        SanPham GetProductId(int id);
        List<SanPham> GetAllData();
        List<SanPham> SanPhamMoi(int sl);
        List<SanPham> SanPhamTuongTu(int id);
        List<SanPham> SanPhamBanChay(int sl);
        List<SanPham> SanPhamTheoMaLoai(int id);
    }
}
