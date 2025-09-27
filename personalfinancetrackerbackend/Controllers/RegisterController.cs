using Microsoft.AspNetCore.Mvc;
using personalfinancetrackerbackend.Model.ModelDTO;
using System.Runtime.CompilerServices;

namespace personalfinancetrackerbackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegisterController:ControllerBase
    {
//check if password is good
/**
 * Below is pretty useless since we
 * have stuff in model
 */
        private bool isPasswordGood(string password)
        {
            Int16 minLengthOfPassword = 8;

            if(password.Length == 0 || password.Length <minLengthOfPassword) {
                return false; 
            }
            return true;
            
        }

        private bool doesPasswordAndConfirmPasswordMathc(string password, string confirmPassword)
        {
            if (password == confirmPassword) return true;
            return false;
        }

        [HttpPost]
        internal ActionResult registerUser([FromBody] UserModelDTO user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //do some checks
            return Ok();
        }
    }
}
