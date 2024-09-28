using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1N01605244.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {

        /// <summary>
        /// Receives an HTTP POST request with an empty body and provides a response message.
        /// </summary>
        /// <returns>An HTTP response as a string.</returns>
        /// <example>
        /// POST api/q4/knockknock
        /// FORM DATA: (empty)
        /// -> Received a POST request Who's there?
        /// </example>





        [HttpPost(template: "knockknock")]
        public string knockknock()
        {

            return "Who's there?";
        }



    }
}
