using System;
using System.Collections.Generic;
using System.Linq;

using testetivia.backend.domain.repository.interfaces;

namespace testetivia.backend.domain.repository
{
    public class Repository<T> : IRepository<T>
    {
        public virtual void Add(T entity)
        {
            throw new NotImplementedException();
        }
        public virtual void Add(List<T> entity)
        {
            throw new NotImplementedException();
        }

        public virtual IList<T> Get(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual T GetById(int id)
        {
            throw new NotImplementedException();
        }
        public virtual IList<T> GetColById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
