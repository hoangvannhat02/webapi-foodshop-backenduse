using DAL.Helper;
using DAL.Helper.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamDAL:ISanPhamDAL
    {
        public IDataHelper db;
        public SanPhamDAL(IDataHelper db)
        {
            this.db = db;
        }
        public SanPham GetProductId(int id)
        {
                var sp = db.ExcuteProcedureReturnDatatable("GetSanPhamById", "@Id", id);
                return sp.ConvertTo<SanPham>().FirstOrDefault();
           
        }
        public List<SanPham> GetAllData()
        {
            return db.ExcuteProcedureReturnDatatable("GetAllProduct").ConvertTo<SanPham>().ToList();
        }
        public List<SanPham> SanPhamMoi(int sl)
        {
            return db.ExcuteProcedureReturnDatatable("SanPhamMoi", "@sl", sl).ConvertTo<SanPham>().ToList();
        }
        public List<SanPham> SanPhamTuongTu(int id)
        {
            return db.ExcuteProcedureReturnDatatable("sptuongtu", "@id", id).ConvertTo<SanPham>().ToList();
        }

        public List<SanPham> SanPhamBanChay(int sl)
        {
            return db.ExcuteProcedureReturnDatatable("SanPhamBanChay", "@sl", sl).ConvertTo<SanPham>().ToList();
        }
        public List<SanPham> SanPhamTheoMaLoai(int id)
        {
            return db.ExcuteProcedureReturnDatatable("get_product_categoryid", "@id", id).ConvertTo<SanPham>().ToList();
        }
    }
}
