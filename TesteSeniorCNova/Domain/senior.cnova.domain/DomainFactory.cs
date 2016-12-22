using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

using senior.cnova.domain.interfaces;
using senior.cnova.infrastructure.persistence.interfaces;

namespace senior.cnova.domain
{
    public static class DomainFactory
    {
        public static IOperation CreateDomain<O>(IUnitOfWork unitOfWork)
        {
            IUnityContainer container = new UnityContainer();

            container.LoadConfiguration();

            container.RegisterType(typeof(IOperation), typeof(O)).RegisterInstance(unitOfWork);

            return container.Resolve<IOperation>();
        }
    }
}
