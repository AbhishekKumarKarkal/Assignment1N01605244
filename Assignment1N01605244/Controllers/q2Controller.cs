using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1N01605244.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {

        /// <summary>
        /// Receives an HTTP GET request with a name and provides a response message.
        /// </summary>
        /// <returns>An HTTP response as a string.</returns>
        /// <example>
        /// GET api/q2/greeting
        /// GET http://localhost:xx/api/q2/greeting/gary -> Hi Gary!

        /// </example>



        [HttpGet(template: "greeting")]
        public string greeting(string name)
        {
            return $"Hi {name}!";
            
        }


    }
}
