using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RastreoPaqueteria.Envio.Tests
{
    [TestClass()]
    public class EnvioServiceTests
    {
        [TestMethod()]
        public void CalcularCostoEnvio_DatosCorrectos_RegresaCostoEnvioCorrecto()
        {
            //Arrange
            double distancia = 1;
            double margenUtilidad = 1;
            double costoKilometro = 1;
            double costoEnvioExp = 1.01;

            //Act
            EnvioService envioService = new EnvioService();
            double costoEnvioAct = envioService.CalcularCostoEnvio(distancia, margenUtilidad, costoKilometro);

            //Assert
            Assert.AreEqual(costoEnvioExp, costoEnvioAct);

        }

        [TestMethod()]
        public void CalcularFechaEntrega_DatosCorrectos_RegresaFechaEnvioCorrecta()
        {
            //Arrange
            DateTime fecha = new DateTime(2020, 2, 14, 11, 19, 29);
            double tiempoTraslado = 1;
            DateTime fechaEntregaExp = new DateTime(2020, 2, 14, 12, 19, 29);

            //Act
            EnvioService envioService = new EnvioService();
            DateTime fechaEntregaAct = envioService.CalcularFechaEntrega(fecha, tiempoTraslado);

            //Assert
            Assert.AreEqual(fechaEntregaExp, fechaEntregaAct);
        }

        [TestMethod()]
        public void CalcularTiempoTraslado_DatosCorrectos_RegresaFechaEnvioCorrecta()
        {
            //Arrange
            double velocidad = 1;
            double distancia = 1;
            double tiempoTrasladoExp = 1;

            //Act
            EnvioService envioService = new EnvioService();
            double tiempoTrasladoAct = envioService.CalcularTiempoTraslado(distancia, velocidad);

            //Assert
            Assert.AreEqual(tiempoTrasladoExp, tiempoTrasladoAct);
        }
    }
}