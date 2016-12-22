using System;

using senior.cnova.domain.interfaces;

namespace senior.cnova.domain
{
    public class Operation : IOperation
    {
        public virtual double CalcularDistancia(double lat1, double lon1, double lat2, double lon2)
        {
            throw new NotImplementedException();
        }        
    }
}
