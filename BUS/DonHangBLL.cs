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
    public class DonHangBLL : IDonHangBLL
    {
        public IDonHangDAL db;
        public DonHangBLL(IDonHangDAL db)
        {
            this.db = db;
        }

        public void ThemVaoGioHang(DonHangModel dh)
        {
            db.ThemVaoGioHang(dh);
        }
    }
}
