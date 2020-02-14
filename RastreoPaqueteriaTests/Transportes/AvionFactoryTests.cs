using Microsoft.VisualStudio.TestTools.UnitTesting;
using RastreoPaqueteria.Transportes.Interfaces;

namespace RastreoPaqueteria.Transportes.Tests
{
    [TestClass()]
    public class AvionFactoryTests
    {
        [TestMethod()]
        public void CrearTransporte_CreacionAvion_ObjetoAvionCreadoCorrectamente()
        {
            //Arrange
            string NombreExp = "Avión";
            double costoKilometro = 10;
            double velocidadEntrega = 600;

            //Act
            AvionFactory avionFactory = new AvionFactory();
            ITransporte avion = avionFactory.CrearTransporte();

            //Assert
            Assert.AreEqual(NombreExp, avion.Nombre);
            Assert.AreEqual(costoKilometro, avion.CostoXKilometro);
            Assert.AreEqual(velocidadEntrega, avion.VelocidadEntrega);
        }
    }
}