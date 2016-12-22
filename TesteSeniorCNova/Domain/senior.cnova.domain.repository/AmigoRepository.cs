using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

using senior.cnova.domain.model;
using senior.cnova.infrastructure.persistence.interfaces;

namespace senior.cnova.domain.repository
{
    public class AmigoRepository : Repository<Amigo>
    {
        private readonly IUnitOfWork _db;

        public AmigoRepository(IUnitOfWork unitOfWork)
        {
            _db = unitOfWork;
        }

        public override IList<Amigo> GetAll()
        {
            return _db.Amigo.ToList();
        }
    }
}