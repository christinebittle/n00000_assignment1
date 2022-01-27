using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n000000_w2022_assignment1.Controllers
{
    public class TestController : ApiController
    {
        /// <summary>
        /// Returns the input number minus 10
        /// </summary>
        /// <param name="number">The input number</param>
        /// <returns>The input with 10 subtracted</returns>
        /// example:
        /// GET /api/Test/70 -> 60
        [Route("api/Test/Get1/{number}")]
        public int Get1(int number)
        {

            return number-10;
        }

        /// <summary>
        /// Inputs a message and echos back the same message
        /// </summary>
        /// <param name="message">The input message</param>
        /// <returns>The same message that was inputted</returns>
        [Route("api/Test/Get2/{message}")]
        public string Get2(string message)
        {
            return message;
        }

    }
}
