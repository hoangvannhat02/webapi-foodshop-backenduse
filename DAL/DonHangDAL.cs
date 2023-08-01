using DAL.Helper;
using DAL.Helper.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DonHangDAL : IDonHangDAL
    {
        public IDataHelper db;
        public DonHangDAL(IDataHelper db)
        {
            this.db = db;
        }
        public void ThemVaoGioHang(DonHangModel dh)
        {
            DateTime dt = DateTime.Now;
            float sum = 0;
            List<ChiTietDonHang> list = dh.listdh;
            for (int i = 0; i < list.Count(); i++)
            {
                SanPham sp = db.ExcuteProcedureReturnDatatable("GetSanPhamById", "@Id", list[i].MaSanPham).ConvertTo<SanPham>().FirstOrDefault();
                sum += sp.GiaBan * list[i].SoLuong;
            }
            
            db.ExecuteProcedure("AddToCart", "@MaKhachHang", dh.MaKhachHang,
                                "@NgayTao", dh.NgayTao = dt,
                                "@DiaChiNhan",dh.DiaChiNhan,
                                "@MoTa",dh.MoTa,
                                "@TongTien", sum
                                );
            for (int i = 0; i < list.Count(); i++)
            {
                float tam = 0;
                SanPham sp = db.ExcuteProcedureReturnDatatable("GetSanPhamById", "@Id", list[i].MaSanPham).ConvertTo<SanPham>().FirstOrDefault();
                tam += sp.GiaBan * list[i].SoLuong;
                db.ExecuteProcedure("ThemChiTietDonHang", "@masanpham", list[i].MaSanPham,
                                    "@sl", list[i].SoLuong, "@tamtinh", tam);
            }
            
        }
    }
}
