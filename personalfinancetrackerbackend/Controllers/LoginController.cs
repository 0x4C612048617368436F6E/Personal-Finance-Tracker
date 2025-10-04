using Microsoft.AspNetCore.Mvc;
using personalfinancetrackerbackend.Model.ModelDTO;
using personalfinancetrackerbackend.DatabaseInteraction;

namespace personalfinancetrackerbackend.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class LoginController:ControllerBase
    {
        private readonly DataInteraction _databaseContext;
        public LoginController(DataInteraction _databaseContext)
        {
            this._databaseContext = _databaseContext;
        }
        //enable user to login
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult loginUser([FromBody] UserModelDTO user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok();
        }
    }
}
