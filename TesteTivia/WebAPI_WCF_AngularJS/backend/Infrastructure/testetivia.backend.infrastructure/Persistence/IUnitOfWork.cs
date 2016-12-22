using System.Data.Entity;

using testetivia.backend.domain.model;

namespace testetivia.backend.infrastructure.persistence.interfaces
{
    public interface IUnitOfWork
    {
        IDbSet<Cd> Cd { get; set; }
        IDbSet<Musica> Musica { get; set; }

        void Commit();
    }
}
