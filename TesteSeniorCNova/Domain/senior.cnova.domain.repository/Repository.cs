using System;
using System.Collections.Generic;
using System.Linq;

using senior.cnova.domain.repository.interfaces;

namespace senior.cnova.domain.repository
{
    public class Repository<T> : IRepository<T>
    {
        public virtual IList<T> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
