using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using testetivia.backend.application;
using testetivia.backend.domain.model;

namespace testetivia.backend.interfaces.wcf
{    
    public class Service1 : IService1
    {
        private static readonly MusicaFacade musicaFacade = new MusicaFacade();
        private static readonly CdFacade cdFacade = new CdFacade();

        public List<Musica> GetMusica(string nome)
        {
            var result = musicaFacade.GetMusica(nome);

            return result.ToList<Musica>();
        }

        public bool AddCd(Cd cd)
        {
            cdFacade.AddCd(cd);

            return true; 
        }

        public List<Cd> GetCd(string titulo, string artista, string generoMusica, string nomeMusica)
        {
            var result = cdFacade.GetCd(titulo, artista, generoMusica, nomeMusica);

            return result.ToList<Cd>();
        }
    }
}