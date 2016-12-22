using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace testetivia.backend.domain.model
{
    public class Cd : Entity
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        [NotMapped]
        public double TotalDuracao { get; set; }

        public Cd()
        {
            this.Musicas = new HashSet<Musica>();
        }

        public virtual ICollection<Musica> Musicas { get; set; }
    }
}
