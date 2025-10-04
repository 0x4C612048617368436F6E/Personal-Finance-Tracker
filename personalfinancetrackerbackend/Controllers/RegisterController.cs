using Microsoft.AspNetCore.Mvc;
using personalfinancetrackerbackend.Model.ModelDTO;
using System.Runtime.CompilerServices;
using personalfinancetrackerbackend.DatabaseInteraction;

namespace personalfinancetrackerbackend.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class RegisterController:ControllerBase
    {
        private readonly DataInteraction _dataInteraction;
        public RegisterController(DataInteraction _databaseContext)
        {
            this._dataInteraction = _databaseContext;   
        }
        //check if password is good
        /**
         * Below is pretty useless since we
         * have stuff in model
         */
        private readonly ILogger<RegisterController> _logger; 
        public RegisterController(ILogger<RegisterController> _logger)
        {
            this._logger = _logger;
        }
        private bool isPasswordGood(string password)
        {
            Int16 minLengthOfPassword = 8;

            if(password.Length == 0 || password.Length <minLengthOfPassword) {
                this._logger.LogError("Provided password length is unsatisfied");
                return false; 
            }
            return true;
            
        }

        private bool doesPasswordAndConfirmPasswordMatch(string password, string confirmPassword)
        {
            if (password == confirmPassword)
            {
                this._logger.LogError("Ok");
                return true;
            }
            this._logger.LogError("Provided password and confirm password not same");
            return false;
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult registerUser([FromBody] UserModelDTO user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //do some checks
            var password = ModelState["password"].RawValue.ToString();
            var confirmPassword = ModelState["confirmPassword"].RawValue.ToString();

            if (!doesPasswordAndConfirmPasswordMatch(password, confirmPassword))
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
