using BLL.Intefaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace webbandoanvat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangController : ControllerBase
    {
        IKhachHangBLL db;
        public KhachHangController (IKhachHangBLL db)
        {
            this.db = db;
        }
        [Route("create-customer")]
        [HttpPost]
        public IActionResult Create([FromBody] KhachHang kh)
        {
            try
            {
                db.create(kh);
                return Ok("Thêm khách hàng thành công");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("get-customer-id")]
        [HttpGet]
        public KhachHang getdataid(int id)
        {
            try
            {
                return db.getdataid(id);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [Route("checklogin")]
        [HttpPost]
        public KhachHang check_login([FromBody] KhachHang kh)
        {
            try
            {
                return db.CheckLogin(kh);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
