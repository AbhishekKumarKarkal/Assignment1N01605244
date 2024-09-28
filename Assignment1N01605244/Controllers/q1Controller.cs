using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1N01605244.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {

        /// <summary>
        /// Receives an HTTP GET request with empty string and provides a response message.
        /// </summary>
        /// <returns>An HTTP response as a string.</returns>
        /// <example>
        /// GET api/q1
        /// GET http://localhost:xx/api/q1 -> Welcome to 5125!

        /// </example>



        [HttpGet("Welcome")]
        public string q1()
        {
            return "Welcome to 5125!";
        }

     }
}
