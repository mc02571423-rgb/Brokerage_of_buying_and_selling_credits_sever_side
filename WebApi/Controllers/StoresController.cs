using BLL.DTO;
using BLL.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        IStoresBll sBll;
        public StoresController(IStoresBll sb)
        {
            sBll = sb;
        }
        [HttpGet]
        public ActionResult<List<StoresDTO>> Get()
        { 
            return Ok(sBll.GetAllStores()); 
        }
    }
}
