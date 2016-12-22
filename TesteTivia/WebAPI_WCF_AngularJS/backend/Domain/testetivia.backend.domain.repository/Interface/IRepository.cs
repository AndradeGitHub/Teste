using System;
using System.Collections.Generic;
using System.Linq;

namespace testetivia.backend.domain.repository.interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Add(List<T> entity);
        IList<T> Get(T entity);
        T GetById(int id);
        IList<T> GetColById(int id);           
    }
}
