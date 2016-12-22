using System.Collections.Generic;
using System.Net;
using System.Web.Http;

using testetivia.backend.interfaces.webapi.Models;
using testetivia.backend.application;
using testetivia.backend.domain.model;

namespace testetivia.backend.interfaces.webapi.Controllers
{
    [RoutePrefix("api/Musica")]
    public class MusicaController : ApiController
    {
        private static readonly MusicaFacade musicaFacade = new MusicaFacade();

        //GET: /api/Musica/
        [Route("GetMusica", Name = "GetMusicaV1")]
        [HttpGet]
        public IHttpActionResult GetMusica(string nome)
        {
            var result = musicaFacade.GetMusica(nome);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
