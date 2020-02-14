using Microsoft.VisualStudio.TestTools.UnitTesting;
using RastreoPaqueteria.Paqueterias.Interfaces;

namespace RastreoPaqueteria.Paqueterias.Tests
{
    [TestClass()]
    public class EstafetaFactoryTests
    {
        [TestMethod()]
        public void CrearPaqueteria_CreacionEstafeta_ObjetoEstafetaCreadoCorrectamente()
        {
            //Arrange
            string nombreExp = "Estafeta";
            double margenUtilidad = 20;

            //Act
            EstafetaFactory estafetaFactory = new EstafetaFactory();
            IPaqueteria paqueteria = estafetaFactory.CrearPaqueteria();

            //Assert
            Assert.AreEqual(nombreExp, paqueteria.Nombre);
            Assert.AreEqual(margenUtilidad, paqueteria.MargenUtilidad);
        }
    }
}