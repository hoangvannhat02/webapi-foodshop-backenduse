using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Intefaces
{
    public interface IKhachHangBLL
    {
        void create(KhachHang kh);
        KhachHang getdataid(int id);
        KhachHang CheckLogin(KhachHang kh);
    }
}
