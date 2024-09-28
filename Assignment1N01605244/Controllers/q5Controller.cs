using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1N01605244.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {

        /// <summary>
        /// Receives an HTTP POST request with a body and provides a response message.
        /// </summary>

        /// <returns>An HTTP response with a body echoing the request body.</returns>
        /// <example>
        /// POST api/q5/secret
        /// HEADERS: Content-Type: application/json
        /// FORM DATA: "request body"
      
        /// </example>




        [HttpPost(template: "secret")]
        public string secret([FromBody]int secretnumber)
        {
            return $"Shh.. the secret is {secretnumber}";
        }

    }
}
