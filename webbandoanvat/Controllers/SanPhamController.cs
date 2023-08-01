using BLL;
using BLL.Intefaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace webbandoanvat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        IViewSanPham db;
        public SanPhamController(IViewSanPham db)
        {
            this.db = db;
        }
        [Route("get-by-id")]
        [HttpGet]
        public SanPham GetById(int id)
        {
            return db.GetProductId(id);
        }
        [Route("Get-all-product")]
        [HttpGet]
        public List<SanPham> GetAllData()
        {
            return db.GetAllData();
        }

        [Route("New-Product/{sl}")]
        [HttpGet]
        public List<SanPham> SanPhamMoi(int sl)
        {
            return db.SanPhamMoi(sl);
        }

        [Route("selling-product")]
        [HttpGet]
        public List<SanPham> SanPhamBanChay(int sl)
        {
            return db.SanPhamBanChay(sl);
        }
        [Route("same-product")]
        [HttpGet]
        public List<SanPham> SanPhamTuongTu(int id)
        {
            return db.SanPhamTuongTu(id);
        }

        [Route("get-product-maloai")]
        [HttpGet]
        public List<SanPham> SanPhamTheoMaLoai(int id)
        {
            return db.SanPhamTheoMaLoai(id);
        }
    }
}
