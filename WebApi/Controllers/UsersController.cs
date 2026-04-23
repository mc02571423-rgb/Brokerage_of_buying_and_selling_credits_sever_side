using BLL.DTO;
using BLL.functions;
using BLL.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserBll uBll;
        public UsersController(IUserBll ub)
        {
            uBll = ub;
        }

        [HttpPost]
        public ActionResult<bool> put(UsersDTO user)
        {
            return Ok(uBll.AddUser(user));
        }
        //("{id}")
        [HttpGet]
        public ActionResult<UsersDTO> GetUserById(string id, string sisma)
        {
            return Ok(uBll.GetUserByTz(id, sisma));
        }
    }
}
