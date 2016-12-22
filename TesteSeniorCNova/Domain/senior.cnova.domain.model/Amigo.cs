using System.ComponentModel.DataAnnotations.Schema;

namespace senior.cnova.domain.model
{
    public class Amigo : Entity
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        [NotMapped] public double Distancia { get; set; }
    }
}
