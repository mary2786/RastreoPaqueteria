using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RastreoPaqueteria.Dtos;
using RastreoPaqueteria.Envio;
using RastreoPaqueteria.Mensajes;
using RastreoPaqueteria.Paqueterias;
using RastreoPaqueteria.Paqueterias.Interfaces;
using RastreoPaqueteria.Transportes;
using RastreoPaqueteria.Transportes.Interfaces;
using System;

namespace RastreoPaqueteria.Servicios.Tests
{
    [TestClass()]
    public class RastreoServiceTests
    {
        private Mock<IEnvioService> _envioService;
        private Mock<IAdministradorMensaje> _administradorMensaje;
        private RastreoService _rastreoService;
        private PedidoDto _pedido;
        private IPaqueteria _paqueteria;
        private ITransporte _transporte;

        [TestInitialize]
        public void Setup()
        {
            _envioService = new Mock<IEnvioService>();
            _administradorMensaje = new Mock<IAdministradorMensaje>();
            _rastreoService = new RastreoService(_envioService.Object, _administradorMensaje.Object);

            _pedido = new PedidoDto()
            {
                Destino = "Destino",
                Origen = "Origen",
                Distancia = 80,
                Paqueteria = "Paqueteria",
                Transporte = "Transporte"
            };

            _paqueteria = new Fedex()
            {
                Nombre = "Fedex",
                MargenUtilidad = 40
            };

            _transporte = new Barco()
            {
                CostoXKilometro = 1,
                Nombre = "Barco",
                VelocidadEntrega = 46
            };
        }

        [TestMethod()]
        public void ObtenerMensajeRastreo_InvocacionMetodos_SeInvocanMetodosCorrectamente()
        {
            //Arrange
            _envioService.Setup(s => s.CalcularCostoEnvio(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<double>())).Returns(It.IsAny<double>);
            _envioService.Setup(s => s.CalcularFechaEntrega(It.IsAny<DateTime>(), It.IsAny<double>())).Returns(It.IsAny<DateTime>);
            _envioService.Setup(s => s.CalcularCostoEnvio(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<double>())).Returns(It.IsAny<double>);
            _administradorMensaje.Setup(s => s.ObtenerMensajeEnvio(It.IsAny<PedidoDto>(), It.IsAny<DateTime>(), It.IsAny<double>())).Returns(It.IsAny<MensajeDto>);

            //Act
            _rastreoService.ObtenerMensajeRastreo(_pedido, _paqueteria, _transporte);

            //Assert
            _envioService.Verify(v => v.CalcularCostoEnvio(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<double>()), Times.Once);
            _envioService.Verify(v => v.CalcularFechaEntrega(It.IsAny<DateTime>(), It.IsAny<double>()), Times.Once);
            _envioService.Verify(v => v.CalcularCostoEnvio(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<double>()), Times.Once);
            _administradorMensaje.Verify(v => v.ObtenerMensajeEnvio(It.IsAny<PedidoDto>(), It.IsAny<DateTime>(), It.IsAny<double>()), Times.Once);


        }
    }
}