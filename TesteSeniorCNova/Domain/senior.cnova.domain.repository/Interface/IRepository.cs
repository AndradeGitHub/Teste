using System;
using System.Collections.Generic;
using System.Linq;

namespace senior.cnova.domain.repository.interfaces
{
    public interface IRepository<T>
    {            
        IList<T> GetAll();        
    }
}
