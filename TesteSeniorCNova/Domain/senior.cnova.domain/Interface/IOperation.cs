using System.Collections.Generic;
using System.Threading.Tasks;

namespace senior.cnova.domain.interfaces
{
    public interface IOperation
    {
        double CalcularDistancia(double lat1, double lon1, double lat2, double lon2);
    }
}