using Microsoft.VisualStudio.TestTools.UnitTesting;

using senior.cnova.domain;

namespace senior.cnova.domain.Tests
{
    [TestClass]
    public class ProximidadeTest
    {
        [TestMethod]
        public void CalcularDistancia_SUCESS()
        {
            Proximidade proximidade = new Proximidade();

            var distancia = proximidade.CalcularDistancia(-19.928965, -43.936599, -19.932184, -43.937987);            

            Assert.IsNotNull(distancia);
        }
    }
}