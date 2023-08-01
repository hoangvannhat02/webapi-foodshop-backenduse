using BLL.Intefaces;
using DAL;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ViewSanPhamBLL:IViewSanPham
    {
        public ISanPhamDAL db;
       
        public ViewSanPhamBLL(ISanPhamDAL db)
        {
            this.db = db;
        }
        public SanPham GetProductId(int id)
        {
            return db.GetProductId(id);
        }
        public List<SanPham> GetAllData()
        {
            return db.GetAllData();
        }
        public List<SanPham> SanPhamMoi(int sl)
        {
            return db.SanPhamMoi(sl);
        }
        public List<SanPham> SanPhamBanChay(int sl)
        {
            return db.SanPhamBanChay(sl);
        }
        public List<SanPham> SanPhamTheoMaLoai(int id)
        {
            return db.SanPhamTheoMaLoai(id);
        }
        public List<SanPham> SanPhamTuongTu(int id)
        {
            return db.SanPhamTuongTu(id);
        }
    }
}
