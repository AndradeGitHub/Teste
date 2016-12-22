using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

using testetivia.backend.domain.model;
using testetivia.backend.infrastructure.persistence;
using testetivia.backend.infrastructure.persistence.interfaces;

namespace testetivia.backend.domain.repository
{
    public class MusicaRepository : Repository<Musica>
    {
        private readonly IUnitOfWork _db;

        public MusicaRepository(IUnitOfWork unitOfWork)
        {
            _db = unitOfWork;
        }
        
        public override IList<Musica> Get(Musica musica)
        {            
            return _db.Musica.Where(lo => lo.Nome.ToLower().Equals(musica.Nome.ToLower())).ToList();            
        }
    }
}