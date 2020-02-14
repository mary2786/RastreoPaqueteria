using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RastreoPaqueteria.Mensajes.Tests
{
    [TestClass()]
    public class TiempoTranscurridoMesTests
    {
        [TestMethod()]
        [DataRow(35, 23, 59, 59)]
        [DataRow(0, 720, 59, 59)]
        [DataRow(0, 0, 43200, 59)]
        [DataRow(0, 0, 0, 2592000)]
        public void ObtenerMensajeTiempoTranscurrido_TimespanEquivalenteAUnMes_RegresaMensajeQueIndicaUnMes(int dias, int horas, int minutos, int segundos)
        {
            //Arrange
            string mensajeExp = "1 mes";
            TimeSpan timeSpan = new TimeSpan(dias, horas, minutos, segundos);

            //Act
            TiempoTranscurridoMes tiempoTranscurrido = new TiempoTranscurridoMes();
            string mensajeAct = tiempoTranscurrido.ObtenerMensajeTiempoTranscurrido(timeSpan);

            //Assert
            Assert.AreEqual(mensajeExp, mensajeAct);
        }

        [TestMethod()]
        public void ObtenerMensajeTiempoTranscurrido_TimespanEquivalenteAMasDeUnMes_RegresaMensajeQueIndicaMeses()
        {
            //Arrange
            string mensajeExp = "2 meses";
            TimeSpan timeSpan = new TimeSpan(60, 23, 59, 59);

            //Act
            TiempoTranscurridoMes tiempoTranscurrido = new TiempoTranscurridoMes();
            string mensajeAct = tiempoTranscurrido.ObtenerMensajeTiempoTranscurrido(timeSpan);

            //Assert
            Assert.AreEqual(mensajeExp, mensajeAct);
        }

        [TestMethod()]
        public void ObtenerMensajeTiempoTranscurrido_TimespanEquivalenteAMenosDeUnMes_RegresaMensajeVacio()
        {
            //Arrange
            string mensajeExp = "";
            TimeSpan timeSpan = new TimeSpan(0, 0, 59, 3);

            //Act
            TiempoTranscurridoMes tiempoTranscurrido = new TiempoTranscurridoMes();
            string mensajeAct = tiempoTranscurrido.ObtenerMensajeTiempoTranscurrido(timeSpan);

            //Assert
            Assert.AreEqual(mensajeExp, mensajeAct);
        }
    }
}