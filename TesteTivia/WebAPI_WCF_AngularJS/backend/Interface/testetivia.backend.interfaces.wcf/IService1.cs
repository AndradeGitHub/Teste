using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using testetivia.backend.domain.model;

namespace testetivia.backend.interfaces.wcf
{    
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Musica> GetMusica(string nome);

        [OperationContract]
        bool AddCd(Cd cd);

        [OperationContract]
        List<Cd> GetCd(string titulo, string artista, string generoMusica, string nomeMusica);
    }        
}
