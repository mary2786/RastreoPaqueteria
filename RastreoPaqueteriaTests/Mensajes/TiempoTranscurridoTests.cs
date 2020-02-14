using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RastreoPaqueteria.Dtos;
using System;

namespace RastreoPaqueteria.Mensajes.Tests
{
    [TestClass()]
    public class TiempoTranscurridoTests
    {
        private Mock<IReloj> _reloj;
        private TiempoTranscurrido _tiempoTranscurrido;

        [TestInitialize]
        public void Setup()
        {
            _reloj = new Mock<IReloj>();
            _tiempoTranscurrido = new TiempoTranscurrido(_reloj.Object);
        }

        [TestMethod()]
        public void TiempoTranscurrido_FechaActualEsMenorQuefechaEntrega_RegresaTiempoTranscurrido()
        {
            //Arrange
            _reloj.SetupGet(s => s.FechaActual).Returns(new DateTime(2019, 10, 25));
            DateTime fechaEntrega = new DateTime(2019, 11, 26);
            int diasExp = 32;

            //Act    
            TiempoTranscurridoDto tiempoTranscurrido = _tiempoTranscurrido.ObtenerTiempoTranscurrido(fechaEntrega);

            //Assert
            Assert.IsFalse(tiempoTranscurrido.EsTiempoPasado);
            Assert.AreEqual(diasExp, tiempoTranscurrido.TotalTiempoTranscurrido.Days);
        }

        [TestMethod()]
        public void TiempoTranscurrido_FechaActualEsMayorQuefechaEntrega_RegresaTiempoTranscurrido()
        {
            //Arrange
            _reloj.SetupGet(s => s.FechaActual).Returns(new DateTime(2019, 12, 25));
            DateTime fechaEntrega = new DateTime(2019, 11, 26);
            int diasExp = 29;

            //Act    
            TiempoTranscurridoDto tiempoTranscurrido = _tiempoTranscurrido.ObtenerTiempoTranscurrido(fechaEntrega);

            //Assert
            Assert.IsTrue(tiempoTranscurrido.EsTiempoPasado);
            Assert.AreEqual(diasExp, tiempoTranscurrido.TotalTiempoTranscurrido.Days);
        }
    }
}