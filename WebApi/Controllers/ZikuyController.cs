using BLL.DTO;
using BLL.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZikuyController : ControllerBase
    {
        IZikuyBll zBll;
        public ZikuyController(IZikuyBll zb)
        {
            zBll = zb; 
        }

        [HttpGet("GetCreditsForSale")]
        public ActionResult<List<ZikuyDTO>> GetCreditsForSale()
        {
            return Ok(zBll.GetCreditsForSale());
        }

        [HttpGet("{id}")]
        public ActionResult<List<ZikuyDTO>> GetCreditsByUser(string id)
        {
            return Ok(zBll.GetCreditsByUser(id));
        }

        [HttpPut("{tz}")]
        public ActionResult<bool> saleCredit(ZikuyDTO z,string tz)
        {
            return Ok(zBll.saleCredit(z.CreditCode, tz, z.AmountOfCredit));
        }

        [HttpPut]
        public ActionResult<bool> UpdateCreditForSale(ZikuyDTO z)
        {
            return Ok(zBll.UpdateCreditForSale(z.CreditCode, z.AmountOfCredit));
        }
    }
}




//[HttpGet("GetCreditsByStore/{codeS}")]
//public ActionResult<List<ZikuyDTO>> GetCreditsByStore(string codeS)
//{
//    return Ok(zBll.GetCreditsByStore(codeS));
//}