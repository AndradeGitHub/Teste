using System.Data.Entity;

using senior.cnova.domain.model;

namespace senior.cnova.infrastructure.persistence.interfaces
{
    public interface IUnitOfWork
    {
        IDbSet<Amigo> Amigo { get; set; }        

        void Commit();
    }
}
