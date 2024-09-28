using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1N01605244.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request and provides a response answer.
        /// </summary>
        /// <param name="num">Receives the number from user</param>
        /// <returns>Cube root of a number</returns>
        /// <example>
        
        /// GET http://localhost:xx/api/q3/cube/4 -> 64
        /// </example>





        [HttpGet(template: "cube/{num}")]
        public double cube(double num) {

            double power = 3;

            double ans = Math.Pow(num, power);
            return ans;
        
        
        }

    }
}
