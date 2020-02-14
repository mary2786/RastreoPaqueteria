using Microsoft.VisualStudio.TestTools.UnitTesting;
using RastreoPaqueteria.Paqueterias.Interfaces;

namespace RastreoPaqueteria.Paqueterias.Tests
{
    [TestClass()]
    public class DhlFactoryTests
    {
        [TestMethod()]
        public void CrearPaqueteria_CreacionDhl_ObjetoDhlCreadoCorrectamente()
        {
            //Arrange
            string nombreExp = "Dhl";
            double margenUtilidad = 40;

            //Act
            DhlFactory dhlFactory = new DhlFactory();
            IPaqueteria paqueteria = dhlFactory.CrearPaqueteria();

            //Assert
            Assert.AreEqual(nombreExp, paqueteria.Nombre);
            Assert.AreEqual(margenUtilidad, paqueteria.MargenUtilidad);
        }
    }
}