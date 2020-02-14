using Microsoft.VisualStudio.TestTools.UnitTesting;
using RastreoPaqueteria.Transportes.Interfaces;

namespace RastreoPaqueteria.Transportes.Tests
{
    [TestClass()]
    public class TrenFactoryTests
    {
        [TestMethod()]
        public void CrearTransporte_CreacionTren_ObjetoTrenCreadoCorrectamente()
        {
            //Arrange
            string NombreExp = "Tren";
            double costoKilometro = 5;
            double velocidadEntrega = 80;

            //Act
            TrenFactory trenFactory = new TrenFactory();
            ITransporte tren = trenFactory.CrearTransporte();

            //Assert
            Assert.AreEqual(NombreExp, tren.Nombre);
            Assert.AreEqual(costoKilometro, tren.CostoXKilometro);
            Assert.AreEqual(velocidadEntrega, tren.VelocidadEntrega);
        }
    }
}