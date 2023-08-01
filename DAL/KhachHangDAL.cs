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
    public class KhachHangDAL : IKhachHangDAL
    {
        public IDataHelper db;
        public KhachHangDAL(IDataHelper db)
        {
            this.db = db;
        }
        public void create(KhachHang kh)
        {
            db.ExecuteProcedure("themkhachhang", "@username", kh.UserName,
                                "@password", kh.PassWord, "@hoten", kh.HoVaTen,
                                "@diachi", kh.DiaChi, "@sdt", kh.SoDienThoai,
                                "@email", kh.Email);
        }

        public KhachHang getdataid(int id)
        {
            return db.ExcuteProcedureReturnDatatable("getdatacusid", "@id", id).ConvertTo<KhachHang>().FirstOrDefault();
        }

        public KhachHang CheckLogin(KhachHang kh)
        {
            return db.ExcuteProcedureReturnDatatable("checklogin", "@tk", kh.UserName,
                                                       "@mk", kh.PassWord).ConvertTo<KhachHang>().FirstOrDefault();
        }
    }
}
