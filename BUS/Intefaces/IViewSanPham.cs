using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Intefaces
{
    public interface IViewSanPham
    {
        SanPham GetProductId(int id);
        List<SanPham> GetAllData();
        List<SanPham> SanPhamMoi(int sl);
        List<SanPham> SanPhamBanChay(int sl);
        List<SanPham> SanPhamTuongTu(int id);
        List<SanPham> SanPhamTheoMaLoai(int id);
    }
}
