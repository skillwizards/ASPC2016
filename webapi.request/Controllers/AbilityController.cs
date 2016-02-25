using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using common.model;

namespace webapi.request.Controllers
{
    public class AbilityController : ApiController
    {
        /// <summary>
        /// Get the full list of all available Superhero Abilities
        /// </summary>
        /// <returns>List<SuperheroAbility> as a complete list of all available abilities</returns>
        [ActionName("getpowers")]
        public List<SuperheroAbility> Get() {
            throw new NotImplementedException();
        } 


    }
}
