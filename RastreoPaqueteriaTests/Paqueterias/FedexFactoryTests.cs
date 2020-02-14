using Microsoft.VisualStudio.TestTools.UnitTesting;
using RastreoPaqueteria.Paqueterias.Interfaces;

namespace RastreoPaqueteria.Paqueterias.Tests
{
    [TestClass()]
    public class FedexFactoryTests
    {
        [TestMethod()]
        public void CrearPaqueteria_CreacionFedex_ObjetoFedexCreadoCorrectamente()
        {
            //Arrange
            string nombreExp = "Fedex";
            double margenUtilidad = 50;

            //Act
            FedexFactory factory = new FedexFactory();
            IPaqueteria paqueteria = factory.CrearPaqueteria();

            //Assert
            Assert.AreEqual(nombreExp, paqueteria.Nombre);
            Assert.AreEqual(margenUtilidad, paqueteria.MargenUtilidad);
        }
    }
}