using BLL.Intefaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiSanPhamBLL : ILoaiSanPhamBLL
    {
        public ILoaiSanPhamDAL db;
        public LoaiSanPhamBLL(ILoaiSanPhamDAL db)
        {
            this.db = db;
        }
        public List<LoaiSanPham> getalldata()
        {
            return db.getalldata();
        }

    }
}
