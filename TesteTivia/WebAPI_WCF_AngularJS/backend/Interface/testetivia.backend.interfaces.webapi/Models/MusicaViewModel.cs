using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testetivia.backend.interfaces.webapi.Models
{
    public class MusicaViewModel : EntityViewModel
    {
        public string Nome { get; set; }
        public string Genero { get; set; }
        public double Duracao { get; set; }
        public List<CdViewModel> Cds { get; set; }
    }
}