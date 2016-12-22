using System.Collections.Generic;

namespace testetivia.backend.interfaces.webapi.Models
{
    public class CdViewModel : EntityViewModel
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }

        public CdViewModel()
        {
            this.Musicas = new HashSet<MusicaViewModel>();
        }

        public virtual ICollection<MusicaViewModel> Musicas { get; set; }
    }
}