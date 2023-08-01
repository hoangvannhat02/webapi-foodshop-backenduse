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
    public class LoaiSanPhamDAL:ILoaiSanPhamDAL
    {
        public IDataHelper db;
        public LoaiSanPhamDAL(IDataHelper db)
        {
            this.db = db;
        }
        public List<LoaiSanPham> getalldata()
        {
            return db.ExcuteProcedureReturnDatatable("get_all_data_category").ConvertTo<LoaiSanPham>().ToList();
        }
    }
}
