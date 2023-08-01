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
    public class KhachHangBLL:IKhachHangBLL
    {
        public IKhachHangDAL db;
        public KhachHangBLL(IKhachHangDAL db)
        {
            this.db = db;
        }
        public void create(KhachHang kh)
        {
            db.create(kh);
        }
        public KhachHang getdataid(int id)
        {
            return db.getdataid(id);
        }
        public KhachHang CheckLogin(KhachHang kh)
        {
            return db.CheckLogin(kh);
        }
    }
}
