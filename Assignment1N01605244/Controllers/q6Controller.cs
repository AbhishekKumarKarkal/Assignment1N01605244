using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1N01605244.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request and provides a response answer.
        /// </summary>
        /// <param name="side">Receives the value of side from user</param>
        /// <returns>Answer of area of hexagon</returns>
        /// <example>
        
        /// GET http://localhost:xx/api/q6/hexagon?side=1 -> 2.598076211353316
        /// </example>



        [HttpGet(template: "hexagon")]
        public double hexagon(double side)
        {
            double ans = (3 * Math.Sqrt(3) * Math.Pow(side , 2))/2;
            
            return ans;

        }






    }
}
