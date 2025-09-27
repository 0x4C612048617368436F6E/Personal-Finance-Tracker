using Microsoft.AspNetCore.Mvc;
using personalfinancetrackerbackend.Model.ModelDTO;

namespace personalfinancetrackerbackend.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    internal class LoginController:ControllerBase
    {
        //enable user to login
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        internal ActionResult loginUser([FromBody] UserModelDTO user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok();
        }
    }
}
