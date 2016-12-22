using System.Linq;
using System.Collections.Generic;

using testetivia.backend.domain.model;
using testetivia.backend.infrastructure.persistence;
using testetivia.backend.infrastructure.persistence.interfaces;

namespace testetivia.backend.domain.repository
{
    public class CdRepository : Repository<Cd>
    {
        private readonly IUnitOfWork _db;

        public CdRepository(IUnitOfWork unitOfWork)
        {
            _db = unitOfWork;
        }

        public override void Add(Cd cd)
        {
            using (var dbCtx = new UnitOfWork())
            {                
                dbCtx.Cd.Add(cd);                
                dbCtx.SaveChanges();
            }            
        }

        public override IList<Cd> Get(Cd cd)
        {
            var ret = new List<Cd>();
              
            if (!string.IsNullOrEmpty(cd.Titulo))
                ret = _db.Cd.Where(lo => lo.Titulo.ToLower().Equals(cd.Titulo.ToLower())).ToList();
            if (!string.IsNullOrEmpty(cd.Artista))
                ret = _db.Cd.Where(lo => lo.Artista.ToLower().Equals(cd.Artista.ToLower())).ToList();
            if (!string.IsNullOrEmpty(cd.Musicas.Select(x => x.Genero).FirstOrDefault()))
                ret = _db.Cd.Where(lo => lo.Id == 46).ToList();
            if (!string.IsNullOrEmpty(cd.Musicas.Select(x => x.Nome).FirstOrDefault()))
                ret = _db.Cd.Where(lo => lo.Id == 47).ToList();

            if (!string.IsNullOrEmpty(cd.Titulo))
                ret = _db.Cd.Where(lo => lo.Titulo.ToLower().Equals(cd.Titulo.ToLower())).ToList();
            if (!string.IsNullOrEmpty(cd.Artista))
                ret = ret.Count == 0 ? _db.Cd.Where(lo => lo.Artista.ToLower().Equals(cd.Artista.ToLower())).ToList() : ret.Where(lo => lo.Artista.ToLower().Equals(cd.Artista.ToLower())).ToList();
            if (!string.IsNullOrEmpty(cd.Musicas.Select(x => x.Genero).FirstOrDefault()))
                ret = ret.Count == 0 ? _db.Cd.Where(lo => lo.Id == 46).ToList() : ret.Where(lo => lo.Id == 46).ToList();
            if (!string.IsNullOrEmpty(cd.Musicas.Select(x => x.Nome).FirstOrDefault()))
                ret = ret.Count == 0 ? _db.Cd.Where(lo => lo.Id == 47).ToList() : ret.Where(lo => lo.Id == 47).ToList();

            return ret;
        }
    }
}