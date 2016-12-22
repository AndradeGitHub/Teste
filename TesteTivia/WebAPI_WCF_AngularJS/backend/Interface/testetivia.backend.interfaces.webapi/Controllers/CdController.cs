using System.Collections.Generic;
using System.Net;
using System.Web.Http;

using testetivia.backend.interfaces.webapi.Models;
using testetivia.backend.application;
using testetivia.backend.domain.model;

namespace testetivia.backend.interfaces.webapi.Controllers
{    
    [RoutePrefix("api/Cd")]
    public class CdController : ApiController
    {
        private static readonly CdFacade cdFacade = new CdFacade();

        //POST: /api/Cd/
        [Route("AddCd", Name = "AddCdV1")]
        [HttpPost]
        public IHttpActionResult AddCd(Cd cd)
        {
            cdFacade.AddCd(cd);

            return Ok(HttpStatusCode.OK);
        }

        //GET: /api/Cd/
        [Route("GetCd", Name = "GetCdV1")]
        [HttpGet]
        public IHttpActionResult GetCd(string titulo, string artista, string generoMusica, string nomeMusica)
        {           
            var result = cdFacade.GetCd(titulo, artista, generoMusica, nomeMusica);

            if (result == null || result.Count.Equals(0))
                return NotFound();

            return Ok(result);
        }
    }
}
