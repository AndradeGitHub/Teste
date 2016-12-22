using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

using senior.cnova.infrastructure.persistence.interfaces;
using senior.cnova.domain.repository.interfaces;

namespace senior.cnova.domain.repository
{
    public static class RepositoryFactory
    {
        public static IRepository<T> CreateRepository<T, R>(IUnitOfWork unitOfWork)
        {
            IUnityContainer container = new UnityContainer();

            container.LoadConfiguration();

            container.RegisterType(typeof(IRepository<T>), typeof(R)).RegisterInstance(unitOfWork);

            return container.Resolve<IRepository<T>>();
        }
    }
}