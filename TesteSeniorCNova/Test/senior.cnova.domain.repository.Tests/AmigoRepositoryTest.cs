using Microsoft.VisualStudio.TestTools.UnitTesting;

using senior.cnova.domain.model;
using senior.cnova.domain.repository;
using senior.cnova.infrastructure.persistence;

namespace senior.cnova.domain.repository.Tests
{
    [TestClass]
    public class AmigoRepositoryTest
    {
        [TestMethod]
        public void GetAllAmigoRepository_SUCESS()
        {
            var unitOfWork = new UnitOfWork();
            var amigoRepository = new AmigoRepository(unitOfWork);

            var lstAmigo = amigoRepository.GetAll();

            Assert.IsNotNull(lstAmigo);
        }
    }
}
