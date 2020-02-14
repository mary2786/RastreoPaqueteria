using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RastreoPaqueteria.Dtos;
using System;

namespace RastreoPaqueteria.Servicios.Tests
{
    [TestClass()]
    public class ValidadorFormatoPedidoTests
    {
        private Mock<IConvertidorFecha> _convertidorFecha;
        private Mock<IConvertidorDouble> _convertidorDouble;
        private ValidadorFormatoPedido _validadorFormatoPedido;

        [TestInitialize]
        public void Setup()
        {
            _convertidorFecha = new Mock<IConvertidorFecha>();
            _convertidorDouble = new Mock<IConvertidorDouble>();
            _validadorFormatoPedido = new ValidadorFormatoPedido(_convertidorFecha.Object, _convertidorDouble.Object);
        }

        [TestMethod()]
        public void ValidarFormatoPedido_PedidoFormatoCorrecto_RegresaPedidoDto()
        {
            //Arrange
            string pedido = "Ticul,Motul,80,Estafeta,Tren,23-01-2020 12:00:00";
            string origen = "Ticul";
            string destino = "Motul";
            double distancia = 80;
            string paqueteria = "Estafeta";
            string transporte = "Tren";
            DateTime fechaPedido = new DateTime(2020, 1, 23, 12, 0, 0);

            _convertidorFecha.Setup(s => s.ConvertirTextoAFecha(It.IsAny<string>())).Returns(fechaPedido); ;
            _convertidorDouble.Setup(s => s.ConvertirTextoADouble(It.IsAny<string>())).Returns(distancia);

            //Act
            PedidoDto pedidoDto = _validadorFormatoPedido.ValidarFormatoPedido(pedido);

            //Assert
            Assert.AreEqual(origen, pedidoDto.Origen);
            Assert.AreEqual(destino, pedidoDto.Destino);
            Assert.AreEqual(distancia, pedidoDto.Distancia);
            Assert.AreEqual(paqueteria, pedidoDto.Paqueteria);
            Assert.AreEqual(transporte, pedidoDto.Transporte);
            Assert.AreEqual(fechaPedido, pedidoDto.Fecha);
        }

        [TestMethod()]
        public void ValidarFormatoPedido_PedidoFormatoIncorrecto_ThrowFormatException()
        {
            //Arrange
            string pedido = "Ticul,Motul,80,Tren,23-01-2020 12:00:00";
            string messageExp = "El texto con los datos del pedido no tiene el formato correcto. (" + pedido + ")";

            //Act
            FormatException exception = Assert.ThrowsException<FormatException>(() => _validadorFormatoPedido.ValidarFormatoPedido(pedido));

            //Assert
            Assert.AreEqual(messageExp, exception.Message);
        }
    }
}