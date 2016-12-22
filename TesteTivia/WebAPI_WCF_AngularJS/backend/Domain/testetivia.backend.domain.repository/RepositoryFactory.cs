using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

using testetivia.backend.infrastructure.persistence.interfaces;
using testetivia.backend.domain.repository.interfaces;

namespace testetivia.backend.domain.repository
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