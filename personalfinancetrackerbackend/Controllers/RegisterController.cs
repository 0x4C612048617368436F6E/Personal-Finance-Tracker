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

        private bool doesPasswordAndConfirmPasswordMatch(string password, string confirmPassword)
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
            var password = ModelState?["password"].RawValue.ToString();
            var confirmPassword = ModelState?["confirmPassword"].RawValue.ToString();

            if (!doesPasswordAndConfirmPasswordMatch(password, confirmPassword))
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
