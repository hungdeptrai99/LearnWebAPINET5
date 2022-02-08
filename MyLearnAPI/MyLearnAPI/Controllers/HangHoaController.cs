using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyLearnAPI.Models;

namespace MyLearnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangHoaController : ControllerBase
    {
        public static List<HangHoa> hangHoa = new List<HangHoa>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(hangHoa);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            try
            {
                // LinkQ [Object] Querry
                var hangHoas = hangHoa.SingleOrDefault(hh => hh.MaHangHoa == Guid.Parse(id));
                if (hangHoas == null)
                {
                    return NotFound();
                }
                return Ok(hangHoas);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Create(HangHoaVM hangHoaVM)
        {
            var hanghoa = new HangHoa
            {
                MaHangHoa = Guid.NewGuid(),
                TenHangHoa = hangHoaVM.TenHangHoa,
                DonGia = hangHoaVM.DonGia,
            };
            hangHoa.Add(hanghoa);
            return Ok(new
            {
                Success = true,
                Data = hanghoa
            });
        }

        [HttpPut("{id}")]
        public IActionResult Edit(string id, HangHoa hangHoaEdit)
        {
            try
            {
                var hangHoas = hangHoa.SingleOrDefault(hh => hh.MaHangHoa == Guid.Parse(id));
                if (hangHoas == null)
                {
                    return NotFound();
                }
                if (id != hangHoas.MaHangHoa.ToString())
                {
                    return BadRequest();
                }
                // Update
                hangHoas.TenHangHoa = hangHoaEdit.TenHangHoa;
                hangHoas.DonGia = hangHoaEdit.DonGia;
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(string id)
        {
            try
            {
                // LinkQ [Object] Querry
                var hangHoas = hangHoa.SingleOrDefault(hh => hh.MaHangHoa == Guid.Parse(id));
                if (hangHoas == null)
                {
                    return NotFound();
                }
                hangHoa.Remove(hangHoas);
                return Ok(hangHoas);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
