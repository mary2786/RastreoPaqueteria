using Microsoft.VisualStudio.TestTools.UnitTesting;
using RastreoPaqueteria.Transportes.Interfaces;

namespace RastreoPaqueteria.Transportes.Tests
{
    [TestClass()]
    public class BarcoFactoryTests
    {
        [TestMethod()]
        public void CrearTransporte_CreacionBarco_ObjetoBarcoCreadoCorrectamente()
        {
            //Arrange
            string NombreExp = "Barco";
            double costoKilometro = 1;
            double velocidadEntrega = 46;

            //Act
            BarcoFactory barcoFactory = new BarcoFactory();
            ITransporte barco = barcoFactory.CrearTransporte();

            //Assert
            Assert.AreEqual(NombreExp, barco.Nombre);
            Assert.AreEqual(costoKilometro, barco.CostoXKilometro);
            Assert.AreEqual(velocidadEntrega, barco.VelocidadEntrega);
        }
    }
}