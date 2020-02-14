using Microsoft.VisualStudio.TestTools.UnitTesting;
using RastreoPaqueteria.Dtos;

namespace RastreoPaqueteria.Mensajes.Tests
{
    [TestClass()]
    public class GeneradorMensajeTests
    {
        private PedidoDto _pedido;
        private double _costoEnvio;

        [TestInitialize]
        public void Setup()
        {
            _pedido = new PedidoDto()
            {
                Destino = "Destino",
                Origen = "Origen",
                Distancia = 80,
                Paqueteria = "Paqueteria",
                Transporte = "Transporte"
            };

            _costoEnvio = 90;
        }

        [TestMethod()]
        public void GenerarMensaje_ParametroEsTiempoPasadoFalse_RegresaMensajeCorrecto()
        {
            //Arrange
            bool esTiempoPasado = false;
            string rangoFecha = "1 mes";
            string mensajeExp = "Tu paquete ha salido de Origen y llegará a Destino dentro de 1 mes y tendrá un costo de 90 de envío (Cualquier reclamación con Paqueteria)";
            //Act
            GeneradorMensaje generadorMensaje = new GeneradorMensaje();
            string mensajeAct = generadorMensaje.GenerarMensaje(_pedido, esTiempoPasado, rangoFecha, _costoEnvio);

            //Assert
            Assert.AreEqual(mensajeExp, mensajeAct);
        }

        [TestMethod()]
        public void GenerarMensaje_ParametroEsTiempoPasadoTrue_RegresaMensajeCorrecto()
        {
            //Arrange
            bool esTiempoPasado = true;
            string rangoFecha = "2 días";
            string mensajeExp = "Tu paquete salió de Origen y llegó a Destino hace 2 días y tuvo un costo de 90 de envío (Cualquier reclamación con Paqueteria)";
            //Act
            GeneradorMensaje generadorMensaje = new GeneradorMensaje();
            string mensajeAct = generadorMensaje.GenerarMensaje(_pedido, esTiempoPasado, rangoFecha, _costoEnvio);

            //Assert
            Assert.AreEqual(mensajeExp, mensajeAct);
        }
    }
}