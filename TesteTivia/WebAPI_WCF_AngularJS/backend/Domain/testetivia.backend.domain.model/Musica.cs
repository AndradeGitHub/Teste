using System.Collections.Generic;

namespace testetivia.backend.domain.model
{
    public class Musica : Entity
    {
        public string Nome { get; set; }
        public string Genero { get; set; }
        public double Duracao { get; set; }        
        public virtual ICollection<Cd> Cds { get; set; }
    }
}
