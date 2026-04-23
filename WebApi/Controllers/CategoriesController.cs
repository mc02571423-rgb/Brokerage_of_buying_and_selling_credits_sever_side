using BLL.DTO;
using BLL.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoriesBll cBll;
        public CategoriesController(ICategoriesBll cb)
        {
            cBll = cb;
            Console.WriteLine("aaa");
        }
        [HttpGet]
        public ActionResult<List<CategoriesDTO>> Get()
        {
            return Ok(cBll.GetCategories());
        }
    }
}
