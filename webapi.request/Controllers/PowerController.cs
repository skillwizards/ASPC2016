using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using common.model;

namespace webapi.request.Controllers
{
    public class PowerController : ApiController
    {
        /// <summary>
        /// Gets all available superhero Powers
        /// </summary>
        /// <returns>List<SuperheroPowers> as a list of all powers</returns>
        [ActionName("getpowers")]
        public List<SuperheroPowers> Get() {
            throw new NotImplementedException();
        }
    }
}
